using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncWrapperGenerator
{
    using System.IO;
    using System.Reflection;
    using Microsoft.WindowsAzure.Storage.Blob;

    class Program
    {
        private static readonly Assembly SdkAssembly = typeof (CloudBlobClient).Assembly;
        static void Main(string[] args)
        {
            var types = SdkAssembly.GetExportedTypes().Where(t => t.GetMethods().Any(m => m.Name.StartsWith("Begin")));
            foreach (var type in types)
            {
                CreateAsyncExtensionClass(type);
            }
        }

        private static void CreateAsyncExtensionClass(Type type)
        {
            var builder = new CodeBuilder();
            builder.AppendLine("namespace " + type.Namespace);
            builder.AppendLine("{");
            builder.Indent++;
            builder.AppendLine("using System;");
            builder.AppendLine("using System.Collections.Generic;");
            builder.AppendLine("using System.Threading.Tasks;");
            builder.AppendLine("using System.Data.Services.Client;");
            builder.AppendLine("using System.IO;");
            builder.AppendLine("using Protocol;");
            builder.AppendLine("using Shared.Protocol;");
            builder.AppendLine();
            builder.AppendFormat("public static class {0}Async", type.Name);
            builder.AppendLine();
            builder.AppendLine("{");
            builder.Indent++;
            foreach (var beginMethod in type.GetMethods().Where(m => m.Name.StartsWith("Begin") && !m.IsGenericMethod))
            {
                var name = beginMethod.Name.Substring(5);
                MethodInfo endMethod;
                try
                {
                    endMethod = type.GetMethod("End" + name);
                }
                catch
                {
                    continue;
                }
                if (endMethod == null) continue;

                string taskType;
                if (endMethod.ReturnType == typeof (void))
                {
                    taskType = "Task";
                }
                else
                {
                    taskType = string.Format("Task<{0}>", FormatTypeForCode(endMethod.ReturnType));
                }
                builder.AppendFormat("public static {0} {1}Async(", taskType, name);
                builder.AppendFormat("this {0} instance", type.Name);
                var parameters =
                    beginMethod.GetParameters()
                               .Where(p => p.ParameterType != typeof (AsyncCallback) && p.Name != "state")
                               .ToList();
                var paramsParameter = parameters.LastOrDefault(p => p.GetCustomAttributes(typeof(ParamArrayAttribute), false).Any());
                if (paramsParameter != null)
                {
                    parameters.Remove(paramsParameter);
                }
                builder.Append(FormatParameters(parameters));
                if (paramsParameter != null)
                {
                    builder.AppendFormat(", params {0} {1}", paramsParameter.ParameterType.Name, paramsParameter.Name);
                }
                builder.AppendLine(")");
                builder.AppendLine("{");
                builder.Indent++;
                builder.AppendFormat("var ar = instance.Begin{0}(", name);
                if (parameters.Count > 0)
                {
                    builder.Append(string.Join(", ", parameters.Select(p => p.Name)));
                    builder.Append(", ");
                }
                builder.Append("null, null");
                if (paramsParameter != null)
                {
                    builder.AppendFormat(", {0}", paramsParameter.Name);
                }
                builder.AppendLine(");");

                builder.AppendFormat("return Task.Factory.FromAsync");

                if (taskType != "Task")
                {
                    builder.AppendFormat("<{0}>", FormatTypeForCode(endMethod.ReturnType));
                }

                builder.AppendFormat("(ar, instance.End{0});", name);
                builder.AppendLine();
                builder.Indent--;
                builder.AppendLine("}");
            }

            builder.Indent--;
            builder.AppendLine("}");
            builder.Indent--;
            builder.AppendLine("}");

            using (var writer = new StreamWriter(@"..\..\..\AsyncWrapper\" + type.Name + "Async.cs", false))
            {
                writer.Write(builder.ToString());
            }
        }

        private static string FormatParameters(List<ParameterInfo> parameters)
        {
            if (parameters.Count == 0) return string.Empty;
            return ", " + string.Join(", ", parameters.Select(FormatParameter));
        }

        private static string FormatParameter(ParameterInfo parameter)
        {
            var formatted = string.Format("{0} {1}", FormatTypeForCode(parameter.ParameterType), parameter.Name);

            if (parameter.DefaultValue != DBNull.Value)
            {
                formatted += " = " + parameter.DefaultValue.ToString();
            }

            return formatted;
        }

        private static string FormatTypeForCode(Type type)
        {
            if (type.Name == "Nullable`1")
            {
                var innerType = type.GetGenericArguments()[0];
                return innerType.Name + "?";
            }
            if (type.IsGenericType)
            {
                return string.Format("{0}<{1}>", type.Name.Substring(0, type.Name.Length - 2),
                    string.Join(",", type.GetGenericArguments().Select(t => t.Name)));
            }
            return type.Name;
        }
    }
}

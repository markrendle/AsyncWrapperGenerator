using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AsyncWrapperGenerator
{
    public class CodeBuilder
    {
        private readonly StringBuilder _builder = new StringBuilder();
        private bool _newLine;
        public int Indent { get; set; }

        public void AppendFormat(string format, params object[] args)
        {
            WriteIndent();
            _builder.AppendFormat(format, args);
        }

        public void AppendLine(string line = "")
        {
            WriteIndent();
            _builder.AppendLine(line);
            _newLine = true;
        }

        public void Append(string value)
        {
            WriteIndent();
            _builder.Append(value);
        }

        private void WriteIndent()
        {
            if (_newLine)
            {
                _builder.Append("".PadRight(Indent*4));
                _newLine = false;
            }
        }

        public override string ToString()
        {
            return _builder.ToString();
        }
    }
}

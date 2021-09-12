using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Models
{
    public class JsonFormatter : IWriterFormatter
    {
        public string GetBody()
        {
            return "Example in JSON";
        }

        public string GetExtension()
        {
            return "json";
        }

        public override string ToString()
        {
            return "JsonFormatter";
        }
    }
}

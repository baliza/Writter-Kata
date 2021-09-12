using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Models
{
    public class YmlFormatter : IWriterFormatter
    {
        public string GetBody()
        {
            return "Example in YML";
        }

        public string GetExtension()
        {
            return "yml";
        }

        public override string ToString()
        {
            return "YmlFormatter";
        }
    }
}

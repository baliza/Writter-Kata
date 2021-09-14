using Deharo.Writter.Interfaces;
using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Models
{
    public class YmlFormatter : IWriterFormatter
    {
        public string GetBody(VuelingUniversity vUniversity)
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

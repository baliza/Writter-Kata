using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Models
{
    public class XmlFormatter : IWritterFormatter
    {
        public string GetBody()
        {
            return "Example in XML";
        }

        public string GetExtension()
        {
            return "xml";
        }

        public override string ToString()
        {
            return "XmlFormatter";
        }
    }
}

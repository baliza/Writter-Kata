using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Models
{
    public class TxtFormatter : IWriterFormatter
    {
        public string GetBody()
        {
            return "Example in PLAIN TEXT";
        }

        public string GetExtension()
        {
            return "txt";
        }

        public override string ToString()
        {
            return "TxtFormatter";
        }
    }
}

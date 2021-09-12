using Deharo.Writter.Interfaces;
using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Deharo.Writter.Models
{
    public class TxtFormatter : IWriterFormatter
    {
        public string GetBody()
        {
            VuelingUniversity vUniversity = new VuelingUniversity();

            File.WriteAllText(@"C:\Users\gteam\source\repos\Writter-Kata\VuelingUniversity.txt", vUniversity.ToString());
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

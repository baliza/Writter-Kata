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
        public string GetBody(VuelingUniversity vUniversity)
        {

            File.WriteAllText(@"C:\Users\gteam\source\repos\Writter-Kata\VuelingUniversity.txt", vUniversity.ToString());
            return "TXT CREATED";
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

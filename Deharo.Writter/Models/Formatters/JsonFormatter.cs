using Deharo.Writter.Interfaces;
using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Deharo.Writter.Models
{
    public class JsonFormatter : IWriterFormatter
    {
        public string GetBody(VuelingUniversity vUni)
        {
            var json = JsonSerializer.Serialize(vUni);
            //File.WriteAllText(@"C:\Users\gteam\source\repos\Writter-Kata\VuelingUniversity.json", json);
            return json;
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

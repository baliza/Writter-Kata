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
        public string GetBody()
        {
            VuelingUniversity vUniversity = new VuelingUniversity();

            var json = JsonSerializer.Serialize(vUniversity);
            File.WriteAllText(@"C:\Users\gteam\source\repos\Writter-Kata\VuelingUniversity.json", json);

            return "JSON CREATED";
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

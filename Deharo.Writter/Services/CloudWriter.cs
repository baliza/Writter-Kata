using Deharo.Writter.Interfaces;
using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Deharo.Writter.Services
{
    public class CloudWriter : IWriter
    {
        private IWriterFormatter _textFormatter;

        public CloudWriter(IWriterFormatter formater)
        {
            _textFormatter = formater;
        }

        public void WriteBody(string fileName, VuelingUniversity vUni)
        {
            File.WriteAllText(@$"C:\Users\gteam\source\repos\Writter-Kata\VuelingUniversity.{_textFormatter.GetExtension()}", _textFormatter.GetBody(vUni));
            Console.WriteLine($"Archive created Cloud: {fileName}.{_textFormatter.GetExtension()} with body: {_textFormatter.GetBody(vUni)}");
        }

        /* public string GetArchiveBody(string fileName)
         {
             return $"Archive created: {fileName}.{ _textFormatter.GetExtension()} with body: { _textFormatter.GetBody()}";
         }*/

        public override string ToString()
        {
            return $"Cloud: {_textFormatter.GetExtension()}";
        }
    }
}

using Deharo.Writter.Interfaces;
using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Deharo.Writter.Services
{
    public class Writer : IWriter
    {
        private IWriterFormatter _textFormatter;

        public Writer(IWriterFormatter formater)
        {
            _textFormatter = formater;
        }

        public void WriteBody(string fileName, VuelingUniversity vUni)
        {
            File.WriteAllText(@$"C:\Users\gteam\source\repos\Writter-Kata\TargetArchive\{fileName}.{_textFormatter.GetExtension()}", _textFormatter.GetBody(vUni));
            Console.WriteLine($"Archive created: {fileName}.{_textFormatter.GetExtension()} with body: {_textFormatter.GetBody(vUni)}");
        }
    
       /* public string GetArchiveBody(string fileName)
        {
            return $"Archive created: {fileName}.{ _textFormatter.GetExtension()} with body: { _textFormatter.GetBody()}";
        }*/

        public override string ToString()
        {
            return $"Local: {_textFormatter.GetExtension()}";
        }
    }
}

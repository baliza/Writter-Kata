using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Services
{
    public class Writer : IWriter
    {
        private IWritterFormatter _textFormatter;

        public Writer(IWritterFormatter formater)
        {
            _textFormatter = formater;
        }

        public void WriteBody(string fileName)
        {
            Console.WriteLine($"Archive created: {fileName}.{_textFormatter.GetExtension()} with body: {_textFormatter.GetBody()}");
        }
    
       /* public string GetArchiveBody(string fileName)
        {
            return $"Archive created: {fileName}.{ _textFormatter.GetExtension()} with body: { _textFormatter.GetBody()}";
        }*/

        public override string ToString()
        {
            return $"{_textFormatter.GetExtension()} - {_textFormatter.GetBody()}";
        }
    }
}

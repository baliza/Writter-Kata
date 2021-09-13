using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Writter
    {
        private IFormatable _formater;
        public Writter(IFormatable formater)
        {
            _formater = formater;
        }

        public void Write(string fileName)
        {
            Console.WriteLine($"{fileName}.{_formater.GetExtension()} : {_formater.GetContent()}");
        }
    }
}

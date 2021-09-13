using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Format_Txt : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato txt";
        }

        public string GetExtension()
        {
            return "txt";
        }
    }
}

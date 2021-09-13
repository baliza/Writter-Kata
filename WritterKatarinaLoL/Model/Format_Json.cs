using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Format_Json : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato json";
        }

        public string GetExtension()
        {
            return "json";
        }
    }
}

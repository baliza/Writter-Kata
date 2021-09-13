using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Format_Xml : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato xml";
        }

        public string GetExtension()
        {
            return "xml";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Format_Yml : IFormatable
    {
        public string GetContent()
        {
            return "Contenido en formato yml";
        }

        public string GetExtension()
        {
            return "yml";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Format_Txt : IFormatable
    {
        //Las clases format heredan de IFormatable, ya que comparten los métodos GetContent y GetExtension
        // GetContent devolverá el contenido del archivo y GetExtension, la extensión del mismo
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

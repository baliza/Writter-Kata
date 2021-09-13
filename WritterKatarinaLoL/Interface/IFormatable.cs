using System;
using System.Collections.Generic;
using System.Text;

namespace WritterKatarinaLoL.Interface
{
    interface IFormatable
    {
        /// <summary>
        /// Implementará los métodos en las clases de los archivos
        /// </summary>
        /// <returns></returns>
        string GetExtension();
        string GetContent();
    }
}

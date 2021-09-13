using System;
using System.Collections.Generic;
using System.Text;
using WritterKatarinaLoL.Interface;

namespace WritterKatarinaLoL.Model
{
    class Container
    {
        /// <summary>
        /// Diccionario para guardar los formatos de los archivos (string para el nombre, iniciar objeto)
        /// </summary>
        public Dictionary<string, IFormatable> FormatList = new Dictionary<string, IFormatable> {
            {"json", new Format_Json() },
            {"txt", new Format_Txt() },
            {"xml", new Format_Xml() },
            {"yml", new Format_Yml() }
        };

        public Factory Factory;
        public FactoryCloud FactoryCloud;

        public Container(string respuestaUser) //constructor de contenedor, el cual crea un objeto Factory y le pasamos el diccionario como parámetro
        {
            switch (respuestaUser)
            {
                case "Local":
                    Console.WriteLine($"Has elegido escribir en un archivo en local.");
                    Factory.GetWritter("txt").Write("NombreArchivoEnLocal");
                    break;

                case "Nube":
                    Console.WriteLine($"Has elegido escribir en la nube.");
                    FactoryCloud.GetWritter("json").Write("NombreArchivoEnLaNube");
                    break;

                default:
                    Console.WriteLine($"Has escrito mal la respuesta.");
                    break;
            }
        }
    }
}

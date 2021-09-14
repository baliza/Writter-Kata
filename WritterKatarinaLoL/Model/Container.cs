using System;
using System.Collections.Generic;
using System.Text;
using WritterJavi.Interface;
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

        public Factory _factory;
        public FactoryCloud _factoryCloud;

        public Container() 
        {
          
        }

        /// <summary>
        /// un Build que devuelve una interfaz IFactory 8de esta manera sirve para ambos constructores) y le pasamos el tipoFactory
        /// mediante un string, que es la respuestaUser
        /// y con el "if" retornamos un constructor u otro
        /// </summary>
        /// <param name="tipoFactory"></param>
        /// <returns></returns>
        public IFactory Build(string tipoFactory)
        {
            //  if(tipoFactory == "Local")
            //  {
            //      return new Factory(FormatList);
            //  }
            //      return new FactoryCloud(FormatList);

             return tipoFactory == "Local"?  (IFactory)new Factory(FormatList) :  (IFactory)new FactoryCloud(FormatList);
        }
    }
}

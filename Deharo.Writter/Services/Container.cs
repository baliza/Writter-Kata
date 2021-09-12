using Deharo.Writter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Services
{
    public class Container
    {
        public Factory Factory;

        public Container()
        {
            Factory = new Factory(new Dictionary<Models.EFormatTypes, Interfaces.IWritterFormatter> {
            {EFormatTypes.JSON, new JsonFormatter() },
            {EFormatTypes.TXT, new TxtFormatter() },
            {EFormatTypes.XML, new XmlFormatter() },
            {EFormatTypes.YML, new YmlFormatter() }
            });
        }
    }
}

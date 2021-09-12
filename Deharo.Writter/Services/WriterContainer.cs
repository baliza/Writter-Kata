using Deharo.Writter.Interfaces;
using Deharo.Writter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Deharo.Writter.Services
{
    public class WriterContainer
    {
        public IFactory Factory;
        private readonly Dictionary<EFormatTypes, IWriterFormatter> _formatDictionary = new Dictionary<EFormatTypes, IWriterFormatter> {
            {EFormatTypes.JSON, new JsonFormatter() },
            {EFormatTypes.TXT, new TxtFormatter() },
            {EFormatTypes.XML, new XmlFormatter() },
            {EFormatTypes.YML, new YmlFormatter() }
            };

        public WriterContainer(bool isOnCloud)
        {

            if (isOnCloud)
            {
                Factory = new CloudFactory(_formatDictionary);
            }
            else
            {
                Factory = new Factory(_formatDictionary);
            }
            
        }
    }
}

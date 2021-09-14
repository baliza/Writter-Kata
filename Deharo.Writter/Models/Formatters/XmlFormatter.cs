using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Deharo.Writter.Models.Core;
using System.Xml;

namespace Deharo.Writter.Models
{
    public class XmlFormatter : IWriterFormatter
    {
        public string GetBody(VuelingUniversity vUniversity)
        {
            
            XmlSerializer xsSubmit = new XmlSerializer(typeof(VuelingUniversity));
            var xml = "";

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    xsSubmit.Serialize(writer, vUniversity);
                    xml = sww.ToString(); // Your XML
                    Console.WriteLine(xml);
                    return xml;
                }
            }
        }

        public string GetExtension()
        {
            return "xml";
        }

        public override string ToString()
        {
            return "XmlFormatter";
        }
    }
}

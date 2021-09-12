using Deharo.Writter.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using Deharo.Writter.Models.Core;

namespace Deharo.Writter.Models
{
    public class XmlFormatter : IWriterFormatter
    {
        public string GetBody()
        {
            VuelingUniversity vUniversity = new VuelingUniversity();

/*            XmlSerializer xs = new XmlSerializer(typeof(VuelingUniversity));

            TextWriter txtWriter = new StreamWriter(@"C:\Users\gteam\source\repos\Writter-Kata\Serialization.xml");

            xs.Serialize(txtWriter, vUniversity);*/
            XmlSerializer ser = new XmlSerializer(typeof(VuelingUniversity));

            using (FileStream fs = new FileStream(@"C:\Users\gteam\source\repos\Writter-Kata\VuelingUniversity.xml", FileMode.Create))
            {
                ser.Serialize(fs, vUniversity);
            }

            return "XML CREATED";
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

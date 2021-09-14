using Deharo.Writter.Models.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Deharo.Writter.Services
{
    class Reader
    {
        public static VuelingUniversity LoadFromXMLString(string route)
        {
            string target = @"C:\Users\gteam\source\repos\Writter-Kata\BackupArchive";

            string[] archivesList = Directory.GetFiles(route);
            VuelingUniversity vUniversity = new VuelingUniversity();
            vUniversity.StudentsList.Clear();
            // New BackUp
            Parallel.ForEach(archivesList, (fileName) => {
                saveFile(fileName, target);
            });
            // New BackUp
            foreach (var archive in archivesList)
            {
                using (var stringReader = new System.IO.StringReader(File.ReadAllText(archive)))
                {
                    var serializer = new XmlSerializer(typeof(Student));
                    Student newStudent = serializer.Deserialize(stringReader) as Student;
                    vUniversity.StudentsList.Add(newStudent);
                }
            }
            return vUniversity;
        }
        private static void saveFile(string each, string destiny)
        {
            var list = each.Split("\\");
            var name = list[list.Length - 1];
            try
            {
                File.Copy(each, $@"{destiny}\{name}");
            }
            catch (IOException ex)
            {
                Console.WriteLine($"The archive {name} already exists, will be overwrited");
                File.Delete($@"{destiny}\{name}");
                File.Copy(each, $@"{destiny}\{name}");
            }
            catch(Exception e)
            {
                Console.WriteLine("Error on saveFile");
            }

        }
    }
}

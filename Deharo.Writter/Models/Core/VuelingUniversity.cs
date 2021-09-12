using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Deharo.Writter.Models.Core
{
    [Serializable]
    [XmlRoot("Vueling_University")]
    public class VuelingUniversity
    {
        [XmlArray("StudentsList"), XmlArrayItem(typeof(Student), ElementName = "Student")]
        public List<Student> StudentsList { get; set; }

        public VuelingUniversity()
        {
            StudentsList = new List<Student>();
            StudentsList.Add(new Student("Nacho", "De Haro", false, 8.43));
            StudentsList.Add(new Student("Maria", "Apellido1", false, 6.93));
            StudentsList.Add(new Student("Arturo", "Apellido2", true, 9.02));
            StudentsList.Add(new Student("Raul", "Cabrejas", false, 7.43));
            StudentsList.Add(new Student("Javier", "Apellido3", true, 8.43));
        }

        public override string ToString()
        {
            string testString = String.Join("\n", StudentsList.Select(s => s.ToString()).ToList());
            return testString;
        }
    }
}

using System;

namespace Deharo.Writter.Models.Core
{
    [Serializable]
    public class Student
    {

        public string _Name { get; set; }
        public string _LastName { get; set; }
        public bool _IsFromDual { get; set; }
        public double _Mark { get; set; }

        public Student()
        {

        }
        public Student(string name, string lastName, bool isFromDual, double mark)
        {
            _Name = name;
            _LastName = lastName;
            _IsFromDual = isFromDual;
            _Mark = mark;
        }

        public override string ToString()
        {
            return $"name: {_Name}, lastName: {_LastName}, isFromDual: {_IsFromDual}, mark: {_Mark}";
        }
    }
}
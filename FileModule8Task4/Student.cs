using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileModule8Task4
{
    [Serializable]
    class Student
    {
        public string Name { get; set; }
        public string Group { get; set; }
        public DateTime BirthDate { get; set; }

        public Student (string n, string g, DateTime b)
        {
            Name = n;
            Group = g;
            BirthDate = b;

        }


    }
}

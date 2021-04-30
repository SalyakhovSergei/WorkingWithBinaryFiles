using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileModule8Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.ReadFile();
 
        }
    }
}

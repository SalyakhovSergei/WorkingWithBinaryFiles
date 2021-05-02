using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileModule8Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/admin/Desktop/Students.dat";
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream (path, FileMode.Open))
            {
#pragma warning disable SYSLIB0011
                var st = (Student)formatter.Deserialize(fs);
                Console.WriteLine($"Имя: {st.Name} группа {st.Group} дата {st.BirthDate}");
           }

            Console.ReadLine();
            
 
        }
    }
}

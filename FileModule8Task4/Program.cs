using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/admin/Desktop/Students.dat";
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream fs = new FileStream (path, FileMode.Open))
            {

#pragma warning disable SYSLIB0011 // Тип или член устарел
                Student st = (Student)formatter.Deserialize(fs);
#pragma warning restore SYSLIB0011 // Тип или член устарел
                Console.WriteLine($"Имя: {st.Name} группа {st.Group} дата {st.BirthDate}");
           }

            Console.ReadLine();
            
        }
    }

}

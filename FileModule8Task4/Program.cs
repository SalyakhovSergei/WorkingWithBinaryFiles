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
                Student [] st = (Student[])formatter.Deserialize(fs);

                foreach (var df in st)
                {
                    Console.WriteLine($"Имя: {df.Name} группа {df.Group} дата {df.BirthDate}");
                }
            }
            Console.ReadLine();
        }
    }

}

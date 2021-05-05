using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:/Users/Анатолий/Desktop/Students.dat";
            BinaryFormatter formatter = new BinaryFormatter();
            
            Directory.CreateDir();

            using (FileStream fs = new FileStream (path, FileMode.Open))
            {
                Student [] students = (Student[])formatter.Deserialize(fs);

                foreach (var st in students)
                {
                    string filePath = $"C:/Users/Анатолий/Desktop/Students/{st.Group}.txt";
                    if (!File.Exists(filePath))
                    {
                        using (StreamWriter sw = File.AppendText(filePath))
                        sw.WriteLine(st.Name + " " + st.BirthDate);
                    }
                    else 
                    {
                        using (StreamWriter sw = File.AppendText(filePath))
                            sw.WriteLine(st.Name + " " + st.BirthDate);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

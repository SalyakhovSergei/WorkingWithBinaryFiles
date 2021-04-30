using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileModule8Task4
{
    class Student
    {
        string name;
        

        public string path = "C:/Users/Анатолий/Desktop/Students.dat";

        public void ReadFile()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    fs.Position = 0x123;
                    name = br.ReadString();

                }
                Console.WriteLine(name);
            }
            
        }
    }
}

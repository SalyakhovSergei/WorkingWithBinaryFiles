using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FinalTask
{
    public class Directory
    {
        public void CreateDir()
        {
            DirectoryInfo newDirectory = new DirectoryInfo("C:/Users/admin/Desktop/testfolder");
            if (!newDirectory.Exists) newDirectory.Create();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task3
{
    class Program
    {
        
        static void Main()
        {
            DirectoryInfo folder= new DirectoryInfo(@"C:\Users\hp\Desktop\Test");
            Print(folder, "");
        }
        static void Print(DirectoryInfo folder,string s)
        {
            Console.WriteLine(s + folder.Name);
            s = s + "   ";
            FileSystemInfo[] x = folder.GetFileSystemInfos();
            foreach(var t in x)
            {
                if (t.GetType() == typeof(DirectoryInfo)) Print(t as DirectoryInfo, s);
                else Console.WriteLine(s+t.Name);
            }
        }
    }
}

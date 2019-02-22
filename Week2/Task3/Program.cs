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
        static void Print(DirectoryInfo d, string s)
        {
            Console.WriteLine(s+d.Name);
            s = s + "   ";
            FileSystemInfo[] fs = d.GetFileSystemInfos();
            foreach(var a in fs)
            {
                if (a.GetType() == typeof(DirectoryInfo)) Print(a as DirectoryInfo, s);
                else Console.WriteLine(s+a);
            }
        }
    }
}

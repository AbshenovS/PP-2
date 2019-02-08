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
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\hp\Desktop\Test");
            FileSystemInfo[] x = dirInfo.GetFileSystemInfos();
            string s = "   ";
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].GetType() == typeof(DirectoryInfo))
                {

                    Console.WriteLine(x[i]);
                    FileSystemInfo[] items = (x[i] as DirectoryInfo).GetFileSystemInfos();
                    PrintInfo(items,s);
                    s = s + "    ";
                    Fldr(items,s);
                }
                else
                {
                    Console.WriteLine(x[i]);
                }

            }
        }
        static void PrintInfo(FileSystemInfo[] x,string s)
        {
            foreach (var t in x)
            {
                Console.WriteLine(s + t.Name);
            }
        }
        static void Fldr(FileSystemInfo[] x,string s)
        {
            
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].GetType() == typeof(DirectoryInfo))
                {
                    FileSystemInfo[] items = (x[i] as DirectoryInfo).GetFileSystemInfos();
                    PrintInfo(items,s);
                }
            }

        }
    }
}

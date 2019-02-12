using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string fldrname = @"C:\Users\hp\Desktop\Test\aw";
            /*string path = Path.Combine(fldrname, "NewFolder");
            path = Path.Combine(path, "2-newfolder");
            Directory.CreateDirectory(path);*/
            string newfile="Newfilenm.txt";
            string path = Path.Combine(fldrname, newfile);
            File.Create(path);
            Console.WriteLine(path);
            //string fldr = @"C:\Users\hp\Desktop\Test\aw";
            string newfldr = @"C:\Users\hp\Desktop\Test\Qw";
            //string newfile = "Filename.txt";
            //string path2 = Path.Combine(path1, newfile);
            string newpath = Path.Combine(newfldr, newfile);
            File.Copy(path, newpath, true);


            
        }
    }
}

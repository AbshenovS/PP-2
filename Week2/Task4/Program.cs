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
            /*string fldrname = @"C:\Users\hp\Desktop\Test\aw";
            string path = Path.Combine(fldrname, "NewFolder");
            path = Path.Combine(path, "2-newfolder");
            Directory.CreateDirectory(path);
            string newfile="Newfilenm.txt";
            string path = Path.Combine(fldrname, newfile);
            File.Create(path);*/
            string filename = "Newfile.txt";
            string fldr = @"C:\Users\hp\Desktop\Test\NewFolder\2-newfolder";
            string newfldr = @"C:\Users\hp\Desktop\Test\Secondfldr";
            string path = Path.Combine(fldr, filename);
            string newpath = Path.Combine(newfldr, filename);
            File.Copy(path, newpath, true);
            File.Delete(path);
            Console.WriteLine("File is copied and original file is deleted succesfully");
        }
    }
}

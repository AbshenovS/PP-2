using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{
    public class Complexnumbers
    {
        public double real;
        public double im;

        public Complexnumbers()
        {

        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            Complexnumbers cn1 = new Complexnumbers();
            cn1.real = double.Parse(Console.ReadLine());
            cn1.im = double.Parse(Console.ReadLine());

            FileStream fs1 = new FileStream(@"C:\Users\hp\Desktop\Test\seri1.txt", FileMode.Create, FileAccess.Write);

            ToSerialize(cn1, fs1);

            Complexnumbers cn2 = new Complexnumbers();
            cn2.real = double.Parse(Console.ReadLine());
            cn2.im = double.Parse(Console.ReadLine());

            FileStream fs2 = new FileStream(@"C:\Users\hp\Desktop\Test\seri2.txt", FileMode.Create, FileAccess.Write);
            ToSerialize(cn2, fs2);

            FileStream fs11 = new FileStream(@"C:\Users\hp\Desktop\Test\seri1.txt", FileMode.Open, FileAccess.Read);
            ToDeserialize(fs11);

            FileStream fs22 = new FileStream(@"C:\Users\hp\Desktop\Test\seri2.txt", FileMode.Open, FileAccess.Read);
            ToDeserialize(fs22);

        }

        static void ToSerialize(Complexnumbers cn, FileStream fs)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complexnumbers));
            
            xs.Serialize(fs, cn);
            fs.Close();
          
        }

        static void ToDeserialize(FileStream fs)
        {
            XmlSerializer xs = new XmlSerializer(typeof(Complexnumbers));
        

            Complexnumbers cn = xs.Deserialize(fs) as Complexnumbers;
            if (cn.im < 0) Console.WriteLine(cn.real + "" + cn.im + "i");
            else Console.WriteLine(cn.real+"+"+cn.im+"i");

            fs.Close();
        }
    }
}

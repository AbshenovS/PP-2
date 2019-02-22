using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    public class Mark
    {
        public int points;
        public string letter;

        public Mark(int n)
        {
            points = n;
            
        }

        public Mark()
        {

        }

        public string getLetter()
        {
            if (points <= 100 && points >= 95) return "A";
            else if (points <= 94 && points >= 90) return "-A";
            else if (points <= 89 && points >= 85) return "B+";
            else if (points <= 84 && points >= 80) return "B";

            return "F";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Mark> l = new List<Mark>();
            Mark a1 = new Mark(94);
            a1.letter = a1.getLetter();
            l.Add(a1);

            Mark a2 = new Mark(67);
            a2.letter = a2.getLetter();
            l.Add(a2);

            Mark a3 = new Mark(98);
            a3.letter = a3.getLetter();
            l.Add(a3);

            Mark a4 = new Mark(86);
            a4.letter = a4.getLetter();
            l.Add(a4);

            FileStream fs = new FileStream(@"C:\Users\hp\Desktop\Test\seri1.txt", FileMode.OpenOrCreate, FileAccess.Write);
            ToSerialize(l, fs);

            FileStream fss = new FileStream(@"C:\Users\hp\Desktop\Test\seri1.txt", FileMode.Open, FileAccess.Read);
            ToDeserialize(fss);

        }

        static void ToSerialize(List<Mark> a, FileStream fs)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));

            xs.Serialize(fs, a);
            fs.Close();

        }
        static void ToDeserialize(FileStream fs)
        {
            XmlSerializer xs = new XmlSerializer(typeof(List<Mark>));

            List<Mark> l = xs.Deserialize(fs) as List<Mark>;
            for(int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i].points + " " + l[i].letter);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public string id;
        public int year = 0;

        public Student(string nname, string iid)
        {
            name = nname;
            id = iid;

        }

        public string Accessname()
        {
            return name;
        }

        public string Accessid()
        {
            return id;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string i = Console.ReadLine();
            Student a = new Student(n, i);
            Console.WriteLine(a.Accessname() + " " + a.Accessid() + " " );
        }
    }
}
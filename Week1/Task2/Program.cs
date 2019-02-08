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
        public int year;

        public Student(string nname, string iid)
        {
            name = nname;
            id = iid;
            year = 0;
    }

        public string Accessname()
        {
            return name;
        }

        public string Accessid()
        {
            return id;
        }
        public void Show(Student a)
        {
            year++;
            Console.WriteLine(a.Accessname() + " " + a.Accessid() +" "+year);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string i = Console.ReadLine();
            Student a = new Student(n, i);
            Student b = new Student("Mask", "19BD99");
            a.Show(a);
            b.Show(b);
            a.Show(a);
            
        }
    }
}
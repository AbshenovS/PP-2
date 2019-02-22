using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student                               //new class with name Student
    {
        public string name;
        public string id;                       //variables of class
        public int year;

        public Student(string nname, string iid) //constructor with two parametrs
        {
            name = nname;
            id = iid;
            year = 0;
        }

        public string Accessname()              //method to access name of object
        {
            return name;
        }

        public string Accessid()                //method to access id of student
        {
            return id;
        }
        public void Show(Student a)             //method to show informations about student
        {
            year++;
            Console.WriteLine(a.Accessname() + " " + a.Accessid() + " " + year);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            string i = Console.ReadLine();
            Student a = new Student(n, i);      //new object of class
            Student b = new Student("Mask", "19BD99");
            a.Show(a);
            b.Show(b);
            a.Show(a);                          //call of function

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Object
            //string name = "Seynur";
            //string surname = "Memmedov";
            //int age = 18;

            //string name1 = "Kamil";
            //string surname1 = "Memmedov";
            //int age1 = 18;

            //anonimous object
            //var stu1 = new
            //{
            //    name="Seynur",
            //    surname="Memmedov",
            //    age=18
            //};

            //var stu2 = new 
            //{
            //    name = "Kamil",
            //    surname = "Memmedov",
            //    age = 18
            //};
            //Console.WriteLine($"{stu1.name} {stu1.surname}");
            //Console.WriteLine(stu2.name);
            #endregion


            //instance
            Person p1 = new Person("Kamran", "Jabiyev", 30);
            p1.Age = 31;
            Console.WriteLine(p1.Info());

            //Person p2 = new Person("Seynur", "Memmedov", 18);
            //Console.WriteLine(p2.Info());

            //Person p3 = new Person();

            Developer d1 = new Developer("Seynur", "Memmedov",18, "Web Developer",1);
            //d1.Name = "Seynur";
            //d1.Surname = "Memmedov";
            //d1.Age = 18;
            //d1.Position = "Web Developer";
            //d1.Experience = 1;
            Console.WriteLine(d1.Info());
            Console.WriteLine(d1.Fullname());

            //var keyword compile zamani teyin edir type-i
            //var a = "Zahid";
            //a = "Memmedov";
            //a = 3;

            //dynamic - run time-da tipi teyin edir
            dynamic a = 5;
            a = true;
            a = "Zahid";
            a = 'a';

        }
    }

}

using System;
namespace ClassObject
{
    partial class Person
    {
        //field
        public string Name;
        public string Surname;
        public int Age;

        //constructor - classin adi ile eyni adda methoddur.
        //ayrica chagrila bilmez,yalniz object instance alinanda ishe dushur.
        //return type yaza bilmersiz
        public Person()
        {
            Console.WriteLine("Insan yaradildi");
        }

        public Person(string name,string surname)
        {
            Name = name;
            Surname = surname;
        }
        public Person(string name,string surname,int age):this(name, surname)
        {
            Age = age;
            //Console.WriteLine("Insan yaradildi");
        }
    }

}

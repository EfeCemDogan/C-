using System;
using System.Globalization;
using System.Reflection;

namespace ConsoleApp
{
    class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.SurName = surname;
            Console.WriteLine("Personel nesnesi oluşturuldu.");
        }

        public virtual void Intro()
        {
            Console.WriteLine($"name: {this.Name} Surname: {this.SurName}");
        }
    }

    class Student: Person
    {
        public string StudentNumber { get; set; }
        public Student(string name, string surname, string studentnumber): base(name,surname)
        {
            this.StudentNumber = studentnumber;
            Console.WriteLine("Student nesnesi oluşturuldu.");

        }

        public override void Intro()
        {
            base.Intro();
            {
                Console.WriteLine($"name: {this.Name} surname: {this.SurName} number: {this.StudentNumber}");
            }
        }
    }

    class Teacher: Person
    {
        public string Branch { get; set; }
        public Teacher(string name, string surname, string branch): base(name,surname)
        {
            this.Branch = branch;
        }

        public void Teach()
        {
            Console.WriteLine("I am Teaching...");
        }

        public override void Intro()
        {
            Console.WriteLine($"name: {this.Name} Surname: {this.SurName} branch: {this.Branch}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var p = new Person("Efe", "Doğan");
            var s = new Student("Mert","Bakır","3131");
            var t = new Teacher("Sadık","Turan","Software Developer");

            // t.Intro();
            // t.Teach();

            // s.Intro();

            p.Intro();

        }
    }
}

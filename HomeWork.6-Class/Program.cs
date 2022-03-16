using System;

namespace HomeWork._6_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region class intro
            //Console.WriteLine("Hello World!");
            //DRY

            //string name1 = "Ali";
            //string surname1 = "Talibov";
            //int age1 = 18;

            //string name2 = "Fuad";
            //string surname2 = "Topchiyev";
            //int age2 = 19;

            //var Ali = new
            //{
            //    name1 = "Ali",
            //    surname1 = "Talibov",
            //    age1 = 18,
            //};

            //var Fuad = new
            //{
            //    name2 = "Fuad",
            //    surname2 = "Topchiyev",
            //    age2 = 19,
            //};

            //Console.WriteLine(Ali.name1); 
            //Console.WriteLine(Fuad.name2); 
            #endregion


            Student stu1 = new Student();

            stu1.name = "Fuad";
            stu1.surname = "Topchiyev";
            stu1.age = 19;
            //stu1.FullName();
            //Console.WriteLine(stu1.GetAge());

            //Console.WriteLine($"{stu1.name} {stu1.surname} {stu1.age}");

            Student stu2 = new Student();

            stu2.name = "Ali";
            stu2.surname = "Talibov";
            stu2.age = 19;
            stu2.FullName();
            //Console.WriteLine(stu2.GetAge());

            //Console.WriteLine($"{stu2.name} {stu2.surname} {stu2.age}");
        }
    }
     class Student
    {
        //fields
        public string name;
        public string surname;
        public int age;

        //constructor
        //1. classin adi ile eynidir
        //2. ilk ishe dushen metoddur
        //3. return type olmur
        //public Student()
        //{
        //    Console.WriteLine("constructor ishledi");
        //}
        public Student()
        {

        }
        public Student(string name)
        {
            this.name = name;
        }
        public Student(string name, string surname, int age):this(name)
        {
            
            this.surname = surname;
            this.age = age;
        }
        public void FullName()
        {
            Console.WriteLine($"{name} {surname}");
        }
        public int GetAge()
        {
            return age;
        }






    }



}

using System;

namespace MyApplication
{

    class Student
    {
        protected string name = "Sheeran";
    }

    // derived class
    class Program : Student
    {
        static void Main(string[] args)
        {

            // creating object of derived class
            Program program = new Program();

            // accessing name field and printing it
            Console.WriteLine("Name: " + program.name);
            Console.ReadLine();
        }
    }
}

/* internal
 * 
 */


namespace Assembly
{

    class Student
    {
        internal string name = "Sheeran";
    }

    class Program
    {
        static void Main(string[] args)
        {

            // creating object of Student class
            Student theStudent = new Student();

            // accessing name field and printing it
            Console.WriteLine("Name: " + theStudent.name);
            Console.ReadLine();
        }
    }
}
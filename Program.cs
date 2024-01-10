using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring a varible
            int age;
            string name;
            double salary;

            // Declare and initialize
            string degree = "BSC";
            //Initialize a variable
            age = 23;
            name = "Vision";
            salary = 9000.5;

            Console.WriteLine("Hi, " + name);
            Console.WriteLine("Your age is : " + age);
            Console.WriteLine("Your salary is : "+salary);
            Console.WriteLine("Your degree is : " + degree);


            //Changing a varable age
            age = age+5;
            Console.WriteLine("In ten years Your age will be : " + age);

            //Freeze the screen
            Console.ReadLine();
        }
    }
}

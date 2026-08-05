using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string dep, name;
            Console.WriteLine("Welcome to Marwadi University");
            age = 19;
            name = "Jeet";
            dep = "CE";
            Console.WriteLine("Welcome " + name + " You are from " + dep + "Your age is " + age);
            age = Convert.ToInt32(Console.ReadLine());
            name = "Jay";
            dep = "CE AI";

            Console.WriteLine("Wellocme {2} to department of {1}, your age is {0}", age, dep, name);


            EC1.Displayage(ref age);

            if (age < 18)
            {
                Console.WriteLine("You are not eligible for voting");
            }
            else
            {
                Console.WriteLine("You are eligible to vote");
            }

            Manager mgr = new Manager();
            mgr.name = name;
            mgr.age = age;
            mgr.tmsize = 5;
            mgr.HoldMeeting();
            Console.ReadKey();

        }
    }
    public class EC1
    {
        public static void Displayage(ref int a)
        {
            a = a + 5;
        }

    }


    public class Employee
    {
        public string name;
        public int age;

        public void work()
        {
            Console.WriteLine("${name} is working");
        }
    }

    public class Manager : Employee
    {

        public int tmsize;
        public void HoldMeeting()
        {
            Console.WriteLine($"{name} is leading a meeting with {tmsize} people.");
        }
    }

}

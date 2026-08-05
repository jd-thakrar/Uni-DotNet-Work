using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();

            s1.applicaiton();
            s1.isscholar();
            s1.showdata();

            Console.ReadKey();

        }
    }
    class Student
    {
        public int enrollment;
        public string name;
        public int age;
        public string Dep;

        private int fees;
        private bool scholar;
        private double finalfees;
        public Student()
        {
            enrollment = 0;
            name = "";
            age = 0;
            Dep = "Computer Eng";
            fees = 0;
            scholar = false;
            finalfees = 0;
        }

        public void applicaiton()
        {

            Console.WriteLine("------------------------------------");
            Console.WriteLine("    Wellcome to Student Module");
            Console.WriteLine("------------------------------------");

            Console.Write("Enter the enrollment no.: ");
            enrollment = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the Name: ");
            name = Console.ReadLine();

            Console.Write("Enter the age: ");
            age = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the Department: ");
            //Dep = Console.ReadLine();

            Console.Write("Enter the Fees: ");
            fees = Convert.ToInt32(Console.ReadLine());
        }

        public void isscholar()
        {
            if (fees <= 50000)
            {
                scholar = true;
            }
            else
            {
                scholar = false;
            }
        }

        public void showdata()
        {
            finalfees = fees;
            if (scholar)
            {
                finalfees = fees - (fees * 0.10);
            }

            Console.WriteLine("");

            Console.WriteLine("------------------------------------");
            Console.WriteLine("         Student Details");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("Name of Student: " + name);

            Console.WriteLine("enrollment : " + enrollment);

            Console.WriteLine("age : " + age);

            Console.WriteLine("fees : " + fees);

            Console.WriteLine("Department : " + Dep);

            Console.WriteLine("scholarship is applicable : " + scholar);

            Console.WriteLine("Final Fees : " + finalfees);

            Console.ReadKey();
        }
    }

}

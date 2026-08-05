using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical___2
{
    class Employee
    {
        public int Empid;
        public string Empname;
        public double Basesalary;

        public Employee()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("        Employee Payroll System");
            Console.WriteLine("-----------------------------------------");
        }

        public void AccepDetails()
        {
            Console.Write("Enter Employee ID: ");
            Empid = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Employee Name: ");
            Empname = Console.ReadLine();

            Console.Write("Enter Employee Base Salary: ");
            Basesalary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Employee ID :" + Empid);
            Console.WriteLine("Employee Name: " + Empname);
            Console.WriteLine("EMployee Base Salary: " + Basesalary);
        }

        public virtual void CalculateNetSalary()
        {
            Console.WriteLine("Calculating Salary....");
        }
    }

    class FullTimeEmp : Employee
    {
        public Double NetSalary;

        public override void CalculateNetSalary()
        {
            var HRA = Basesalary * 0.20;
            var DA = Basesalary * 0.10;
            NetSalary = Basesalary + HRA + DA;
            Console.WriteLine("Calculating Salary of Full Time Employee.....");
            Console.WriteLine("Net Salary of Employee: " + NetSalary);
        }
    }
    class PartTimeEmp : Employee
    {
        public Double NetSalary;

        public override void CalculateNetSalary()
        {
            NetSalary = Basesalary;
            Console.WriteLine("Calculating Salary of Part Time Employee.....");
            Console.WriteLine("Net Salary of Employee: " + NetSalary);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            Console.WriteLine("1. Full Time Employee");
            Console.WriteLine("2. Part Time Employee");
            Console.Write("Select the type of EMployee: ");
            choice = Convert.ToInt32(Console.ReadLine());
            Employee emp = null;

            if (choice == 1)
            {
                emp = new FullTimeEmp();
            }
            else if (choice == 2)
            {
                emp = new PartTimeEmp();
            }
            else
            {
                Console.Write("Enter Valid Choice");
            }

            emp.AccepDetails();
            emp.DisplayDetails();
            emp.CalculateNetSalary();

            Console.ReadKey();

        }
    }
}

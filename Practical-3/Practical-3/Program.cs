using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_3
{
    class Expense
    {
        public int Expid;
        public string Category;
        public double Amount;
        public string Payment_Method;
        public DateTime Date;


        public void addExpense()
        {
            Console.Write("Enter Expense ID:");
            Expid = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Category:");
            Category = Console.ReadLine();

            Console.Write("Enter Amount:");
            Amount = Convert.ToDouble(Console.ReadLine());

            try
            {
                if (Amount < 0)
                {
                    throw new ArgumentException("Expense cannot be negative.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.Write("Enter Amount:");
                Amount = Convert.ToDouble(Console.ReadLine());
            }

            Console.Write("Enter Payment Method:");
            Payment_Method = Console.ReadLine();

            Console.Write("Enter Date (DD-MM-YYYY):");
            Date = DateTime.Parse(Console.ReadLine());
        }

        public void displayExpense()
        {
            Console.WriteLine("Expense ID: " + Expid);
            Console.WriteLine("Category: " + Category);
            Console.WriteLine("Amount: " + Amount);
            Console.WriteLine("Payment Method: " + Payment_Method);
            Console.WriteLine("Date: " + Date.ToString("yyyy-MM-dd"));
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Expense> expenses = new List<Expense>();
            int i = 0;
            do
            {
                Console.WriteLine("==============================================");
                Console.WriteLine("         Expense Management System");
                Console.WriteLine("==============================================");
                Console.WriteLine("1. Add Expense");
                Console.WriteLine("2. Display Expenses");
                Console.WriteLine("3. Total Expense Amount");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                try
                {
                    i = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Enter Valid Integer Choice");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                }
                Expense e = new Expense();
                if (i == 1)
                {
                    e.addExpense();
                    expenses.Add(e);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Expense Added Successfully");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();

                }
                else if (i == 2)
                {
                    foreach (Expense exp in expenses)
                    {
                        exp.displayExpense();
                        Console.WriteLine("----------------------------------------------");
                        Console.WriteLine();
                    }
                }
                else if (i == 3)
                {
                    double sum = 0;
                    foreach (Expense exp in expenses)
                    {
                        sum += exp.Amount;

                    }
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Total Expense Amount: " + sum);
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();

                }
                else if (i == 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Exiting the Program");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                }
            } while (i < 4);
        }
    }
}

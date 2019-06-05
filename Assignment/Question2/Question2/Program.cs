using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{

    class Employee
    {
        private string name;
        private double salary;
        private double tax;

        public string Name { get { return name; } set { name = value; } }
        public double Salary { get { return salary; } set { salary = value; } }
        public double Tax { get { return tax; } set { tax = value; } }

        public Employee()
        {
            Console.WriteLine("Employee Record Created");
        }
        public Employee(string _name, double _salary, double _tax)
        {
            Console.WriteLine("Employee Record Created Using Inputted Data");
            Name = _name;
            Salary = _salary;
            Tax = _tax;
        }
        public string Record()
        {
            return " \nEmployee Name: " + Name + "\nEmployee's Salary: " + salary + "\nEmployee's Tax Rate: " + Tax;
        }
    }


    public class Program
    {
         public static void Main(string[] args)
        {           
            Console.WriteLine("****PAYROLL SYSTEM****\n----------------------");
            Console.Write("Welcome to the Payroll System. \nPlease enter the Employee's name: ");
            string name = Console.ReadLine();
            Console.Write("Please enter the employee's annual gross salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Please enter the employee's tax rate: ");
            double tax = double.Parse(Console.ReadLine());

            Employee employee1 = new Employee();
            Console.WriteLine(employee1.Record());
            

            Console.ReadLine();
            



        }
    }
}

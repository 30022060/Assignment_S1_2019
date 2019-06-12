using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        //Liam Sullivan ID:30022060 COMP.5202 Assignment
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("****ROTORUA THERMAL HOLIDAY PARK****\n------------------------------------");
            Console.Write("\nPlease enter your Username: ");
            string user = Console.ReadLine();
            Console.Write("Please enter a Password: ");
            string pass = Console.ReadLine();

            Console.Write("Please type your username again: ");
            string input = Console.ReadLine();
            while(input != user)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR. USERNAME DOES NOT MATCH.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease type your username again: ");
                input = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("USERNAME SET!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Please type your password again: ");
            string input2 = Console.ReadLine();
            while (input2 != pass)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR. PASSWORD DOES NOT MATCH.");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nPlease type your password again: ");
                input2 = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("PASSWORD SET!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n****APPROVED USER****");
            Console.ReadLine();
            
            
        } 
         
    }
}

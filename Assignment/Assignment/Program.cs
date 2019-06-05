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
            Console.Write("Please enter a password: ");
            string pass = Console.ReadLine();

            bool loop = true;
            {
                Console.Write($"Welcome {user}, please enter your password again: ");
                string check = Console.ReadLine();

                             
            }   while (loop);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("****APPROVED****");
                Console.ReadLine();
            
            
        } 
         
    }
}

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
            
            do
            {
              Console.WriteLine("Please type your username again");
              string input = Console.ReadLine();
              
            } while (user != input);


            Console.WriteLine("****APPROVED****");
            Console.ReadLine();
            
            
        } 
         
    }
}

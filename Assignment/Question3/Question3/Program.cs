using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[,] array1 = new int[3, 3] = rand.Next((-10), 10);
            Console.ReadLine();
        }
    }
}

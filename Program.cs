using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // - double nested loops
            // - 

            Console.WriteLine("Double Nested loops");
            Console.WriteLine();

            //make a loop inside another loop
            //1...10
            //1...10
            //inside the loop, display the loop variables
            //================================                   ========================              
            //BEFORE YOU EXECUTE, predict what will be displayed AND TALK TO ME!!! (Matt)
            //================================                   ========================


            int numBase = 2;  //how many digits

            for (int i = 0; i <= 9; i++) //i++ = (i = i + 1) //And finally this line.
            {
                for (int j = 0; j <= 9; j++) //Then goes up to this loop
                {
                    Console.WriteLine(i + "" + j + "");
                }
            }


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1

{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            string y;
            int newNum;

             Console.WriteLine("Can you enter a number between 1 and 100?");
             y = Console.ReadLine();
            //x = Convert.ToInt32(Console.ReadLine());
            if (Int32.TryParse(y, out newNum))
            {
                for (int i = 1; i < newNum + 1; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine("fizzbuzz");
                    }
                    else if (i % 3 == 0)
                    {

                        Console.WriteLine("fizz");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.WriteLine("buzz");
                    }
                    else
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            Console.ReadLine();




            
        }

    }
}

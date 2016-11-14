using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
         
            Console.WriteLine("Please Enter first number:");
            
            while (!Int32.TryParse(Console.ReadLine(), out j))
                {
                Console.WriteLine("You entered not a number. Please enter again!!!");
                }


            for (int i=j; i<=(j+100); i++)
            if (i%3==0 && i%5!=0)
            {
                WriteFizz();
            }
            else if (i%5==0 && i%3!=0)
                {
                    WriteBuzz();
                }

            else if (i%3==0 & i%5==0)
                {
                    WriteFizzBuzz();
                }

                else
                {
                    Console.WriteLine(i);
                }


            Console.ReadLine();
        }

        static void WriteFizz()
        {
            Console.WriteLine("Fizz");
        }

        static void WriteBuzz()
        {
            Console.WriteLine("Buzz");
        }

        static void WriteFizzBuzz()
        {
            Console.WriteLine("FizzBuzz");
        }
    }
}

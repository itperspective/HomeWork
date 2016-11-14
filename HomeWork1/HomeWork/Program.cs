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

            int a = 0;
            int b = 0;

    

            Console.WriteLine("Please enter 1st number:");

            bool isNumber1 = false;

            while (!isNumber1)
            {
                isNumber1 = Int32.TryParse(Console.ReadLine(), out a);

                if (!isNumber1)
                {
                    Console.WriteLine("You entered not a number");
                    Console.WriteLine("Please Enter 1st number again:");
                }

                else
                {
                    Console.WriteLine("Thanks for entered 1st number");
                }
            }
                Console.WriteLine("Please Enter 2nd number:");

                bool isNumber2 = false;
            
            while (!isNumber2 || b==0)
                {

                   
                            isNumber2 = Int32.TryParse(Console.ReadLine(), out b);
                            if (!isNumber2 || b==0)
                            {

                                Console.WriteLine("You entered second number, that is not a number or 0");
                                Console.WriteLine("Please enter 2nd number again:");
                            }

                            else
                            {
                                Console.WriteLine("Thanks for entering 2nd number correctly");
                            }

                        }

 
             int intResult = a / b;
             int Remainer = a % b;
                if (a % b == 0)
                {                     
                    Console.WriteLine("{0} is a devider of {1}", b, a);
                    Console.WriteLine("The result of a devision is:{0}", intResult);
                    
                }
                else
                {
                    Console.WriteLine("{0} is not a devider of {1}", b, a);
                    Console.WriteLine("The Result of a devision is: {0}, and remainer is {1}", a/b, Remainer);
                }

            Console.ReadLine();
        }
    }
}

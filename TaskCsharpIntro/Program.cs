using System;

namespace TaskCsharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter the numbers");

            //    int number = Convert.ToInt32(Console.ReadLine());

            //    if (number % 2 == 0)
            //    {


            //        Console.WriteLine("Number is even");

            //    }

            //    else
            //    {
            //        Console.WriteLine("Number is odd");
            //    }

            {
                Console.WriteLine("Enter the numbers");

                int a = Convert.ToInt32(Console.ReadLine());
                int b = Convert.ToInt32(Console.ReadLine());

                if( a > b )
                {
                    Console.WriteLine("First number is large");

                }

                else if (a == b)
                {
                    Console.WriteLine("Numbers are equal");
                }


               else


                {

                   
                    Console.WriteLine("Second number is large");

                }

            }
        }
    }
}

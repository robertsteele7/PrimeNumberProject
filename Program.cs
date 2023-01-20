using System;


namespace PrimeNumberProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number you want to check:");
            int number;
            number = Convert.ToInt32(Console.ReadLine());
            int divisors = 0;
            
            for (int i = 1; i <= number; i++) 
            {
                if (number % i == 0) 
                {
                    divisors++;
                }
            }

            if (divisors == 2)
            {
                Console.WriteLine("The entered number is a Prime Number");
            }
            else 
            {
                Console.WriteLine("The entered number is not a Prime Number");
            }
            Console.ReadLine();

        }
    }
}

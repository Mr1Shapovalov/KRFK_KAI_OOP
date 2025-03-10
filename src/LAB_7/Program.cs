using System;

namespace LAB_7
{
    class Program
    {
        static void Main()
        {
            // Task 1
            Console.WriteLine("Even numbers from 2 to 20:");
            for (int i = 2; i <= 20; i += 2)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n");

            // Task 2
            int sum = 0;
            int number;
            Console.WriteLine("Enter numbers to calculate the sum (0 to terminate):");
            while ((number = Convert.ToInt32(Console.ReadLine())) != 0)
            {
                sum += number;
            }
            Console.WriteLine("Sum: " + sum);

            // Task 3
            string password;
            do
            {
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                if (password != "1234")
                {
                    Console.WriteLine("Incorrect password!");
                }
            } while (password != "1234");
            Console.WriteLine("Access allowed!");
        }
    }
}


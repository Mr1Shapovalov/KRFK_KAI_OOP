using System;
using System.Collections.Generic;
namespace LAB_10
{
    class MortgageCalculator
    {
        public static void Main()
        {
            CalculateMortgage();
            RequestQueue.ManageQueue();
        }
        static void CalculateMortgage()
        {
            Console.Write("Enter loan amount: ");
            decimal P = decimal.Parse(Console.ReadLine());
            Console.Write("Enter annual interest rate (%): ");
            decimal r = decimal.Parse(Console.ReadLine()) / 1200;
            Console.Write("Enter loan term (years): ");
            int n = int.Parse(Console.ReadLine()) * 12;
            decimal M = P * (r * (decimal)Math.Pow((double)(1 + r), n)) / ((decimal)Math.Pow((double)(1 + r), n) - 1);
            Console.WriteLine($"Monthly Payment: {Math.Round(M, 2)}");
        }
    }
    class RequestQueue
    {
        static Queue<string> queue = new Queue<string>();

        public static void ManageQueue()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Request\n2. Process Request\n3. View First Request\n4. View All Requests\n5. Exit");
                string choice = Console.ReadLine();
                if (choice == "5") break;
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter request: ");
                        queue.Enqueue(Console.ReadLine());
                        break;
                    case "2":
                        Console.WriteLine(queue.Count > 0 ? $"Processed: {queue.Dequeue()}" : "Queue is empty.");
                        break;
                    case "3":
                        Console.WriteLine(queue.Count > 0 ? $"First request: {queue.Peek()}" : "Queue is empty.");
                        break;
                    case "4":
                        foreach (var item in queue) Console.WriteLine(item);
                        break;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
namespace LAB_11
{
    class Program
    {
        static void Main()
        {
            //Task1
            SupportSystem();
            //Task2
            TextAnalyzer();
        }
        //Task1: 
        static void SupportSystem()
        {
            Queue<string> queue = new Queue<string>();
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add request");
                Console.WriteLine("2. Process request");
                Console.WriteLine("3. View first request");
                Console.WriteLine("4. Show all requests");
                Console.WriteLine("5. End task 1");
                Console.Write("Your choice: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter request text: ");
                        string request = Console.ReadLine();
                        queue.Enqueue(request);
                        Console.WriteLine("Request added!");
                        break;
                    case "2":
                        if (queue.Count > 0)
                        {
                            Console.WriteLine($"Request \"{queue.Dequeue()}\" processed!");
                        }
                        else
                        {
                            Console.WriteLine("Queue is empty!");
                        }
                        break;
                    case "3":
                        Console.WriteLine(queue.Count > 0 ? $"First request: {queue.Peek()}" : "Queue is empty!");
                        break;
                    case "4":
                        Console.WriteLine(queue.Count > 0 ? $"All requests: {string.Join(", ", queue)}" : "Queue is empty!");
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Try again.");
                        break;
                }
            }
        }
        //Task2: 
        static void TextAnalyzer()
        {
            Console.Write("Enter text: ");
            string input = Console.ReadLine().ToLower();
            char[] separators = { ' ', ',', '.', '!', '?', ';', ':', '\n', '\t' };
            string[] words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> wordCount = new Dictionary<string, int>();
            foreach (string word in words)
            {
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;
                else
                    wordCount[word] = 1;
            }
            var sortedWords = wordCount.OrderByDescending(pair => pair.Value);
            Console.WriteLine("\nWord statistics:");
            foreach (var pair in sortedWords)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
        }
    }
}

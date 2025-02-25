using System;

namespace LAB_4
{
    class Program
    {
        static void Main()
        {
            //1
            int age = 18;
            double weight = 70.0;
            char grade = 'A';
            bool isStudent = true;
            string name = "Mychailo";
            Console.WriteLine($"Age: {age}\nWeight: {weight}\nGrade: {grade}\nStudent: {isStudent}\nName: {name}");

            //2
            Console.Write("Enter a number: ");
            double x = Convert.ToDouble(Console.ReadLine());
            int y = (int)x;
            string z = y.ToString();
            Console.WriteLine($"Double: {x}\nInt: {y}\nString: {z}");

            //3
            Console.Write("Enter your name: ");
            string Name = Console.ReadLine();
            Console.Write("Enter your age: ");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Hello, {Name}! Your age is: {Age} years.");

            //4
            Console.Write("Enter the distance (km): ");
            double s = double.Parse(Console.ReadLine());
            Console.Write("Enter the time (hours): ");
            double t = double.Parse(Console.ReadLine());
            double v = s / t;
            Console.WriteLine($"Average speed: {v} km/h");

            //5
            Console.Write("Enter a sentence: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Length: {text.Length} characters");
            Console.WriteLine($"Uppercase: {text.ToUpper()}");
            Console.WriteLine($"Replaced spaces: {text.Replace(" ", "-")}");
            Console.WriteLine($"First 5 characters: {text.Substring(0, Math.Min(5, text.Length))}");
        }
    }
}
using System;
namespace LAB_12
{
    // Завдання 1: Координати точки
    struct Point
    {
        public double X { get; }
        public double Y { get; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double DistanceTo(Point other)
        {
            return Math.Sqrt(Math.Pow(other.X - X, 2) + Math.Pow(other.Y - Y, 2));
        }
    }
    // Завдання 2: Автомобільний парк
    class Car
    {
        public string Brand { get; }
        public string Model { get; }
        public int Year { get; }
        public string Color { get; }
        public Car(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }
        public Car(string brand, string model, int year)
            : this(brand, model)
        {
            Year = year;
        }
        public Car(string brand, string model, int year, string color)
            : this(brand, model, year)
        {
            Color = color;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}, Color: {Color}");
        }
    }
    // Тестування
    class Program
    {
        static void Main()
        {
            // Тестування 1 завдання
            Point p1 = new Point(3, 4);
            Point p2 = new Point(6, 8);
            Console.WriteLine($"Distance between points: {p1.DistanceTo(p2)}");
            // Тестування 2 завдання
            Car car1 = new Car("BMW", "X5");
            Car car2 = new Car("Audi", "A4", 2019);
            Car car3 = new Car("Mercedes", "C-Class", 2021, "Black");
            car1.ShowInfo();
            car2.ShowInfo();
            car3.ShowInfo();
        }
    }
}

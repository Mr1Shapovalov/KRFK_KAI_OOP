using System;
namespace LAB_17
{
    // Task 1:
    // Student class
    public class Student
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 0 && value <= 120)
                    age = value;
                else
                    Console.WriteLine("Invalid age. Age must be between 0 and 120.");
            }
        }
    }
    // Task 2:
    // Car class
    public class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
        }
        public void Accelerate(int amount)
        {
            if (amount > 0)
                speed += amount;
        }
        public void Brake(int amount)
        {
            if (amount > 0)
            {
                speed -= amount;
                if (speed < 0)
                    speed = 0;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Testing Student class
            Student student = new Student();
            student.Name = "Andrew";
            student.Age = 25;
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}");
            student.Age = -5; 
            Console.WriteLine(); 
            // Testing Car class
            Car car = new Car();
            car.Accelerate(60);
            Console.WriteLine($"After acceleration: {car.Speed} km/h");
            car.Brake(20);
            Console.WriteLine($"After braking: {car.Speed} km/h");
            car.Brake(100);
            Console.WriteLine($"After hard braking: {car.Speed} km/h");
        }
    }
}


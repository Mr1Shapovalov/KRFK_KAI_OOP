using System;
using System.Collections.Generic;
namespace LAB_13
{
    // Завдання 2: 
    class Order
    {
        public event EventHandler<string> OrderStatusChanged;
        private string status;
        public string Status
        {
            get => status;
            set
            {
                if (status != value)
                {
                    status = value;
                    OnOrderStatusChanged(status);
                }
            }
        }
        protected virtual void OnOrderStatusChanged(string status)
        {
            OrderStatusChanged?.Invoke(this, status);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // ЗАВДАННЯ 1
            Console.WriteLine("TASK 1:");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Predicate<int> isEven = n => n % 2 == 0;
            int[] evenNumbers = Filter(numbers, isEven);
            Console.WriteLine("Even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            // ЗАВДАННЯ 2
            Console.WriteLine("\nTASK 2:");
            Order order = new Order();
            order.OrderStatusChanged += OrderStatusChangedHandler;
            order.Status = "Order received";
            order.Status = "Shipped";
            order.Status = "Delivered";
        }
        // ЗАВДАННЯ 1
        static int[] Filter(int[] numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();
            foreach (var number in numbers)
            {
                if (predicate(number))
                    result.Add(number);
            }
            return result.ToArray();
        }
        // ЗАВДАННЯ 2
        static void OrderStatusChangedHandler(object sender, string status)
        {
            Console.WriteLine($"Order status changed to: {status}");
        }
    }
}

using System;
using System.Collections.Generic;

namespace LAB_18
{
    // Task 1
    public interface IAnimal
    {
        void Speak();
        void Eat();
    }
    public class Dog : IAnimal
    {
        public void Speak() => Console.WriteLine("Dog says: Woof!");
        public void Eat() => Console.WriteLine("Dog is eating.");
    }
    public class Cat : IAnimal
    {
        public void Speak() => Console.WriteLine("Cat says: Meow!");
        public void Eat() => Console.WriteLine("Cat is eating.");
    }
    // Task 2
    public interface IPaymentMethod
    {
        void Pay(decimal amount);
    }
    public class CreditCard : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment with credit card: {amount} UAH");
        }
    }
    public class PayPal : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment via PayPal: {amount} UAH");
        }
    }
    public class ApplePay : IPaymentMethod
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Payment via ApplePay: {amount} UAH");
        }
    }
    public class Order
    {
        public IPaymentMethod PaymentMethod { get; set; }
        public Order(IPaymentMethod paymentMethod)
        {
            PaymentMethod = paymentMethod;
        }
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment...");
            PaymentMethod.Pay(amount);
            Console.WriteLine("Payment completed.\n");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Task 1 ");
            List<IAnimal> animals = new List<IAnimal>
            {
                new Dog(),
                new Cat()
            };
            foreach (var animal in animals)
            {
                animal.Speak();
                animal.Eat();
                Console.WriteLine();
            }
            Console.WriteLine(" Task 2 ");
            Order order1 = new Order(new CreditCard());
            order1.ProcessPayment(500);
            Order order2 = new Order(new PayPal());
            order2.ProcessPayment(250);
            Order order3 = new Order(new ApplePay());
            order3.ProcessPayment(300);
        }
    }
}

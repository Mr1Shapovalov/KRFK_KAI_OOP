using System;
using System.Linq;
namespace LAB_8
{
    class Program
    {
        static void Main()
        {
            // Task 1
            int[] numbers = { 12, 15, 7, 20, 33, 50, 8, 11, 90, 45 };
            var filteredNumbers = numbers.Where(n => n % 3 == 0 || n % 5 == 0).ToArray();
            int sum = filteredNumbers.Sum();
            Console.WriteLine("Numbers that are divisible by 3 or 5: " + string.Join(", ", filteredNumbers));
            Console.WriteLine("Sum of numbers: " + sum);

            // Task 2
            string[] productNames = { "Bread", "Milk", "Apples", "Cheese", "Chocolate", "Coffee", "Tea" };
            double[] productPrices = { 25.5, 32.0, 45.3, 120.0, 80.0, 150.0, 75.5 };
            double averagePrice = productPrices.Average();
            Console.WriteLine("\nAverage price: " + averagePrice);
            var expensiveProducts = productNames.Zip(productPrices, (name, price) => new { Name = name, Price = price })
                                                .Where(p => p.Price > averagePrice);
            Console.WriteLine("\nProducts more expensive than the average price:");
            foreach (var product in expensiveProducts)
            {
                Console.WriteLine($"{product.Name}: {product.Price}");
            }
            double minPrice = productPrices.Min();
            double maxPrice = productPrices.Max();
            string cheapestProduct = productNames[Array.IndexOf(productPrices, minPrice)];
            string mostExpensiveProduct = productNames[Array.IndexOf(productPrices, maxPrice)];
            Console.WriteLine($"\nCheapest product: {cheapestProduct} - {minPrice}");
            Console.WriteLine($"Most expensive product: {mostExpensiveProduct} - {maxPrice}");
        }
    }
}

using System;
class LAB_21
{
    // Task 1
    public class Container<T>
    {
        public T Value { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Value: {Value}, Type: {Value.GetType().Name}");
        }
    }
    // Task 2 
    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        T max = array[0];
        foreach (T item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }
    static void Main()
    {
        Console.WriteLine("=== Task 1 ===");
        Container<int> intBox = new Container<int> { Value = 100 };
        Container<string> strBox = new Container<string> { Value = "Hello" };
        intBox.ShowInfo();
        strBox.ShowInfo();
        Console.WriteLine("\n=== Task 2 ===");
        int[] intArr = { 1, 5, 3, 9 };
        double[] doubleArr = { 1.1, 2.5, 0.3 };
        string[] stringArr = { "apple", "banana", "pear" };
        Console.WriteLine($"Max (int): {FindMax(intArr)}");
        Console.WriteLine($"Max (double): {FindMax(doubleArr)}");
        Console.WriteLine($"Max (string): {FindMax(stringArr)}");
    }
}
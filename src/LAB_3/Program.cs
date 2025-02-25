namespace LAB_3
{
    public class program
    {
        public static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
        }
        private static void Task1()

        {
            int userAge = 20;
            string userName = "Andrew";
            Console.WriteLine("Greetings, " + userName + "! Your age: " + userAge);
        }
        private static void Task2()
        {
            int number = 10;
            string message = "No";
            bool isNew = true;
            Console.WriteLine(number + " " + message + " " + isNew);
        }
        private static void Task3()
        {
            // Оголошуємо змінну name та присвоюємо їй значення "Анна"
            string name = "Ana";
            // Оголошуємо змінну age та присвоюємо їй значення 25
            int age = 25;
            // Виводимо на консоль привітання з ім'ям і віком користувача
            Console.WriteLine("Greetings, " + name + "! Your age: " + age);
        }

    }
}

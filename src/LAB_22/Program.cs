using System;
class LAB_22
{
    public interface IGreetingService
    {
        void Greet(string name);
    }
    public class GreetingService : IGreetingService
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
    public class App
    {
        private readonly IGreetingService _greetingService;
        public App(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }
        public void Run()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            _greetingService.Greet(name);
        }
    }
    static void Main(string[] args)
    {
        IGreetingService greetingService = new GreetingService();
        App app = new App(greetingService);
        app.Run();
    }
}

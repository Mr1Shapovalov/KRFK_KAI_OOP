using System;
namespace LAB_24
{
    // Task 1:
    public interface INewPrinter
    {
        void Print(string message);
    }
    public class OldPrinter
    {
        public void OldPrint() => Console.WriteLine("Printing in the old way");
    }
    public class PrinterAdapter : INewPrinter
    {
        private readonly OldPrinter _oldPrinter;
        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }
        public void Print(string message)
        {
            _oldPrinter.OldPrint();
            Console.WriteLine(message);
        }
    }
    // Task 2:
    public class Engine
    {
        public void Start() => Console.WriteLine("Engine started");
    }
    public class Battery
    {
        public void Start() => Console.WriteLine("Battery activated");
    }
    public class IgnitionSystem
    {
        public void Start() => Console.WriteLine("Ignition system started");
    }
    public class CarFacade
    {
        private readonly Engine _engine = new Engine();
        private readonly Battery _battery = new Battery();
        private readonly IgnitionSystem _ignitionSystem = new IgnitionSystem();
        public void StartCar()
        {
            _battery.Start();
            _ignitionSystem.Start();
            _engine.Start();
            Console.WriteLine("Car started");
        }
    }
    // Task 3:
    public interface IWriter
    {
        void Write(string text);
    }
    public class ConsoleWriter : IWriter
    {
        public void Write(string text) => Console.WriteLine(text);
    }
    public class TimestampWriter : IWriter
    {
        private readonly IWriter _inner;
        public TimestampWriter(IWriter inner)
        {
            _inner = inner;
        }
        public void Write(string text)
        {
            string stamped = $"[{DateTime.Now:HH:mm:ss}] {text}";
            _inner.Write(stamped);
        }
    }
    class Program
    {
        static void Main()
        {
            // Task 1: Adapter
            Console.WriteLine("Task 1:");
            OldPrinter oldPrinter = new OldPrinter();
            INewPrinter newPrinter = new PrinterAdapter(oldPrinter);
            newPrinter.Print("This is a new call");
            Console.WriteLine();
            // Task 2: Facade
            Console.WriteLine("Task 2:");
            CarFacade carFacade = new CarFacade();
            carFacade.StartCar();
            Console.WriteLine();
            // Task 3:
            Console.WriteLine("Task 3:");
            IWriter writer = new TimestampWriter(new ConsoleWriter());
            writer.Write("Hello, world!");
        }
    }
}

using System;
namespace LAB_23
{
    // Task 1
    class Logger
    {
        private static Logger _instance;
        private Logger() { }
        public static Logger Instance => _instance ??= new Logger();
        public void Log(string msg) => Console.WriteLine($"[Log] {DateTime.Now}: {msg}");
    }
    // Task 2
    interface INotification { void Send(string msg); }
    class Email : INotification { public void Send(string msg) => Console.WriteLine("Email: " + msg); }
    class SMS : INotification { public void Send(string msg) => Console.WriteLine("SMS: " + msg); }
    class NotifyFactory
    {
        public static INotification Create(string type) => type switch
        {
            "email" => new Email(),
            "sms" => new SMS(),
            _ => throw new Exception("Unknown type")
        };
    }
    // Task 3
    class Computer
    {
        public string CPU, GPU;
        public void Show() => Console.WriteLine($"PC with {CPU}, {GPU}");
    }
    class PCBuilder
    {
        private Computer pc = new();
        public PCBuilder SetCPU(string cpu) { pc.CPU = cpu; return this; }
        public PCBuilder SetGPU(string gpu) { pc.GPU = gpu; return this; }
        public Computer Build() => pc;
    }
    class Program
    {
        static void Main()
        {
            // Task 1
            Logger.Instance.Log("Program started");
            // Task 2
            var n = NotifyFactory.Create("email");
            n.Send("Factory is working!");
            // Task 3
            var myPC = new PCBuilder().SetCPU("i7").SetGPU("RTX").Build();
            myPC.Show();
        }
    }
}


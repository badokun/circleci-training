using System;

namespace DummyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var env = System.Environment.GetEnvironmentVariable("my_secret");
            if (string.IsNullOrEmpty(env)){
                env = "not set";
            }
            Console.WriteLine("Hello World! The secret is " + env);
        }
    }
}

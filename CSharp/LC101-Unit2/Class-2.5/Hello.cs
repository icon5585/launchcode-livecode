using System;
namespace Class_2._5
{
    public class Hello
    {
        private readonly string message;

        public Hello(string message)
        {
            this.message = message;
        }

        public string GetMessage() {
            return message;
        }

        // 5.2.3 Static method example
        public static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        // Auto-generated Equals and HashCode methods provided by Visual Studio :)
        public override bool Equals(object obj)
        {
            return obj is Hello hello &&
                   GetMessage() == hello.GetMessage();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(GetMessage());
        }
    }
}

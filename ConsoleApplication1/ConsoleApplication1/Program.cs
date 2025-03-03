using System;

namespace ConsoleApplication1 {
    internal class Program {
        public static void Main(string[] args) {
            Console.WriteLine("Enter your name: ");
            String name = Console.ReadLine();
            
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("Hello, " + name);
            }
        }
    }
}
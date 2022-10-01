using System;

namespace MyFirstApp._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MyName = "Kostya";
            Console.WriteLine(MyName);

            Console.WriteLine("\tПривет Мир!");
            Console.WriteLine("\tМне 23 года.");
            Console.WriteLine("\tMy name is Kostya\n");

            Console.WriteLine("Привет,\n Мир!");

            Console.WriteLine('\x23');

            Console.ReadKey();
        }
    }
}

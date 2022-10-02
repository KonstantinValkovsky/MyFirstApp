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

            byte MyAge = 23;
            bool pet = true;
            double sizeshoes = 45;
            
            Console.WriteLine("\nMy name is " + MyName);
            Console.WriteLine("My Age " + MyAge);
            Console.WriteLine("Do you have a pet?\t " + pet);
            Console.WriteLine("My shoe size is " + sizeshoes);



            Console.ReadKey();
        }
    }
}

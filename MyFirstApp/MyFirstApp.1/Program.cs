using System;

namespace MyFirstApp._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Как вас зовут? ");
            var name = Console.ReadLine();

            Console.Write("Сколько вам лет? ");
            var age = Console.ReadLine();

            Console.WriteLine($"Вас зовут {name} и вам {age}!");

            Console.Write("Когда вы роделись? ");
            var birthdate = Console.ReadLine();

            Console.WriteLine($"Вы роделись {birthdate}!");


            Console.ReadKey();
        }



    }
}

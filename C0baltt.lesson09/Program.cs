using System;

namespace C0baltt.lesson09
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var secondName = Console.ReadLine();
            Person p = new Person(name, secondName); 
            //Console.ReadLine();

            Console.WriteLine(p.Name);
            Console.WriteLine(p.SecondName);
            Console.WriteLine(p.FullName);
            Console.WriteLine(p.ShortName);

            Console.ReadLine();
        }
    }
}

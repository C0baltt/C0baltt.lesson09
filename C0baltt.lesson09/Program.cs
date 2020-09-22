using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0baltt.lesson09
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("");

            Console.WriteLine(p.GetName());
            Console.ReadLine();
        }
    }
}

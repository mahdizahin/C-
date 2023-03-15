using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            super f1 = new super("Vat", "Mach");
            f1.display();
            Console.WriteLine("\n");
            sub1 s1 = new sub1("Beef", "Chicken", "Juice", "Salad");
            s1.display();
            Console.WriteLine("\n");
            sub2 s21 = new sub2("Beguni","Chola","Bundia","Juice");
            s21.display();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food f1 = new Food("Vat", "Mach");
            f1.display();

            Sehri s1 = new Sehri("Beef","Chicken","Juice","Salad");
            s1.display();
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
     public class Gari
    {
        public int power { get; set; }
        public string color { get; set; }

        public Gari(int power, string color)
        {
            this.power = power; 
            this.color = color;
        }

        public void display()
        {
            Console.WriteLine("Cars Power : "+power);
            Console.WriteLine("Cars Color : "+color);
        }

       public void thikKora()
        {
            Console.WriteLine(" gari thik kora hoise");
        }
    }
}

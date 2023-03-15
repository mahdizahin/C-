using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Food
    {
        

        string item1 { get; set; }
        string item2 { get; set; }



        public Food(string item1, string item2)
        {
            this.item1 = item1;
            this.item2 = item2;
        }

       public void display()
        {
            Console.WriteLine("Item 1 Name : "+item1);
            Console.WriteLine("Item 2 name : " + item2);
        }
    }
}

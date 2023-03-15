using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Sehri : Food                            //Sehri is a sub class
    {
       public string sehriItem1 { get; set; }
       public string sehriItem2 { get; set; }

     public Sehri(string item1,string item2, string sehriItem1, string sehriItem2) : base(item1, item2)
        {
            this.sehriItem1 = item1;
            this.sehriItem2 = item2;    

        }

        public void display()
        {
            base.display();
            Console.WriteLine("Item for Sehri" + sehriItem1);
            Console.WriteLine("Item for Sehri" + sehriItem2);
        }
    }
}

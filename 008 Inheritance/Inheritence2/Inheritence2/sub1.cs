using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence2
{
    internal class sub1 : super
    {
        public string sehriItem1 { get; set; }
        public string sehriItem2 { get; set; }

        public sub1(string item1, string item2, string sehriItem1, string sehriItem2) : base(item1, item2)
        {
            this.sehriItem1 = sehriItem1;
            this.sehriItem2 = sehriItem2;

        }

        public void display()
        {
            base.display();
            Console.WriteLine("Item for Sehri : " + sehriItem1);
            Console.WriteLine("Item for Sehri : " + sehriItem2+"\n");
        }
    }
}

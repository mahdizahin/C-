using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence2
{
    internal class sub2 : super
    {
        public string ifterItem1 { get; set; }
        public string ifterItem2 { get; set; }

        public sub2(string item1, string item2, string ifterItem1, string ifterItem2) : base(item1, item2)
        {
            this.ifterItem1 = ifterItem1;
            this.ifterItem2 = ifterItem2;

        }

        public void display()
        {
            base.display();
            Console.WriteLine("Item for Ifter : " + ifterItem1);
            Console.WriteLine("Item for Ifter : " + ifterItem2 + "\n");
        }
    }
}

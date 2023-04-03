using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs1
{
    public class Obj1_of_abstractClass : AbstractClass
    {
        public  Obj1_of_abstractClass(int x,int y)
        {
            int z = x * y;
        }

        public void display()
        {
            Console.WriteLine("www");
        }
    }
}

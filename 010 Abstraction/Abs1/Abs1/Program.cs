using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //virtual void x (int x) =0;

            Class1 c= new Class1();
            c.display();

            Obj1_of_abstractClass x = new Obj1_of_abstractClass(9,0);
            x.display();

            Nullable n = new Nullable();
            n.display();
        }
    }
}

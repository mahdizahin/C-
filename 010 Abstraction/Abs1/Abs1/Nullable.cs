using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abs1
{
    public class Nullable
    {
        //int i = null; #404 giving error

        Nullable<int> i = null;

        //Shortand syntex
        int? x = null;
        double? y = 8;

        int ? xw = null;
       // int z = xw ?? 0;

       
       public void display()
        {
            if (i == null)
                Console.WriteLine("Value is null");
            else
                Console.WriteLine("Value is not Null");
                
        }
    }
}

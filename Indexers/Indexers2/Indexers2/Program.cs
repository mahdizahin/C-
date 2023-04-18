using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers2
{
    public class orus
    {
        public int[] roll = new int[4];

        public int this[int i]
        {
            get { return roll[i]; }
            set { roll[i] = value; }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            orus obj1 = new orus();
            obj1[0] = 78;
            obj1[1] = 70;

            for (int i = 0; i < 2; i++)
            {
                Console.Write("Value At index [" + i +"] : ");
                Console.WriteLine(obj1[i]);
            }
        }
    }
}

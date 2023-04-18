using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class sc
    {
        private int[] array = new int[10];

        public int this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }

        }

    }
    public class tow
    {
        public int[] num= new int[10];

        public int this[int x]
        {
            get { return num[x]; }
            set { num[x] = value; }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
                sc sco = new sc();
                sco[0] = 25;
                Console.WriteLine(sco[0]);

            tow objOftow= new tow();
            int kkx = objOftow[0] = 89;
            Console.WriteLine(kkx);
        }
    }
}

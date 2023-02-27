using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] arr = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter Number at index ["+i+"] : ");
                string input = Console.ReadLine();
                arr[i] = int.Parse(input);
            }
            Console.WriteLine("\n\nOutput is : " );
            for(int i = 0; i < 10; i++)
            {
                Console.Write(arr[i]+" ");
            }

        }
    }
}

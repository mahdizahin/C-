using System;
 
namespace Jagged_Array
{
      class Program
    {
        static void Main(string[] args )

        {
            string[] name = new string[3];
            name[0] = "AB";
            name[1] = "BC";
            name[2] = "E";

            string[][] Menu = new string[3][];
            Menu[0] = new string [2];
            Menu[1] = new string[2];
            Menu[2] = new string[1];

            Menu[0][0] = "A";
            Menu[0][1] = "B";

            Menu[1][0] = "C";
            Menu[1][1] = "D";

            Menu[2][0] = "E";

            int i, j;

            for(  i=0; i<Menu.Length; i++)
            {
                string [] elements = Menu[i];
                Console.WriteLine(name[i]+"\n------------\n");
                for (  j = 0; j < elements.Length; j++)
                {
                    Console.WriteLine(elements[j]);
                }
                Console.WriteLine();
            }

        }
    }
}

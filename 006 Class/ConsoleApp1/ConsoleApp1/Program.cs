using System;

namespace ConsoleApp1
{
        class dhong
    {
        int dhongID;
        string dhongName;

        

        public dhong(int dhongID, string dhongName)
        {
            this.dhongID = dhongID; 
            this.dhongName = dhongName;
        }

       public void display()
        {
            Console.WriteLine("Dhong ID : "+dhongID);
            Console.WriteLine("Dhong Name : "+dhongName);
        }
    }
      class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Dhong ID : ");
            int dhongId = int.Parse(Console.ReadLine());
            Console.Write("Enter Dhong Name : ");
            string dhongName = Console.ReadLine();

            dhong nekamo = new dhong(dhongId, dhongName);
            nekamo.display();
        }
    }
}

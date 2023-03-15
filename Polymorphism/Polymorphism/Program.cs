using System;
 

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, Zahin!\n Whats the newx");

            Gari c1 = new Gari(7,"pink");
            c1.display();
            c1.thikKora();

            Console.WriteLine("\n\n");

            GoruGari lalmia = new GoruGari(2,"Black","Mandhat Amoler");
            lalmia.display();
            lalmia.thikKora();

            Console.WriteLine("\n\n");

            Gari Mukkurgari = new GhuraGari(1, "Halka nal wong", "Teji Ghura");
            Mukkurgari.display();
            Mukkurgari.thikKora();

        }
    }
}

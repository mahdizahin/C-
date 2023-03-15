using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class GoruGari : Gari
    {
        private string region = "Indian";

        public string Model { get; set; }
        public GoruGari(int power, string color, string Model) : base(power, color)
        {
            this.Model = Model;
        }

        public void display()
        {
            base.display();
            Console.WriteLine(region);
        }

        public void thikKora()
        {
            Console.WriteLine(Model + " gari thik kora done");
        }

    }



    
}

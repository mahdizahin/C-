using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
     public class GhuraGari : Gari
    {

        private string jat="Turkish";

        public string model { get; set; }

        /*public GhuraGari(int power, string color;  string model ):base(power,color)
        {
            this.model = model;
        }
        */

        public string Model { get; set; }
        public GhuraGari(int power, string color, string Model) : base(power, color)
        {
            this.Model = Model;
        }

        public void display()
        {
            Console.WriteLine(jat);
        }

        public void thikKora()
        {
            Console.WriteLine(Model + " thik kora hoise");
        }




    }
}

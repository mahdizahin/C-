using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xinterface;

namespace classF
{
    internal class Class1 : Interface1  
    {
       public string color { get; set; }

        private bool isOpen=false;
        public bool Open()
        {
            isOpen = true;
            Console.WriteLine("Open for Writing");
            return isOpen;
        }
        public bool Close()
        {
            isOpen = false;
            Console.WriteLine("Closed for Writing");
            return isOpen;
        }
        public void write(string text)
        {
            if(isOpen)
            {
                Console.WriteLine("Class1" + text);
            }
        }
    }
}

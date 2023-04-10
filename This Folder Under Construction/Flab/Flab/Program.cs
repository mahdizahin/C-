using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flab
{


    class bus
    {
        string bName = "VOLVO";
        bus(string bName)
        {
            this.bName = bName;
        }
        void setbName(string bName)
        {
            this.bName = bName;
        }
        string getbName()
        {
            return bName;
        }

        void display()
        {
            Console.WriteLine(bName);
        }

    }
    class vehicle
    {

        string brand = "Ford";

        public  void honk()
        {
            Console.WriteLine("Tuut,tuut");
        }
    }
      class Car : vehicle, bus
    {
        int year;
        string model, color;

         Car( string model, string color, int year)
        {
          
            this.model = model;
            this.color = color;
            this.year = year;   

        }

        Car(string model, string color )
        {

            this.model = model;
            this.color = color;
            

        }
        void setmodel (string model){
           
            this.model = model;
        }
        string getmodel()
        {
            return model;

        }


        void setcolor(string color)
        {

            this.color = color;
        }
        string getcolor()
        {
            return color;

        }

        void setyear(int year)
        {

            this.year = year;
        }
        int getyear()
        {
            return year;

        }

        void display()
        {
            display();
            honk();
            Console.WriteLine("Model Name : "+ model);
            Console.WriteLine("Color Name : " + color);
            Console.WriteLine("Year : " + year);
             


        }

        



        static void Main(string[] args)

        {

           String mName;
           Console.WriteLine("Write Model Name : ");
           mName = Console.ReadLine();

            Car Ford = new Car(mName,"red",2014);
            Ford.display();

            Car Tesla = new Car(mName, "red");
           // Tesla.display();

            Tesla.honk();
             
        }
    }
}

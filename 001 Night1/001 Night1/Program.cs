using System; 

namespace _001_Night1
{
    class night
    {
        double time;
        string foodName;

        night(double time, string foodName)
        {
            this.time = time;
            this.foodName = foodName;
        }

        void setTiime(double time)
        {
            this.time = time;
        }
        double getTiime()
        {
            return this.time;
        }

        void setFoodname(string foodName)
        {
            this.foodName = foodName;
        }

        string getFoodName()
        {
            return this.foodName;
        }

        void display()
        {
            
            Console.WriteLine("Time : " + time+" AM ");
            Console.WriteLine("Food : " + foodName);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("I am not going to print that Cz I hate programming ");
            night n1 = new night (2.11,"Burger");
            n1.display();
        }
    }

}

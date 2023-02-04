using System;

namespace zahin
{
    class Cart
    {
        public int id;
        public string name;
        public int price;

       public Cart(int id, string name, int price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }

        void setId(int id) {
            this.id = id;
        }
        public int getId() 
        { return this.id;
        }

        void setName(string name) {
            this.name = name;
        }
        public string getName() {
            return this.name;
        }

        void setPrice(int price) {
            this.price = price;
        }
        public int getPrice() {
            return this.price;
        }

       public void display()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(price);
        }
       
    }
    class Program
    {
        static void Main(string[] args )
        {
            Console.WriteLine("I LOVE CODE AT NIGHT AND OTHER THING ALSO...");
            Cart mini = new Cart (23, "Min", 56);
            mini.display();
        }
    }
}
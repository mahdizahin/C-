using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBankBeta
{
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public Employee(int id, string name) {
            this.id = id;
            this.name = name;
        }

        public void display()
        {
            Console.WriteLine("EMP ID : "+id+"\nEMP NAME : "+name);
        }
    }
}

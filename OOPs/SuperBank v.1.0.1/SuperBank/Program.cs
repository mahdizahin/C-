using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperBank
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var account = new BankAccount("dotnet", 5000);

            account.show();

        }
    }
}

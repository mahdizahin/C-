using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace  xinterface
{
    public interface Interface1
    {
        //Interface members are abstract and public by default.
        //interfaces cannot be used to create objects

        string color { get; set; }
        bool Open();
        bool Close();
        void write(string text);
    }
}



namespace  victor
{
    public class ultrol
    {

    }
}

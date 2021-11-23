using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables 
            int numOfItems;
            //prompts user to enter amount of items
            Console.WriteLine("Please enter how many items you are ordering: ");
            //captures the type string input and converts it into an int
            numOfItems = Convert.ToInt32(Console.ReadLine());
            OnlineRetailer retail = new OnlineRetailer(numOfItems); //instantiate
            retail.ShippingCharge(retail.numOfItems); //call function
            Console.WriteLine("Shipping charge = R" + retail.shipCharge);
            Console.ReadKey();
        }
    }
}

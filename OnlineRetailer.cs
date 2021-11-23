using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4
{
    public class OnlineRetailer
    {
        //fields 
        public double firstItemRate;
        public int numOfItems;
        public double subItemsRate;
        public double shipCharge;
        //constructor
        /*Takes userInput as parameter and assigns it to numOfItems
         * Also assigns values to the rates
         */
        public OnlineRetailer(int userInput)
        {
            numOfItems = userInput;
            shipCharge = 0.00;
            firstItemRate = 10.95;
            subItemsRate = 2.95;
        }
        /*function to determine the shipping charge 
         */
        public double ShippingCharge(int numOfItems)
        {
            if (numOfItems == 1)
            {

                shipCharge = numOfItems * firstItemRate;
            }
            else
            {
                shipCharge = (1 * firstItemRate) + (numOfItems - 1) * subItemsRate;
            }
            return shipCharge;
        }
    }
}

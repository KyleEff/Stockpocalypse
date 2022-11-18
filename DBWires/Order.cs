using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    /*
     * This class is used to encapsulate the orders that the user places. Both buy and sell.
     * 
     * ID is the primary key.
     * Buy is a boolean that represents whether it is a buy order or not
     * Date_Time is the date and time of the order
     * Stock_Ticker is the symbol that represents the security on an exchange
     * Stock_Name is the name of the security
     * Price is the price of the stock
     * Quantity is the how many shares are on the order
     * Total is Quantity times price
     */

    public class Order
    {
        public int Order_ID { get; set; }
        public bool Buy { get; set; }
        public DateTime Date_Time { get; set; }
        public string Stock_Ticker { get; set; }
        public string Stock_Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double Total { get {
                return Price * Quantity;
        } }

        public string FullInfo
        {
            get
            {
                return
                    $"Order ID: {Order_ID}" + Environment.NewLine +
                    $"Date/Time: {Date_Time}" + Environment.NewLine +
                    $"Ticker: ${Stock_Ticker}" + Environment.NewLine +
                    $"Name: {Stock_Name}" + Environment.NewLine +
                    $"Price: {Price.ToString("C2")}" + Environment.NewLine +
                    $"Quantity: {Quantity}" + Environment.NewLine +
                    $"Total Price: { (Price * Quantity).ToString("C2") }";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    /*
     * Unfortunately, this class is part of a feature that will not make it into the first release.
     * This class is for separating regular market orders from orders that would be outside the
     *  regular market prices, being triggered with the market matched the order.
     *  
     * ID is the primary key.
     * Date_Time is the date and time of the order
     * Stock_Ticker is the symbol of the stock on the exchange
     * Stock_Name is the name of the security
     * Limit_Price is the price the user wants the order to execute at
     * Quantity is the amount of shares the user wishes to buy/sell
     */
    public class LimitOrder
    {
        public int Limit_Order_Id { get; set; }
        public DateTime Date_Time { get; set; }
        public string Stock_Ticker { get; set; }
        public string Stock_Name { get; set; }
        public float Limit_Price { get; set; }
        public int Quantity { get; set; }
    }
}

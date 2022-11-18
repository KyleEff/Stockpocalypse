using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    /*
     * This class is used to store data from the rows of the user's portfolio.
     * Id is the primary key
     * Stock_Ticker is the sticker for the stock
     * Stock_Name is the name of the stock
     * Quantity_Owned is how many securites the user owns
     * Dollar_Cost_Average is the average cost of all the securities owned by the user (total / quantity)
     * Total is the total cost of all the securites owned by the user (total * quantity)
     */

    public class Customer_Portfolio
    {
        
        public int Id { get; set; }
        public string Stock_Ticker { get; set; }
        public string Stock_Name { get; set; }
        public int Quantity_Owned { get; set; }
        public double Dollar_Cost_Average { get; set; }
        public double Total { get; set; }

        public string FullInfo { get {

                return $"Name: {Stock_Name}\tQuantity: {Quantity_Owned}\tDCA: ${Dollar_Cost_Average}\tTotal: ${Total}";
            }
        }
    }
}

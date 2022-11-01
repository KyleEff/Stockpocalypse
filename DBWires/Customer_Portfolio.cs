using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
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

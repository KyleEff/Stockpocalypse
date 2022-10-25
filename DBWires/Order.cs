using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    public class Order
    {
        public int Order_ID { get; set; }
        public bool Buy { get; set; }
        public DateTime Date_Time { get; set; }
        public string Stock_Ticker { get; set; }
        public string Stock_Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

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

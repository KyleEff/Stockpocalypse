using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
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

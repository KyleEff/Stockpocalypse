using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    public class Customer_Portfolio
    {
        public int Portfolio_Id { get; set; }
        public string Stock_Ticker { get; set; }
        public string Stock_Name { get; set; }
        public int Quantity_Owned { get; set; }
        public float Dollar_Cost_Average { get; set; }
        public float Total { get; set; }
    }
}

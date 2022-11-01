using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    // This class will be for entering and altering portfolio entries
    public class Entry
    {
        public string Stock_Ticker { get; set; }
        public string Stock_Name { get; set; }
        public int Quantity_Owned { get; set; }
        public double Dollar_Cost_Average { get; set; }
        public double Total { get; set; }
    }
}

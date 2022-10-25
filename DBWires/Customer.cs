using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.DBWires
{
    public class Customer
    {
        public int Customer_id { get; set; }
        public string Name { get; set; }

        public string FullInfo
        {
            // Returns a formatted string - READ ONLY
            get { return $"{Customer_id} : {Name}"; }
        }
    }
}

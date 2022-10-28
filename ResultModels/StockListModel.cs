﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.ResultModels
{
    public class StockListModel
    {
        public List<Stock> Data { get; set; }
        public string Status { get; set; }
    }

    public class Stock
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }
        public string Exchange { get; set; }
        public string Mic_code { get; set; }
        public string Country { get; set; }
        public string Type { get; set; }

        public string FullInfo { get {

                return
                    $"Ticker: ${ Symbol }" + Environment.NewLine + 
                    $"\t\tName: { Name }" + Environment.NewLine +
                    $"\t\t\t\tExchange: { Exchange }" + Environment.NewLine;
            }
        }
    }


}

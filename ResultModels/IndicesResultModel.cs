﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockForms.ResultModels
{
    public class Indices
    {
        public List<Index> data { get; set; }
        public string status { get; set; }
    }

    public class Index
    {
        public string symbol { get; set; }
        public string name { get; set; }
        public string country { get; set; }
        public string currency { get; set; }
    }

}

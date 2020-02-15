using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
     public class Chart
    {
        public StockPrice StockPrice { get; set; }
        public DateTime  FromDate { get; set; }
        public DateTime ToDate { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class StockPrice
    {
        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string StockExchange { get; set; }
        public float CurrentPrice { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }

    }
}

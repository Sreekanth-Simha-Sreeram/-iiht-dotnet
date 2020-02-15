using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class IPODetail
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string StockExchange { get; set; }
        public float PricePerShare { get; set; }
        public int TotalNoOfShares { get; set; }
        public DateTime OpenDateTime { get; set; }
        public string Remarks { get; set; }
    }
}

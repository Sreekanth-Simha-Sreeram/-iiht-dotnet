using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class StockExchange
    {
        public int Id { get; set; }
        public string Stockexchange { get; set; }
        public string ContactAdress { get; set; }
        public string Brief { get; set; }
        public string Remarks { get; set; }


    }
}

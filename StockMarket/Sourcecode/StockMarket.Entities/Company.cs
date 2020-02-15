using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.Entities
{
   public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string  CEO { get; set; }
        public string BoardDirectors { get; set; }
        public double TurnOver { get; set; }
        public string CompanyStockCode { get; set; }

    }
}

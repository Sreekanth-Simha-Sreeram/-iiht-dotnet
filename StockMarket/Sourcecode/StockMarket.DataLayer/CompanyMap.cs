using FluentNHibernate.Mapping;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.DataLayer
{
    public class CompanyMap : ClassMap<Company>
    {
        public CompanyMap()
        {
            Id(x => x.Id);

            Map(x => x.CompanyName);
            Map(x => x.CEO);
            Map(x => x.TurnOver);
            Map(x => x.CompanyStockCode);
            Table("Company");


        }
    }
}

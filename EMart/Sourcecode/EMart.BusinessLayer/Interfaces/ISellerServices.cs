using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Interfaces
{
    public interface ISellerServices
    {
        void AddStock(Product product, Seller seller, int Stock);

        List<IStock> ViewSalesInventory(int SellerId);
    }
}

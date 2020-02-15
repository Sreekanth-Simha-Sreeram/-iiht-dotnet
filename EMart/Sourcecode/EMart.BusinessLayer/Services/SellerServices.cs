using EMart.BusinessLayer.Ineterfaces;
using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Services
{
    public class SellerServices : ISellerServices
    {
        public ISellerServices _Isellerservices;
        public SellerServices(ISellerServices ISellerServices)
        {
            _Isellerservices = ISellerServices;
        }
        public void AddStock(Product product, Seller seller, int Stock)
        {

        }

        public List<IStock> ViewSalesInventory(int SellerId)
        {
            List<IStock> Istock = new List<IStock>();
            return Istock;
        }
    }
}

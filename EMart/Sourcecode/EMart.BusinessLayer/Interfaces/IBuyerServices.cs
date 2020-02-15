using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMart.BusinessLayer.Interfaces
{
    public interface IBuyerServices
    {
        List<Product> SearchProduct(string ProductName, string CategoryName, string SubCategoryName);
        bool AddToCart(List<Product> products, int BuyerId);
        List<Product> FilterProduct(string ProductName, string CategoryName, int Price, string Manufacturer);
        bool DeleteFromCart(List<Product> products, int BuyerId);
        List<Product> ViewCart(List<Product> products, int BuyerId);
        List<Product> PlaceOrder(List<Product> product, Buyer buyer);
    }
}


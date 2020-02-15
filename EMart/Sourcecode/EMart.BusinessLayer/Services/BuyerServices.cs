using EMart.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMart.DataLayer;
using NHibernate;
using EMart.BusinessLayer.Interfaces;

namespace EMart.BusinessLayer.Services
{
    public class BuyerServices : IBuyerServices
    {       

        public List<Product> SearchProduct(string productName, string categoryName, string subCategoryName)
        {
            List<Product> products = new List<Product>();
            return products;
        }

        public bool AddToCart(List<Product> products, int buyerId)
        {

            return true;
        }


        public List<Product> FilterProduct(string productName, string categoryName, int price, string manufacturer)
        {
            List<Product> products = new List<Product>();
            return products;
        }

        public List<Product> PlaceOrder(List<Product> product, Buyer buyer)
        {
            List<Product> products = new List<Product>();
            return products;
        }
        public bool DeleteFromCart(int buyerId)
        {
            return true;
            
        }

        public List<Product> ViewCart(int buyerId)
        {
            List<Product> products = new List<Product>();
            return products;
        }

    }
}

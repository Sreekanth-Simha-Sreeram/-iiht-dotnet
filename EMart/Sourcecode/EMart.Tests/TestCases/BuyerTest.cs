using EMart.Entities;
using EMart.Tests.Exceptions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EMart.BusinessLayer.Services;
using System.Web.Mvc;


namespace EMart.Tests
{


    [TestFixture]
    class BuyerTest
    {

        [SetUp]
        public void Init()
        {

        }

        [Test]
        public void TestAddToCart()
        {
            //Arrange - Create some test products
            Product Product = new Product()
            {
                Id = 1,
                ProductName = "Apple Mobile",
                SubCategoryId = "1",
                Price = 2000,
                BuyerId=1,
                 CategoryId = "1"
                
            };

            Buyer buyer = new Buyer();
            buyer.Id = 1;


            List<Product> itemlist = new List<Product>();
            itemlist.Add(Product);
           

            BuyerServices buyerservice = new BuyerServices();
           
                        
            //Act

            var result = buyerservice.AddToCart(itemlist, buyer.Id);

            //Assert           

            Assert.Contains(true, itemlist);
            
        }

        //[ExpectedException(typeof(EMartExecetion))]
        public void TestExceptionSearchItems()
        {
            //Arrange
            string ProductName = "tv";
            string CategoryName = "Electrical";
            string Subcategory = "sub";

            //Action
            BuyerServices buyerService = new BuyerServices();

            //Assert
            var ex = Assert.Throws<ProductNotFoundException>(() => buyerService.SearchProduct(ProductName, CategoryName, Subcategory));
            Assert.AreEqual("Item is Not found in stock", ex.Message);


        }

    }
}
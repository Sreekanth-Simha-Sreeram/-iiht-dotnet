using NUnit.Framework;
using StockMarket.BusinessLayer.Services;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Tests.TestCases
{
    [TestFixture]
    class UserTest
    {

        [Test]
        public void TestForSearchCompany()
        {
            //Arrange
            Company company = new Company() { Id = 11, CompanyName = "MS" };
            UserServices userServices = new UserServices();

            //Action
            Company companydetails = userServices.SearchCompany(company.CompanyName);

            //Assert
            Assert.AreEqual(company, companydetails);
        }

    }
}


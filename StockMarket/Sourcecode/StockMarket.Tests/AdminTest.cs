using NUnit.Framework;

using StockMarket.BusinessLayer.Services;
using StockMarket.DataLayer;
using StockMarket.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Tests.TestCases
{
    [TestFixture]
   public class AdminTest
    {

        // bool AddCompany(Company company);
        [Test]
        public void TestForAddCompany()
        {
            ////Arrange
            //var clients = session.QueryOver<Clients>().Where(x => x.Name == "Foobar").List();
            //var company = session.QueryOver<Company>().where(x => x.Name == "").List();
         Company company = new Company();
            AdminServices adminService = new AdminServices();

            //var session = NHibernateHelper.OpenSession();
            //{
            //    using (var transaction = session.BeginTransaction())
            //    {

            //        var company = new Company
            //        {
            //            Id = 1,
            //            CompanyName = "Patil",
            //            CEO = "Abhi",
            //            BoardDirectors = "aa",
            //            TurnOver = 11,
            //            CompanyStockCode = "12"

            //        };
                    //session.Save(company);
                    //transaction.Commit();
              //  }
          //  }
        
            //Action
            var IsAdded = adminService.AddCompany(company);

            //Assert
            Assert.AreEqual(true, IsAdded);

        }

        // bool DeleteCompany(int Id);
        [Test]
        public void TestForDeleteCompany()
        {
            //Arrange
            Company company = new Company();
            var id = company.Id;
            AdminServices adminService = new AdminServices();


            //Action
            var isDeleted = adminService.DeleteCompany(id);

            //Assert
            Assert.AreEqual(true, isDeleted);
        }
      [Test]
        public void EditCompany()
        {
            //Company EditCompany(int Id)
            Company company = new Company();
            var id = company.Id;
            AdminServices adminService = new AdminServices();

            //Action
            Company editedcompany = adminService.EditCompany(id);
            Company editsCompany = adminService.GetCompanyById(id);


            //Assert
            Assert.AreEqual(editsCompany, editedcompany);


        }
        [Test]
        public void EditIPODetails()
        {
            //Company EditCompany(int Id)
            IPODetail ipoDetails = new IPODetail() { Id = 11, CompanyName = "MS" };
            var id = ipoDetails.Id;


            AdminServices adminService = new AdminServices();

            //Action
            IPODetail editedIPODetails = adminService.UpdateIPODetail(id);
            IPODetail editedIpoFromDb = adminService.GetIPOById(id);

            //Assert
            Assert.AreEqual(editedIpoFromDb, editedIPODetails);


        }

    }
}
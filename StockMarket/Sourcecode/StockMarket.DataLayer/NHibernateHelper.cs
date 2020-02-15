using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace StockMarket.DataLayer
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;

        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null)
                    InitializeSessionFactory();
                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
            .Database(MsSqlConfiguration.MsSql2012
           .ConnectionString(@"Data Source=DEV7-PC\MSSQLSERVERNEW;Initial Catalog=StockMarket;User ID=sa;Password=Pass1@1234;persist security info=True"))
          .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
           .BuildSessionFactory();

        }

        public static NHibernate.ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}


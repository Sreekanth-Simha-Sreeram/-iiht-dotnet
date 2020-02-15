using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System.Reflection;

namespace EMart.DataLayer
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
            .Database(MySQLConfiguration.Standard
           .ConnectionString(@"Data Source=localhost;Initial Catalog=emart;User ID=root;Password=root;persist security info=True"))
          .Mappings(m => m.FluentMappings.AddFromAssembly(Assembly.GetExecutingAssembly()))
           .BuildSessionFactory();

        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}


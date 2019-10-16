using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Mapping;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace Nhibernate
{
    public class NHibernateHelper
    {
        private static ISessionFactory _sessionFactory;
        private static ISessionFactory SessionFactory
        {
            get
            {
                if (_sessionFactory == null) InitializeSessionFactory();

                return _sessionFactory;
            }
        }

        private static void InitializeSessionFactory()
        {
            _sessionFactory = Fluently.Configure()
                  .Database(MsSqlConfiguration.MsSql2012
                  .ConnectionString(
                      @"Server=DESKTOP-92AAOJE;Database=testhibernate;Trusted_Connection=true;")
                  .ShowSql()
                  )
                  .Mappings(m =>
                  m.FluentMappings
                  .AddFromAssemblyOf<Book>()
    
                  )
                  .ExposeConfiguration(cfg => new SchemaUpdate(cfg)
                  .Execute(false, true))
                  .BuildSessionFactory();
        }

        public static ISession OpenSession()
        {
            return SessionFactory.OpenSession();
        }
    }
}
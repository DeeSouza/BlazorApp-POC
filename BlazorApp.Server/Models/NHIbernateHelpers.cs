using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;

namespace BlazorApp.Server.Models
{
    public class NHibernateHelpers
    {
        public static ISessionFactory MySessionFactory { get; private set; }

        public static ISession OpenSession()
        {
            if (MySessionFactory == null)
                MySessionFactory = CreateSectionFactory();

            return MySessionFactory.OpenSession();
        }

        public static ISessionFactory CreateSectionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012
                .ConnectionString(
                    @"
                    Data Source=GA-DE-NB-DV-22;
                    Initial Catalog=Home;
                    Integrated Security=True").ShowSql()
                )
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Users>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg)
                .Create(false, false))
                .BuildSessionFactory();
        }
    }
}

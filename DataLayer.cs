using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Farmacy.Mapiranja;

namespace Farmacy
{
    class DataLayer
    {
        private static ISessionFactory _factory = null;
        private static object objLock = new object();

        public static ISession GetSession()
        {
            //ukoliko session factory nije kreiran
            if (_factory == null)
            {
                lock (objLock)
                {
                    if (_factory == null)
                        _factory = CreateSessionFactory();
                }
            }

            return _factory.OpenSession();
        }

        private static ISessionFactory CreateSessionFactory()
        {
            try
            {
                var cfg = OracleManagedDataClientConfiguration.Oracle10
                    .Driver<NHibernate.Driver.OracleManagedDataClientDriver>()
                    .ShowSql()
                    .ConnectionString(c =>
                    c.Is("Data Source=gislab-oracle.elfak.ni.ac.rs:1521/SBP_PDB;User Id=S19286;Password=S19286"));

                return Fluently.Configure()
                .Database(cfg)
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<ApotekaMapiranja>())
                .ExposeConfiguration(cfg =>
                {
                    Console.WriteLine("NH dialect: " + (cfg.Properties.TryGetValue("dialect", out var d) ? d : "<none>"));
                    Console.WriteLine("NH driver: " + (cfg.Properties.TryGetValue("connection.driver_class", out var dr) ? dr : "<none>"));
                    Console.WriteLine("Mappings: " + cfg.ClassMappings.Count);
                    foreach (var cm in cfg.ClassMappings)
                        Console.WriteLine(" - " + cm.EntityName + " -> " + cm.Table.Name);
                })
                .BuildSessionFactory();
            }
            catch (FluentNHibernate.Cfg.FluentConfigurationException fex)
            {
                var sb = new StringBuilder();
                sb.AppendLine("FluentConfigurationException:");
                sb.AppendLine("PotentialReasons:");
                foreach (var r in fex.PotentialReasons) sb.AppendLine(" - " + r);

                Exception ie = fex;
                int depth = 0;
                while (ie != null)
                {
                    sb.AppendLine($"[{depth}] {ie.GetType().Name}: {ie.Message}");
                    ie = ie.InnerException;
                    depth++;
                }

                System.Windows.Forms.MessageBox.Show(sb.ToString(), "NH init error (details)");
                throw;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString(), "NH init error (raw)");
                throw;
            }
        }

    }
}

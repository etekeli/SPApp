using System;
using System.IO;
using System.Reflection;
using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace EnqueteSPA.Entities
{
    class Database
    {

        static String DbFile = "C:/enqueteSPA.db";
        private static Database instance;
        private ISessionFactory sessionFactory;

        public static Database getInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public ISessionFactory getSessionFactory()
        {
            return sessionFactory;
        }

        private Database()
        {
            
            var nhConfig = new Configuration()
                .DataBaseIntegration(db => { db.ConnectionStringName = DbFile; })
                .AddDirectory(new System.IO.DirectoryInfo(System.IO.Path.Combine("Mappings")))
                .AddAssembly(Assembly.GetExecutingAssembly())
                .Configure();

            BuildSchema(nhConfig);
            //new SchemaExport(nhConfig).Execute(true, true, false);

            this.sessionFactory = nhConfig.BuildSessionFactory();
        }

        private static void BuildSchema(Configuration config)
        {

            if (!File.Exists(DbFile))
            {
                new SchemaExport(config)
                  .Create(false, true);
            }
            else
            {
                FileInfo info = new FileInfo(DbFile);
                long size = info.Length;
                if (size == 0)
                {
                    new SchemaExport(config).Create(false, true);
                }
            }
        }
    }
}

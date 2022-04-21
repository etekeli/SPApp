using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Text;

namespace EnqueteSPA.Entities
{
    //    Personne(id, Nom, Prénom, Adresse, ..., idStatut)

    public class Personne
    {
        public virtual int ID { get; set; }
        public virtual string Name { get; set; }
        public virtual string phone { get; set; }
        public virtual string location { get; set; }
        public virtual Login login { get; set; }


        public override string ToString()
        {
            return Name + " " + phone + " " + location + " " + login;
        }

        public static List<Personne> getAll()
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            List<Personne> a = new List<Personne>(session.CreateCriteria<Personne>()
                //                .Fetch(SelectMode.Fetch, "utilisateur")
                .List<Personne>());

            transaction.Commit();
            session.Close();

            return a;
        }

        internal static List<Personne> getFiltered(string filter)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            List<Personne> a;
            if (filter != "")
            {
                string f = "from Personne p where p.Name like '%" + filter + "%' or p.phone like '%" + filter + "%' or p.location like '%" + filter + "%'";
                a = new List<Personne>(session.CreateQuery(f).List<Personne>());
            }
            else
                a = new List<Personne>(session.CreateCriteria<Personne>().List<Personne>());


            transaction.Commit();
            session.Close();

            return a;
        }

        public static Personne getById()
        {
            return null;
        }


        public static void SaveOrUpdate(Personne p)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(p);
            transaction.Commit();
            session.Close();
        }
    }



}

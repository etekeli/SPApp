using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace EnqueteSPA.Entities
{
    // Enquete(id, (département, année, mois, numéro), plaignant, infracteur, comments, état)
    public class Enquete
    {
        public static int RENDUE = 10;

        public virtual int ID { get; set; }
        public virtual int departement { get; set; }
        public virtual int annee { get; set; }
        public virtual int mois { get; set; }


        public virtual Personne enqueteur { get; set; }
        public virtual Personne plaignant { get; set; }
        public virtual Personne infracteur { get; set; }
        public virtual String subject { get; set; }
        public virtual String commentaires { get; set; }
        public virtual int etat { get; set; }
        public virtual int numeroGenere { get; set; }
        public virtual String numeroDossier { get { return departement + "/" + annee + "/" + mois + "/" + numeroGenere; } }


        public static List<Enquete> getAll()
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            List<Enquete> a = new List<Enquete>(session.CreateCriteria<Enquete>()
                .List<Enquete>());

            transaction.Commit();
            session.Close();

            return a;
        }

        public static List<Enquete> getFiltered(string filter)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();


            //            string str = "select e FROM Enquete e WHERE e.enqueteur.LastName LIKE %" + filter + "% OR e.enqueteur.Name LIKE % " + filter + " % ";
            //            System.Diagnostics.Debug.WriteLine(str);
            //            List<Enquete> a = new List<Enquete>(session.CreateCriteria<Enquete>().Add(Restrictions.Like("enqueteur.LastName", "%" + filter + "%")).List<Enquete>());//.Add(Expression.Like("enqueteur.LastName", filter)).List<Enquete>());
            //            List<Enquete> a = new List<Enquete>(session.CreateCriteria<Enquete>().Add(Restrictions.Like("enqueteur.LastName", "%" + filter + "%")).List<Enquete>());//.Add(Expression.Like("enqueteur.LastName", filter)).List<Enquete>());

            //            var a = new List<Enquete>(session.CreateCriteria<Enquete>().CreateAlias("enqueteur", "e").Add(Restrictions.Eq("e.elements", filter)).List<Enquete>());
            //List<Enquete> a = new List<Enquete>(session.QueryOver<Enquete>()
            //    .WhereRestrictionOn(e => e.enqueteur).IsInsensitiveLike("%" + filter + "%")
            //    .List<Enquete>());
            List<Enquete> a;
            if (filter != "")
            {   

                string f = "from Enquete e where e.commentaires like '%" + filter + "%' or e.subject like '%" + filter + "%' or CONCAT(e.departement,'/', e.annee,'/',e.mois, '/' , e.numeroGenere) like '%" + filter + "%' ORDER BY e.etat, e.departement, e.annee ASC";
              
                a =  new List<Enquete>(session.CreateQuery(f).List<Enquete>());

                /*a = new List<Enquete>(session.QueryOver<Enquete>()
                    .Where(e => e.enqueteur != null).Where(e => e.plaignant.FirstName == filter)
                    .List<Enquete>());
                a = new List<Enquete>(
                    session.CreateCriteria<Enquete>()
                    .Add(Restrictions.InsensitiveLike("", "%" + filter + "%"))
                    .Add(Restrictions.Or(Restrictions.Or(Restrictions.Eq("mois", intfilter), Restrictions.Eq("departement", intfilter)), Restrictions.Eq("moisGenere", intfilter)))
                    .CreateCriteria<>("infracteur", "infr", JoinType.InnerJoin)
                    .Add(Restrictions.Or(Restrictions.InsensitiveLike("Name", "%"+filter+"%"), Restrictions.Or(Restrictions.InsensitiveLike("phone", "%" + filter + "%"), Restrictions.InsensitiveLike("location", "%" + filter + "%"))))
//                .CreateCriteria("plaignant", "plai", JoinType.InnerJoin)
//                .Add(Restrictions.Or(Restrictions.InsensitiveLike("Name", filter), Restrictions.Or(Restrictions.InsensitiveLike("phone", filter), Restrictions.InsensitiveLike("location", filter))))
                */
            }
            else
                a = new List<Enquete>(session.CreateCriteria<Enquete>().List<Enquete>());
            
            
            transaction.Commit();
            session.Close();

            return a;

        }

        internal static void Update(Enquete enquete)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(enquete);
            transaction.Commit();
            session.Close();
        }

        public static Enquete getLastByMonthYear(int month, int year)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            Enquete e = session.CreateCriteria<Enquete>()
                .Add(Expression.Eq("mois", month))
                .Add(Expression.Eq("annee", year))
                .AddOrder(Order.Desc("ID"))
                .SetMaxResults(1)
                .UniqueResult<Enquete>();


            transaction.Commit();
            session.Close();

            return e;
        }

        public static void SaveOrUpdate(Enquete enq)
        {

            Enquete temp = getLastByMonthYear(enq.mois, enq.annee);
            if (temp == null)
                enq.numeroGenere = 0;
            else
                enq.numeroGenere = temp.numeroGenere + 1;

            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(enq);
            transaction.Commit();
            session.Close();
        }
    }

}

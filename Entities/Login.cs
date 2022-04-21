using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace EnqueteSPA.Entities
{
    public class Login
    {
        public virtual int ID { get; set; }
        public virtual Personne utilisateur { get; set; }
        public virtual String login { get; set; }
        public virtual String password { get; set; }

        /**
         * @return Objet Login de l'utilisateur si identifiant et mot de passe valides
         *
         */
        public static Login IsValid(String login, String password)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            Login res = session.CreateCriteria<Login>()
                .Add(Expression.Like("login", login))
//                .Fetch(SelectMode.Fetch, "utilisateur")
                .UniqueResult<Login>();

            transaction.Commit();

            if (res != null && res.password == password)
                return res;
            else
                return null;
        }

        internal static List<Login> getFiltered(string filter)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            List<Login> a;
            if (filter != "")
            {

                string f = "from Login l where l.login like '%" + filter + "%' or login.utilisateur.Name like '%" + filter + "%' or login.utilisateur.phone like '%" + filter + "%' or login.utilisateur.location like '%" + filter + "%'";

                a = new List<Login>(session.CreateQuery(f).List<Login>());

            }
            else
                a = new List<Login>(session.CreateCriteria<Login>().List<Login>());


            transaction.Commit();
            session.Close();

            return a;
        }

        internal static void SaveOrUpdate(Login l)
        {
                using ISession session = Database.getInstance().getSessionFactory().OpenSession();
                using ITransaction transaction = session.BeginTransaction();
                session.SaveOrUpdate(l);
                transaction.Commit();
                session.Close();
        }

        public static bool exist(String login)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            Login a = (Login)session.CreateCriteria<Login>()
                .Add(Expression.Eq("login", login))
                .UniqueResult();

            transaction.Commit();
            session.Close();

            return (a != null);
        }

        public static List<Login> getAll()
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            List<Login> a = new List<Login>(session.CreateCriteria<Login>()
                //                .Fetch(SelectMode.Fetch, "utilisateur")
                .List<Login>());

            transaction.Commit();
            session.Close();

            return a;
        }

        public static void delete(Login l)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            session.Delete(l);

            transaction.Commit();
            session.Close();

        }
    }
}

using NHibernate;
using NHibernate.Criterion;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EnqueteSPA.Entities
{
    // Enquete_pj(idEnquete, file_name, date_ajout)
    public class Enquete_PJ
    {
        public virtual int ID { get; set; }
        public virtual String file { get; set; }
        public virtual String dateAjout { get; set; }
        public virtual Enquete enquete { get; set; }

        public static void SaveOrUpdate(Enquete_PJ enqPJ)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(enqPJ);
            transaction.Commit();
            session.Close();
        }

        public static List<Enquete_PJ> getByEnquete(Enquete enq){
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            List<Enquete_PJ> res = (List<Enquete_PJ>)session.CreateCriteria<Enquete_PJ>()
                .Add(Expression.Eq("enquete", enq))
                .List<Enquete_PJ>();

            transaction.Commit();
            session.Close();
            return res;
        }


        public static Enquete_PJ getById(int v)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();

            Enquete_PJ res = session.Get<Enquete_PJ>(v);

            transaction.Commit();
            session.Close();
            return res;
        }

        public static void upload(Enquete_PJ epj, string path)
        {
            string a = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            string fullpath = Path.GetFullPath(Path.Combine(a+"\\PJ\\" + epj.enquete.ID+"\\"));
            Directory.CreateDirectory(fullpath);
            string tempname = Path.GetFileName(path);
            if (File.Exists(fullpath + tempname)) {
                int cpt = 1;
                while (File.Exists(fullpath + cpt + tempname))
                    cpt++;
                tempname = cpt + tempname;
            }
            epj.file = tempname;
            File.Copy(path, fullpath + epj.file);

        }

        public static void download(Enquete_PJ epj)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            string extension = Path.GetExtension(epj.file);
            sfd.Filter = extension + " file|*" + extension;
            sfd.FileName = epj.file;
            sfd.DefaultExt = extension;
            sfd.Title = "Choisissez où sauvegarder votre fichier";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string a = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                string fullpath = Path.GetFullPath(Path.Combine(a + "\\PJ\\" + epj.enquete.ID + "\\"+epj.file));
                File.Copy(fullpath, sfd.FileName);

            }

            }

    }
}

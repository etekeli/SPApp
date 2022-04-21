using System;
using System.Collections.Generic;
using System.Windows.Forms;
using EnqueteSPA.Entities;
using NHibernate;

namespace EnqueteSPA
{
    public partial class Login : Form
    {
        public bool Authenticated = false;
        public Entities.Login login = null;
        public Login()
        {
            InitializeComponent();
        }

        /**
         * Gère le comportement du click sur le bouton Se Connecter 
         */
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            this.login = Entities.Login.IsValid(this.textLogin.Text, this.textPassword.Text);
            if (this.login != null)
            {
                this.Close();
                this.Authenticated = true;
            }
            else
                MessageBox.Show("Identifiant ou mot de passe invalide");
        }


        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                this.buttonConnect_Click(sender, e);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        internal static void SaveOrUpdate(Entities.Login l)
        {
            using ISession session = Database.getInstance().getSessionFactory().OpenSession();
            using ITransaction transaction = session.BeginTransaction();
            session.SaveOrUpdate(l);
            transaction.Commit();
            session.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnter(object sender, EventArgs e)
        {
            this.buttonConnect.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.buttonConnect.BackColor = System.Drawing.Color.White;
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            this.buttonConnect.ForeColor = System.Drawing.Color.White;
            this.buttonConnect.BackColor = System.Drawing.Color.DarkSlateGray;
        }

        private void buttonHover(object sender, EventArgs e)
        {

        }
    }
}

using EnqueteSPA.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnqueteSPA.Forms
{
    public partial class SalariesView : Form
    {
        private MainApp mainApp = null;
        private Entities.Login l;
        private string oldLogin;

        public SalariesView(MainApp mainApp, Entities.Login salarieChoisi)
        {
            InitializeComponent();
            this.l = salarieChoisi;
            this.mainApp = mainApp;
            this.reload();
        }

        private void reload()
        {
            this.labelPersonnee.Text = this.l.utilisateur.Name;
            this.textBoxLogin.Text = this.l.login;
            this.textBoxPassword.Text = this.l.password;
            this.oldLogin = this.l.login;
        }

        private void buttonPersonne_Click(object sender, EventArgs e)
        {
            var choixPersonnePopup = new PersonnesList(null);
            choixPersonnePopup.setTitle("Choisissez une personne").ShowDialog(this);

            Personne temp = choixPersonnePopup.getChoice();
            this.l.ID = temp.ID;

//            this.l.utilisateur = choixPersonnePopup.getChoice();
            Entities.Login.SaveOrUpdate(this.l);

            success("Personne mise à jour avec succès !");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (this.oldLogin != textBoxLogin.Text && EnqueteSPA.Entities.Login.exist(textBoxLogin.Text))
                this.error("Identifiant déjà existant");
            else if (textBoxPassword.Text == "")
                this.error("Veuillez saisir un mot de passe");
            else
            {
                l.login = textBoxLogin.Text;
                l.password = textBoxPassword.Text;
                Login.SaveOrUpdate(this.l);
                this.success("Salarié mis à jour avec succès");
            }

        }

        private void error(string v)
        {
            this.labelMessage.ForeColor = Color.Red;
            this.labelMessage.Text = v;
        }
        private void success(string v)
        {
            this.labelMessage.ForeColor = Color.Cyan;
            this.labelMessage.Text = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entities.Login.delete(this.l);

            if (this.mainApp != null)
                this.mainApp.OpenForm(new SalariesList(this.mainApp));

            this.Close();
        }
    }
}

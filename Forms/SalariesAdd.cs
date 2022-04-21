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
    public partial class SalariesAdd : Form
    {
        private EnqueteSPA.Entities.Login l;
        public SalariesAdd()
        {
            InitializeComponent();
            this.l = new Entities.Login();
        }

        private void buttonPersonne_Click(object sender, EventArgs e)
        {
            var choixPersonnePopup = new PersonnesList(null);
            choixPersonnePopup.setTitle("Choisissez une personne");
            choixPersonnePopup.ShowDialog(this);

            l.utilisateur = choixPersonnePopup.getChoice();
            this.labelPersonnee.Text = l.utilisateur.Name;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (EnqueteSPA.Entities.Login.exist(textBoxLogin.Text))
                this.error("Identifiant déjà existant");
            else if (textBoxPassword.Text == "")
                this.error("Veuillez saisir un mot de passe");
            else
            {
                l.login = textBoxLogin.Text;
                l.password = textBoxPassword.Text;
                Login.SaveOrUpdate(this.l);
                this.success("Salarié ajouté avec succès");
            }
            this.clear();
        }

        private void clear()
        {
            this.l = new Entities.Login();
            this.textBoxLogin.Text = "";
            this.textBoxPassword.Text = "";
            this.labelPersonnee.Text = "";
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
    }
}

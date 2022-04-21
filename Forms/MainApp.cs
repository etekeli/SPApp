using EnqueteSPA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnqueteSPA
{
    public partial class MainApp : Form
    {
        private Entities.Login login = null;
        private Form activeForm = null;

        public MainApp(Entities.Login login)
        {
            this.login = login;
            InitializeComponent();
            InitDesign();
            if (this.login.login != "enes")
                buttonSalaries.Visible = false;
        }

        /**
         * initialisation du design de l'app
         * */
        private void InitDesign()
        {
            panelEnqueteSubmenu.Visible = false;
            labelUser.Text = login.login;
        }

        /**
         * Cache ou montre le panel
         */
        private void TogglePanel(Panel panel)
        {
            panel.Visible = !panel.Visible;
        }

        /**
        * Gère le comportement du click sur le bouton Home
        */
        private void buttonHome_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
        }

        /**
         * Gère le comportement du click sur le bouton Dashboard
         */
        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            PersonneView pv = new PersonneView(this.login.utilisateur);
            pv.setTitle("Dashboard");
            OpenForm(pv);
        }

        /**
         * Gère le comportement du click sur le bouton Enquête 
         */
        private void buttonEnquete_Click(object sender, EventArgs e)
        {
            TogglePanel(panelEnqueteSubmenu);
        }

        /**
         * Gère le comportement du click sur le bouton Voir les enquêtes
         */
        private void buttonVoirEnquetes_Click(object sender, EventArgs e)
        {
            OpenForm(new EnquetesList(this));
        }

        /**
         * Gère le comportement du click sur le bouton Ajouter enquête 
         */
        private void buttonAjouterEnquete_Click(object sender, EventArgs e)
        {
            OpenForm(new EnqueteAdd());
        }

        public void OpenForm(Form form)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(form);
            panelContainer.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void buttonPersonne_Click(object sender, EventArgs e)
        {
            TogglePanel(panelPersonneSubmenu);

        }

        private void buttonVoirPersonnes_Click(object sender, EventArgs e)
        {
            OpenForm(new PersonnesList(this));
        }

        private void buttonAjouterPersonne_Click(object sender, EventArgs e)
        {

            OpenForm(new PersonneAdd());
        }

        private void buttonSalaries_Click(object sender, EventArgs e)
        {
            TogglePanel(panelSalaries);
        }

        private void buttonSalariesView_Click(object sender, EventArgs e)
        {
            OpenForm(new SalariesList(this));
        }

        private void buttonSalariesAdd_Click(object sender, EventArgs e)
        {
            OpenForm(new SalariesAdd());
        }
    }
}

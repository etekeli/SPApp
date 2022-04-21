using EnqueteSPA.Entities;
using EnqueteSPA.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace EnqueteSPA
{
    public partial class EnqueteAdd : Form
    {
        private Personne Enqueteur = null;
        private Personne Plaignant = null;
        private Personne Infracteur = null;

        public EnqueteAdd()
        {
            InitializeComponent();
            resetForm();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Enquete enq = new Enquete();
            enq.departement = Int32.Parse(textBoxDepartement.Text);
            enq.commentaires = richTextBoxCommentaires.Text;
            enq.subject = richTextBoxSubject.Text;
            enq.enqueteur = (Personne) buttonChoixEnqueteur.Tag;
            enq.plaignant = (Personne) buttonChoixPlaignant.Tag;
            enq.infracteur = (Personne) buttonChoixInfracteur.Tag;
            enq.annee = dateTimePickerDate.Value.Year;
            enq.mois = dateTimePickerDate.Value.Month;
            enq.etat = Convert.ToInt32(numericUpDownImportance.Value);
            Enquete.SaveOrUpdate(enq);
            CopyFilesToDB(textBoxChoixPJ.Text, enq);

            successMessage();
            resetForm();

        }

        private void CopyFilesToDB(string pathes, Enquete enq)
        {
            pathes = pathes.Replace("\n", "").Replace("\r", "");
            string[] pathesArray = pathes.Split(";");
            for (int i = 0; i < pathesArray.Length-1; i++)
            {
                Enquete_PJ enqPJ = new Enquete_PJ();
                enqPJ.dateAjout = DateTime.Now.ToString();
                enqPJ.enquete = enq;

                Enquete_PJ.upload(enqPJ, pathesArray[i]);
                Enquete_PJ.SaveOrUpdate(enqPJ);
            }
        }

        private void resetForm()
        {
            this.textBoxDepartement.Text = "";
            this.richTextBoxCommentaires.Text = "";
            this.dateTimePickerDate.Value = DateTime.Today;
            this.labelEnqueteurChoisi.Text = "";
            this.labelPlaignantChoisi.Text = "";
            this.labelInfracteurChoisi.Text = "";
            this.textBoxChoixPJ.Text = "";
        }

        private void errorMessage(string msg)
        {
            this.ResultMessage.ForeColor = Color.Red;
            this.ResultMessage.Text = msg;
        }

        private void successMessage()
        {
            this.ResultMessage.ForeColor = Color.Blue;
            this.ResultMessage.Text = "Ajout effectué avec succès";
        }

        private void textBoxDepartement_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void buttonChoixPersonne_Click(object sender, EventArgs e)
        {
            var choixPersonnePopup = new PersonnesList(null);
            choixPersonnePopup.setTitle("Choisissez une personne");
            choixPersonnePopup.ShowDialog(this);
            Personne choix = choixPersonnePopup.getChoice();
            Button b = (Button)sender;
            b.Tag = choix;
            updatePersonnes();
        }

        private void updatePersonnes()
        {
            Enqueteur = (Personne)buttonChoixEnqueteur.Tag;
            Plaignant = (Personne)buttonChoixPlaignant.Tag;
            Infracteur = (Personne)buttonChoixInfracteur.Tag;

            if(Enqueteur != null)
                labelEnqueteurChoisi.Text = Enqueteur.Name;
            if(Plaignant != null)
                labelPlaignantChoisi.Text = Plaignant.Name ;
            if(Infracteur != null)
                labelInfracteurChoisi.Text = Infracteur.Name;
        }

        private void buttonPJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisir les pièces jointes";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                if(!this.textBoxChoixPJ.Text.Contains(ofd.FileName))
                    this.textBoxChoixPJ.Text += ofd.FileName + ";\n";
            }
        }
    }
}

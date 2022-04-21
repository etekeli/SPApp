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
    public partial class EnqueteView : Form
    {
        private Enquete enquete = null;
        public EnqueteView(Enquete enquete)
        {
            InitializeComponent();
            this.enquete = enquete;
            init();
        }

        private void init()
        {
            this.textBoxDepartement.Text = this.enquete.departement.ToString();
            this.dateTimePickerDate.Value = new DateTime(this.enquete.annee, this.enquete.mois, 1);
            this.richTextBoxSubject.Text = this.enquete.subject;
            if (this.enquete.enqueteur != null)
                this.labelEnqueteurChoisi.Text = this.enquete.enqueteur.Name ;
            this.labelPlaignantChoisi.Text = this.enquete.plaignant.Name;
            this.labelInfracteurChoisi.Text = this.enquete.infracteur.Name;
            this.richTextBoxCommentaires.Text = this.enquete.commentaires;
            this.pj_list();
            if (this.enquete.etat >= Enquete.RENDUE)
            {
                this.numericUpDownImportance.Value = this.enquete.etat - Enquete.RENDUE;
                this.disable();
            }
            else
                this.numericUpDownImportance.Value = this.enquete.etat;

        }

        private void pj_list()
        {
            List<Enquete_PJ> list = Enquete_PJ.getByEnquete(this.enquete);
            listViewPJ.FullRowSelect = true;
            
            foreach (Enquete_PJ epj in list)
            {
                string[] row = { epj.file, epj.dateAjout, epj.ID.ToString()};
                ListViewItem itm = new ListViewItem(row);
                listViewPJ.Items.Add(itm);
            }
        }

        private void buttonAfficherPJ_Click(object sender, EventArgs e)
        {
            PJList pjlist = new PJList(this.enquete);
            pjlist.ShowDialog();
        }

        private void buttonPJ_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choisir les pièces jointes";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Enquete_PJ epj = new Enquete_PJ();
                epj.enquete = this.enquete;
                epj.dateAjout = DateTime.Now.ToString();
                Enquete_PJ.upload(epj, ofd.FileName);
                Enquete_PJ.SaveOrUpdate(epj);
                success("Pièce jointe sauvegardée avec succès !");
            }
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            string itmId = listViewPJ.SelectedItems[0].SubItems[2].Text;
            Enquete_PJ epj = Enquete_PJ.getById(Int32.Parse(itmId));
            Enquete_PJ.download(epj);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEtat_MouseClick(object sender, MouseEventArgs e)
        {
            this.enquete.etat = Enquete.RENDUE + Convert.ToInt32(this.numericUpDownImportance.Value);
            Enquete.Update(this.enquete);
            this.disable();
            this.success("Enquete rendue avec succès !");
        }

        private void disable()
        {
            this.richTextBoxSubject.Enabled = false;
            this.textBoxDepartement.Enabled = false;
            this.buttonChoixEnqueteur.Enabled = false;
            this.buttonEtat.Enabled = false;
            this.buttonEtat.Text = "Enquête rendue";
            this.buttonPJ.Enabled = false;
            this.dateTimePickerDate.Enabled = false;
            this.richTextBoxCommentaires.Enabled = false;
            this.buttonUpdate.Enabled = false;
            this.numericUpDownImportance.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.enquete.etat = Convert.ToInt32(this.numericUpDownImportance.Value);
            this.enquete.commentaires = richTextBoxCommentaires.Text;
            this.enquete.subject = richTextBoxSubject.Text;
            this.enquete.mois = dateTimePickerDate.Value.Month;
            this.enquete.annee = dateTimePickerDate.Value.Year;
            this.enquete.departement = int.Parse(textBoxDepartement.Text);
            Enquete.Update(this.enquete);
            success("Enquête mise à jour avec succès !");
        }

        private void buttonChoixEnqueteur_Click(object sender, EventArgs e)
        {
            var choixPersonnePopup = new PersonnesList(null);
            choixPersonnePopup.setTitle("Choisissez une personne");
            choixPersonnePopup.ShowDialog(this);
            this.enquete.enqueteur = choixPersonnePopup.getChoice();
            this.labelEnqueteurChoisi.Text = this.enquete.enqueteur.Name;
            Enquete.Update(this.enquete);
            success("Enquêteur mis à jour.");
        }

        private void success(string msg)
        {
            this.labelResultMessage.ForeColor = Color.Blue;
            this.labelResultMessage.Text = msg;
        }
        private void error(string msg)
        {
            this.labelResultMessage.ForeColor = Color.Red;
            this.labelResultMessage.Text = msg;
        }
    }
}

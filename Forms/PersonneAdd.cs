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
    public partial class PersonneAdd : Form
    {
        public PersonneAdd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Personne p = new Personne();
            p.Name = textBoxName.Text;
            p.phone = textBoxPhone.Text;
            p.location = textBoxLocation.Text;
            Personne.SaveOrUpdate(p);

            successMessage();
            resetForm();

        }

        private void resetForm()
        {
            this.textBoxName.Text = "";
            this.textBoxPhone.Text = "";
            this.textBoxLocation.Text = "";
        }

        private void errorMessage(string msg)
        {
            this.ResultMessage.ForeColor = Color.Red;
            this.ResultMessage.Text = msg;
        }

        private void successMessage()
        {
            this.ResultMessage.ForeColor = Color.Goldenrod;
            this.ResultMessage.Text = "Ajout effectué avec succès";
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

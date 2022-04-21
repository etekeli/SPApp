using EnqueteSPA.Entities;
using EnqueteSPA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnqueteSPA.Forms
{
    public partial class PersonneView : Form
    {
        private Entities.Personne personne = null;
        private string currentText = null;
        private TextBox activeTextBox = null;
        private Button activeButton = null;

        public PersonneView(Entities.Personne personne)
        {
            InitializeComponent();
            this.personne = personne;
            init();
        }

        private void init()
        {
            textBoxName.Text = this.personne.Name;
            textBoxLocation.Text = this.personne.location;
            textBoxPhone.Text = this.personne.phone;

            buttonName.Tag = textBoxName;
            buttonLocation.Tag = textBoxLocation;
            buttonPhone.Tag = textBoxPhone;

            buttonName.Image = Resources.edit_white;
            buttonLocation.Image = Resources.edit_white;
            buttonPhone.Image = Resources.edit_white;

        }

        public void setTitle(string title)
        {
            labelTitle.Text = title;
        }

        private void ToggleEdit(TextBox tb, Button b)
        {
            if (tb.ReadOnly)
            {
                Edit(tb, b);
            }
            else
            {
                ConfirmEdit(tb, b);
            }
        }

        private void Edit(TextBox tb, Button b)
        {
            this.ActiveControl = tb;
            this.currentText = tb.Text;
            tb.ReadOnly = false;
            b.Image = Resources.check_white;
        }

        private void CancelEdit(TextBox tb, Button b)
        {
            if (this.currentText != null)
            {
                tb.Text = this.currentText;
                this.currentText = null;
                tb.ReadOnly = true;
                b.Image = Resources.edit_white;
            }
        }

        private void ConfirmEdit(TextBox tb, Button b)
        {
            this.currentText = null;
            tb.ReadOnly = true;
            b.Image = Resources.edit_white;

            this.personne.Name = textBoxName.Text;
            this.personne.location = textBoxLocation.Text;
            this.personne.phone = textBoxPhone.Text;

            Personne.SaveOrUpdate(this.personne);
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            TextBox tb = (TextBox)b.Tag;
            this.activeButton = b;
            this.activeTextBox = tb;
            ToggleEdit(tb, b);
        }

        private void PersonneView_Click(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            if (this.ActiveControl is TextBox && this.activeTextBox != null)
                CancelEdit(this.activeTextBox, this.activeButton);
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            if (this.ActiveControl is not Button && this.activeTextBox != null)
                CancelEdit(this.activeTextBox, this.activeButton);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ConfirmEdit(activeTextBox, activeButton);
                this.activeButton = null;
                this.activeTextBox = null;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
    public partial class PersonnesList : Form
    {
        private Personne personneChoisie = null;
        private MainApp mainApp = null;

        public PersonnesList(MainApp mainApp)
        {
            InitializeComponent();
            populateItems();
            this.mainApp = mainApp;
        }

        public PersonnesList setTitle(string title)
        {
            this.labelTitle.Text = title;
            return this;
        }

        private void populateItems()
        {
            if (flowLayoutPanelListe.Controls.Count > 0)
                flowLayoutPanelListe.Controls.Clear();

            List<Personne> list = Personne.getFiltered(this.textBoxSearch.Text);
            ListItem[] listItems = new ListItem[20];
            for (int i = 0; i < list.Count; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Title = list[i].Name;
                listItems[i].Description = list[i].phone;
                listItems[i].Cursor = Cursors.Hand;
                listItems[i].Icon = Resources.clipboard_profile;
                flowLayoutPanelListe.Controls.Add(listItems[i]);

                listItems[i].Click += new EventHandler(choseItem);
                listItems[i].Tag = list[i];

                foreach (Control c in listItems[i].Controls)
                {
                    c.Click += new EventHandler(choseItem);
                    c.Tag = list[i];
                }

            }

        }

        public void choseItem(object sender, EventArgs e) {
            Control li = (Control) sender;
            personneChoisie = (Personne) li.Tag;
            if(this.mainApp != null)
            {
                this.mainApp.OpenForm(new PersonneView(personneChoisie));
            }
            this.Close();
        }

        public Personne getChoice()
        {
            return personneChoisie;
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                populateItems();
        }
    }
}

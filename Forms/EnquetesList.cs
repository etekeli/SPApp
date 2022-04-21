using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using EnqueteSPA.Entities;
using EnqueteSPA.Forms;
using EnqueteSPA.Properties;

namespace EnqueteSPA
{
    public partial class EnquetesList : Form
    {
        private Enquete enqueteChoisie = null;
        private MainApp mainApp = null;

        public EnquetesList(MainApp mainApp)
        {
            InitializeComponent();
            this.mainApp = mainApp;
            populateItems();
        }


        private void populateItems()
        {
                if (flowLayoutPanelListe.Controls.Count > 0)
                    flowLayoutPanelListe.Controls.Clear();

                List<Enquete> list = Enquete.getFiltered(this.textBoxSearch.Text);
                ListItem[] listItems = new ListItem[20];

                System.Diagnostics.Debug.WriteLine("Nombre de lignes : " + list.Count);
                for (int i = 0; i < list.Count; i++)
                {
                    listItems[i] = new ListItem();
                    listItems[i].Title = list[i].subject ;
                    listItems[i].Description = list[i].enqueteur + " - " + list[i].numeroDossier + (list[i].etat >= Enquete.RENDUE ? " - Rendue - Importance : "+ (list[i].etat- Enquete.RENDUE) : " - Importance : "+ list[i].etat);
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

        public void setTitle(string title)
        {
            this.labelTitle.Text = title;
        }
        public void choseItem(object sender, EventArgs e)
        {
            Control li = (Control)sender;
            enqueteChoisie = (Enquete)li.Tag;
            if(this.mainApp != null)
            {
                this.mainApp.OpenForm(new EnqueteView(enqueteChoisie));
            }
                
            this.Close();
        }

        public Enquete getChoice()
        {
            return enqueteChoisie;
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                populateItems();
        }
    }
}

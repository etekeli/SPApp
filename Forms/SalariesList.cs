using EnqueteSPA.Properties;
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
    public partial class SalariesList : Form
    {
        private EnqueteSPA.Entities.Login SalarieChoisi = null;
        private MainApp mainApp = null;

        public SalariesList(MainApp mA)
        {
            this.mainApp = mA;
            InitializeComponent();
            this.populateItems();
        }


        private void populateItems()
        {
            if (flowLayoutPanelListe.Controls.Count > 0)
                flowLayoutPanelListe.Controls.Clear();

            List<EnqueteSPA.Entities.Login> list = EnqueteSPA.Entities.Login.getFiltered(this.textBoxSearch.Text);
            ListItem[] listItems = new ListItem[20];

            System.Diagnostics.Debug.WriteLine("Nombre de lignes : " + list.Count);
            for (int i = 0; i < list.Count; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Title = list[i].login;
                listItems[i].Description = list[i].utilisateur.Name + " - " + list[i].utilisateur.phone;
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

        public void choseItem(object sender, EventArgs e)
        {
            Control li = (Control)sender;
            SalarieChoisi = (EnqueteSPA.Entities.Login)li.Tag;
            if (this.mainApp != null)
                this.mainApp.OpenForm(new SalariesView(mainApp, SalarieChoisi));

            this.Close();
        }

        private void textBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
                populateItems();
        }
    }
}

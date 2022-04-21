using EnqueteSPA.Entities;
using EnqueteSPA.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnqueteSPA.Forms
{
    public partial class PJList : Form
    {
        private Enquete enquete = null;
        public PJList(Enquete enquete)
        {
            InitializeComponent();
            this.enquete = enquete;
            populateItems();

            new Button();


        }

        public void setTitle(string title)
        {
            this.labelTitle.Text = title;
        }

        private void populateItems()
        {
            if (flowLayoutPanelListe.Controls.Count > 0)
                flowLayoutPanelListe.Controls.Clear();

            List<Enquete_PJ> list = Enquete_PJ.getByEnquete(this.enquete);
            ListItem[] listItems = new ListItem[20];
            for (int i = 0; i < list.Count; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Title = list[i].file;
                listItems[i].Description = list[i].dateAjout;
                listItems[i].Cursor = Cursors.Hand;
                listItems[i].Icon = Resources.clipboard_profile;
                flowLayoutPanelListe.Controls.Add(listItems[i]);

                listItems[i].Click += new EventHandler(openFile);
                listItems[i].Tag = list[i];

                foreach (Control c in listItems[i].Controls)
                {
                    c.Click += new EventHandler(openFile);
                    c.Tag = list[i];
                }
            }

        }

        private void openFile(object sender, EventArgs e)
        {/*
            Control senderControl = (Control)sender;
            Enquete_PJ pj = (Enquete_PJ) senderControl.Tag;
            string[] split = pj.file.Split("/");
            Stream myStream = new Stream(pj.file);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    myStream.Close();
                }
            }
            */
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EnqueteSPA.Forms
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        #region Properties

        private string _title;
        private string _description;
        private Image _icon;
        private Color _iconBackColor;


        [Category("Custom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; labelTitle.Text = value; }
        }

        [Category("Custom Props")]
        public string Description
        {
            get { return _description; }
            set { _description = value; labelDescription.Text = value; }
        }

        [Category("Custom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; pictureBoxIcon.Image = value; }
        }

        [Category("Custom Props")]
        public Color IconBackColor
        {
            get { return _iconBackColor; }
            set { _iconBackColor = value;panelIcon.BackColor = _iconBackColor; }
        }


        #endregion

        /**
         * Gère l'interaction quand la souris entre dans l'item
         */
        private void ListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumTurquoise;
        }

        /**
         * Gère l'interaction quand la souris survole l'item
         */
        private void ListItem_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.MediumTurquoise;

        }

        /**
         * Gère l'interaction quand la souris sort de l'item
         */
        private void ListItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        
    }
}

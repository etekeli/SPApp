
namespace EnqueteSPA.Forms
{
    partial class PersonneView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.labelPhone = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.labelLocation = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBoxLocation = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Click += new System.EventHandler(this.PersonneView_Click);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(201, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Informations";
            this.labelTitle.Click += new System.EventHandler(this.PersonneView_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonPhone);
            this.panel2.Controls.Add(this.buttonLocation);
            this.panel2.Controls.Add(this.buttonName);
            this.panel2.Controls.Add(this.labelPhone);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.textBoxPhone);
            this.panel2.Controls.Add(this.labelLocation);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.textBoxLocation);
            this.panel2.Controls.Add(this.labelName);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxName);
            this.panel2.Location = new System.Drawing.Point(92, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 296);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.PersonneView_Click);
            // 
            // buttonPhone
            // 
            this.buttonPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhone.ForeColor = System.Drawing.Color.White;
            this.buttonPhone.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonPhone.Location = new System.Drawing.Point(552, 186);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(24, 24);
            this.buttonPhone.TabIndex = 15;
            this.buttonPhone.Tag = "";
            this.buttonPhone.UseVisualStyleBackColor = false;
            this.buttonPhone.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonLocation
            // 
            this.buttonLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLocation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocation.ForeColor = System.Drawing.Color.White;
            this.buttonLocation.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonLocation.Location = new System.Drawing.Point(552, 106);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(24, 24);
            this.buttonLocation.TabIndex = 14;
            this.buttonLocation.Tag = "";
            this.buttonLocation.UseVisualStyleBackColor = false;
            this.buttonLocation.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonName
            // 
            this.buttonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonName.ForeColor = System.Drawing.Color.White;
            this.buttonName.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonName.Location = new System.Drawing.Point(552, 23);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(24, 24);
            this.buttonName.TabIndex = 12;
            this.buttonName.Tag = "";
            this.buttonName.UseVisualStyleBackColor = false;
            this.buttonName.Click += new System.EventHandler(this.button_Click);
            // 
            // labelPhone
            // 
            this.labelPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.ForeColor = System.Drawing.Color.White;
            this.labelPhone.Location = new System.Drawing.Point(26, 179);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(114, 30);
            this.labelPhone.TabIndex = 11;
            this.labelPhone.Text = "Telephone";
            this.labelPhone.Click += new System.EventHandler(this.PersonneView_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.Turquoise;
            this.panel7.Location = new System.Drawing.Point(26, 242);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(550, 2);
            this.panel7.TabIndex = 10;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPhone.BackColor = System.Drawing.Color.Teal;
            this.textBoxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPhone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPhone.ForeColor = System.Drawing.Color.White;
            this.textBoxPhone.Location = new System.Drawing.Point(26, 213);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.ReadOnly = true;
            this.textBoxPhone.Size = new System.Drawing.Size(550, 29);
            this.textBoxPhone.TabIndex = 9;
            this.textBoxPhone.Tag = "";
            this.textBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxPhone.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelLocation
            // 
            this.labelLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLocation.AutoSize = true;
            this.labelLocation.BackColor = System.Drawing.Color.Transparent;
            this.labelLocation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelLocation.ForeColor = System.Drawing.Color.White;
            this.labelLocation.Location = new System.Drawing.Point(25, 99);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(90, 30);
            this.labelLocation.TabIndex = 8;
            this.labelLocation.Text = "Adresse";
            this.labelLocation.Click += new System.EventHandler(this.PersonneView_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.Turquoise;
            this.panel5.Location = new System.Drawing.Point(26, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(550, 2);
            this.panel5.TabIndex = 7;
            // 
            // textBoxLocation
            // 
            this.textBoxLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxLocation.BackColor = System.Drawing.Color.Teal;
            this.textBoxLocation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLocation.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxLocation.ForeColor = System.Drawing.Color.White;
            this.textBoxLocation.Location = new System.Drawing.Point(26, 132);
            this.textBoxLocation.Name = "textBoxLocation";
            this.textBoxLocation.ReadOnly = true;
            this.textBoxLocation.Size = new System.Drawing.Size(550, 29);
            this.textBoxLocation.TabIndex = 6;
            this.textBoxLocation.Tag = "";
            this.textBoxLocation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxLocation.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.Transparent;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(26, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 30);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Nom";
            this.labelName.Click += new System.EventHandler(this.PersonneView_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Location = new System.Drawing.Point(26, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(550, 2);
            this.panel3.TabIndex = 1;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.BackColor = System.Drawing.Color.Teal;
            this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(26, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(550, 29);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.Tag = "";
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress);
            this.textBoxName.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 0;
            // 
            // PersonneView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 457);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "PersonneView";
            this.Text = "PersonneView";
            this.Click += new System.EventHandler(this.PersonneView_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox textBoxLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Button Phone;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonPhone;
    }
}
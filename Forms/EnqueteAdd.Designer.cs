
namespace EnqueteSPA
{
    partial class EnqueteAdd
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxSubject = new System.Windows.Forms.RichTextBox();
            this.textBoxChoixPJ = new System.Windows.Forms.TextBox();
            this.richTextBoxCommentaires = new System.Windows.Forms.RichTextBox();
            this.buttonPJ = new System.Windows.Forms.Button();
            this.labelPJ = new System.Windows.Forms.Label();
            this.Commentaires = new System.Windows.Forms.Label();
            this.buttonChoixInfracteur = new System.Windows.Forms.Button();
            this.labelInfracteurChoisi = new System.Windows.Forms.Label();
            this.buttonChoixPlaignant = new System.Windows.Forms.Button();
            this.labelPlaignantChoisi = new System.Windows.Forms.Label();
            this.buttonChoixEnqueteur = new System.Windows.Forms.Button();
            this.labelEnqueteurChoisi = new System.Windows.Forms.Label();
            this.labelInfracteur = new System.Windows.Forms.Label();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.buttonPhone = new System.Windows.Forms.Button();
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonForename = new System.Windows.Forms.Button();
            this.buttonName = new System.Windows.Forms.Button();
            this.labelPlaignant = new System.Windows.Forms.Label();
            this.labelEnqueteur = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelDepartement = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBoxDepartement = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownImportance = new System.Windows.Forms.NumericUpDown();
            this.ResultMessage = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImportance)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.AutoEllipsis = true;
            this.buttonAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(521, 378);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 39);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.richTextBoxSubject);
            this.panel2.Controls.Add(this.textBoxChoixPJ);
            this.panel2.Controls.Add(this.richTextBoxCommentaires);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonPJ);
            this.panel2.Controls.Add(this.labelPJ);
            this.panel2.Controls.Add(this.Commentaires);
            this.panel2.Controls.Add(this.buttonChoixInfracteur);
            this.panel2.Controls.Add(this.labelInfracteurChoisi);
            this.panel2.Controls.Add(this.buttonChoixPlaignant);
            this.panel2.Controls.Add(this.labelPlaignantChoisi);
            this.panel2.Controls.Add(this.buttonChoixEnqueteur);
            this.panel2.Controls.Add(this.labelEnqueteurChoisi);
            this.panel2.Controls.Add(this.labelInfracteur);
            this.panel2.Controls.Add(this.dateTimePickerDate);
            this.panel2.Controls.Add(this.buttonPhone);
            this.panel2.Controls.Add(this.buttonLocation);
            this.panel2.Controls.Add(this.buttonForename);
            this.panel2.Controls.Add(this.buttonName);
            this.panel2.Controls.Add(this.labelPlaignant);
            this.panel2.Controls.Add(this.labelEnqueteur);
            this.panel2.Controls.Add(this.labelDate);
            this.panel2.Controls.Add(this.labelDepartement);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxDepartement);
            this.panel2.Location = new System.Drawing.Point(46, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 432);
            this.panel2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(387, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 41;
            this.label1.Text = "Sujet - Animal(aux) concerné(s)";
            // 
            // richTextBoxSubject
            // 
            this.richTextBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSubject.Location = new System.Drawing.Point(392, 49);
            this.richTextBoxSubject.Name = "richTextBoxSubject";
            this.richTextBoxSubject.Size = new System.Drawing.Size(275, 27);
            this.richTextBoxSubject.TabIndex = 40;
            this.richTextBoxSubject.Text = "";
            // 
            // textBoxChoixPJ
            // 
            this.textBoxChoixPJ.AllowDrop = true;
            this.textBoxChoixPJ.Location = new System.Drawing.Point(25, 360);
            this.textBoxChoixPJ.Multiline = true;
            this.textBoxChoixPJ.Name = "textBoxChoixPJ";
            this.textBoxChoixPJ.PlaceholderText = "Pièces jointes...";
            this.textBoxChoixPJ.ReadOnly = true;
            this.textBoxChoixPJ.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChoixPJ.Size = new System.Drawing.Size(333, 72);
            this.textBoxChoixPJ.TabIndex = 39;
            // 
            // richTextBoxCommentaires
            // 
            this.richTextBoxCommentaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCommentaires.Location = new System.Drawing.Point(392, 125);
            this.richTextBoxCommentaires.Name = "richTextBoxCommentaires";
            this.richTextBoxCommentaires.Size = new System.Drawing.Size(275, 233);
            this.richTextBoxCommentaires.TabIndex = 38;
            this.richTextBoxCommentaires.Text = "";
            // 
            // buttonPJ
            // 
            this.buttonPJ.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPJ.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPJ.Location = new System.Drawing.Point(173, 334);
            this.buttonPJ.Name = "buttonPJ";
            this.buttonPJ.Size = new System.Drawing.Size(75, 23);
            this.buttonPJ.TabIndex = 37;
            this.buttonPJ.Text = "Choisir";
            this.buttonPJ.UseVisualStyleBackColor = false;
            this.buttonPJ.Click += new System.EventHandler(this.buttonPJ_Click);
            // 
            // labelPJ
            // 
            this.labelPJ.AutoSize = true;
            this.labelPJ.BackColor = System.Drawing.Color.Transparent;
            this.labelPJ.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPJ.ForeColor = System.Drawing.Color.White;
            this.labelPJ.Location = new System.Drawing.Point(25, 326);
            this.labelPJ.Name = "labelPJ";
            this.labelPJ.Size = new System.Drawing.Size(142, 30);
            this.labelPJ.TabIndex = 35;
            this.labelPJ.Text = "Pièces jointes";
            // 
            // Commentaires
            // 
            this.Commentaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Commentaires.AutoSize = true;
            this.Commentaires.BackColor = System.Drawing.Color.Transparent;
            this.Commentaires.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Commentaires.ForeColor = System.Drawing.Color.White;
            this.Commentaires.Location = new System.Drawing.Point(392, 92);
            this.Commentaires.Name = "Commentaires";
            this.Commentaires.Size = new System.Drawing.Size(154, 30);
            this.Commentaires.TabIndex = 27;
            this.Commentaires.Text = "Commentaires";
            // 
            // buttonChoixInfracteur
            // 
            this.buttonChoixInfracteur.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChoixInfracteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoixInfracteur.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonChoixInfracteur.Location = new System.Drawing.Point(173, 270);
            this.buttonChoixInfracteur.Name = "buttonChoixInfracteur";
            this.buttonChoixInfracteur.Size = new System.Drawing.Size(75, 23);
            this.buttonChoixInfracteur.TabIndex = 24;
            this.buttonChoixInfracteur.Text = "Choisir";
            this.buttonChoixInfracteur.UseVisualStyleBackColor = false;
            this.buttonChoixInfracteur.Click += new System.EventHandler(this.buttonChoixPersonne_Click);
            // 
            // labelInfracteurChoisi
            // 
            this.labelInfracteurChoisi.AutoSize = true;
            this.labelInfracteurChoisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfracteurChoisi.Location = new System.Drawing.Point(25, 297);
            this.labelInfracteurChoisi.Name = "labelInfracteurChoisi";
            this.labelInfracteurChoisi.Size = new System.Drawing.Size(112, 21);
            this.labelInfracteurChoisi.TabIndex = 23;
            this.labelInfracteurChoisi.Text = "NomInfracteur";
            // 
            // buttonChoixPlaignant
            // 
            this.buttonChoixPlaignant.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChoixPlaignant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoixPlaignant.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonChoixPlaignant.Location = new System.Drawing.Point(173, 212);
            this.buttonChoixPlaignant.Name = "buttonChoixPlaignant";
            this.buttonChoixPlaignant.Size = new System.Drawing.Size(75, 23);
            this.buttonChoixPlaignant.TabIndex = 22;
            this.buttonChoixPlaignant.Text = "Choisir";
            this.buttonChoixPlaignant.UseVisualStyleBackColor = false;
            this.buttonChoixPlaignant.Click += new System.EventHandler(this.buttonChoixPersonne_Click);
            // 
            // labelPlaignantChoisi
            // 
            this.labelPlaignantChoisi.AutoSize = true;
            this.labelPlaignantChoisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaignantChoisi.Location = new System.Drawing.Point(25, 240);
            this.labelPlaignantChoisi.Name = "labelPlaignantChoisi";
            this.labelPlaignantChoisi.Size = new System.Drawing.Size(101, 21);
            this.labelPlaignantChoisi.TabIndex = 21;
            this.labelPlaignantChoisi.Text = "NomPlaigant";
            // 
            // buttonChoixEnqueteur
            // 
            this.buttonChoixEnqueteur.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonChoixEnqueteur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChoixEnqueteur.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonChoixEnqueteur.Location = new System.Drawing.Point(173, 157);
            this.buttonChoixEnqueteur.Name = "buttonChoixEnqueteur";
            this.buttonChoixEnqueteur.Size = new System.Drawing.Size(75, 23);
            this.buttonChoixEnqueteur.TabIndex = 20;
            this.buttonChoixEnqueteur.Text = "Choisir";
            this.buttonChoixEnqueteur.UseVisualStyleBackColor = false;
            this.buttonChoixEnqueteur.Click += new System.EventHandler(this.buttonChoixPersonne_Click);
            // 
            // labelEnqueteurChoisi
            // 
            this.labelEnqueteurChoisi.AutoSize = true;
            this.labelEnqueteurChoisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnqueteurChoisi.Location = new System.Drawing.Point(25, 183);
            this.labelEnqueteurChoisi.Name = "labelEnqueteurChoisi";
            this.labelEnqueteurChoisi.Size = new System.Drawing.Size(116, 21);
            this.labelEnqueteurChoisi.TabIndex = 19;
            this.labelEnqueteurChoisi.Text = "NomEnqueteur";
            // 
            // labelInfracteur
            // 
            this.labelInfracteur.AutoSize = true;
            this.labelInfracteur.BackColor = System.Drawing.Color.Transparent;
            this.labelInfracteur.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfracteur.ForeColor = System.Drawing.Color.White;
            this.labelInfracteur.Location = new System.Drawing.Point(25, 267);
            this.labelInfracteur.Name = "labelInfracteur";
            this.labelInfracteur.Size = new System.Drawing.Size(106, 30);
            this.labelInfracteur.TabIndex = 17;
            this.labelInfracteur.Text = "Infracteur";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(89, 102);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 23);
            this.dateTimePickerDate.TabIndex = 16;
            // 
            // buttonPhone
            // 
            this.buttonPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPhone.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPhone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPhone.ForeColor = System.Drawing.Color.White;
            this.buttonPhone.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonPhone.Location = new System.Drawing.Point(1252, 227);
            this.buttonPhone.Name = "buttonPhone";
            this.buttonPhone.Size = new System.Drawing.Size(24, 24);
            this.buttonPhone.TabIndex = 15;
            this.buttonPhone.Tag = "";
            this.buttonPhone.UseVisualStyleBackColor = false;
            // 
            // buttonLocation
            // 
            this.buttonLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLocation.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLocation.ForeColor = System.Drawing.Color.White;
            this.buttonLocation.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonLocation.Location = new System.Drawing.Point(1252, 159);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(24, 24);
            this.buttonLocation.TabIndex = 14;
            this.buttonLocation.Tag = "";
            this.buttonLocation.UseVisualStyleBackColor = false;
            // 
            // buttonForename
            // 
            this.buttonForename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonForename.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonForename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonForename.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonForename.ForeColor = System.Drawing.Color.White;
            this.buttonForename.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonForename.Location = new System.Drawing.Point(1252, 91);
            this.buttonForename.Name = "buttonForename";
            this.buttonForename.Size = new System.Drawing.Size(24, 24);
            this.buttonForename.TabIndex = 13;
            this.buttonForename.Tag = "";
            this.buttonForename.UseVisualStyleBackColor = false;
            // 
            // buttonName
            // 
            this.buttonName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonName.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonName.ForeColor = System.Drawing.Color.White;
            this.buttonName.Image = global::EnqueteSPA.Properties.Resources.edit_white;
            this.buttonName.Location = new System.Drawing.Point(1252, 23);
            this.buttonName.Name = "buttonName";
            this.buttonName.Size = new System.Drawing.Size(24, 24);
            this.buttonName.TabIndex = 12;
            this.buttonName.Tag = "";
            this.buttonName.UseVisualStyleBackColor = false;
            // 
            // labelPlaignant
            // 
            this.labelPlaignant.AutoSize = true;
            this.labelPlaignant.BackColor = System.Drawing.Color.Transparent;
            this.labelPlaignant.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaignant.ForeColor = System.Drawing.Color.White;
            this.labelPlaignant.Location = new System.Drawing.Point(25, 210);
            this.labelPlaignant.Name = "labelPlaignant";
            this.labelPlaignant.Size = new System.Drawing.Size(101, 30);
            this.labelPlaignant.TabIndex = 11;
            this.labelPlaignant.Text = "Plaignant";
            // 
            // labelEnqueteur
            // 
            this.labelEnqueteur.AutoSize = true;
            this.labelEnqueteur.BackColor = System.Drawing.Color.Transparent;
            this.labelEnqueteur.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnqueteur.ForeColor = System.Drawing.Color.White;
            this.labelEnqueteur.Location = new System.Drawing.Point(25, 153);
            this.labelEnqueteur.Name = "labelEnqueteur";
            this.labelEnqueteur.Size = new System.Drawing.Size(112, 30);
            this.labelEnqueteur.TabIndex = 8;
            this.labelEnqueteur.Text = "Enquêteur";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.Location = new System.Drawing.Point(25, 96);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(58, 30);
            this.labelDate.TabIndex = 5;
            this.labelDate.Text = "Date";
            // 
            // labelDepartement
            // 
            this.labelDepartement.AutoSize = true;
            this.labelDepartement.BackColor = System.Drawing.Color.Transparent;
            this.labelDepartement.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDepartement.ForeColor = System.Drawing.Color.White;
            this.labelDepartement.Location = new System.Drawing.Point(25, 23);
            this.labelDepartement.Name = "labelDepartement";
            this.labelDepartement.Size = new System.Drawing.Size(141, 30);
            this.labelDepartement.TabIndex = 2;
            this.labelDepartement.Text = "Département";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Turquoise;
            this.panel3.Location = new System.Drawing.Point(25, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 1;
            // 
            // textBoxDepartement
            // 
            this.textBoxDepartement.BackColor = System.Drawing.Color.White;
            this.textBoxDepartement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDepartement.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxDepartement.Location = new System.Drawing.Point(25, 56);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.PlaceholderText = "ex: 57, 78 ...";
            this.textBoxDepartement.Size = new System.Drawing.Size(150, 22);
            this.textBoxDepartement.TabIndex = 0;
            this.textBoxDepartement.Tag = "";
            this.textBoxDepartement.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDepartement_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownImportance);
            this.panel1.Controls.Add(this.ResultMessage);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(554, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 47;
            this.label2.Text = "Importance";
            // 
            // numericUpDownImportance
            // 
            this.numericUpDownImportance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownImportance.Location = new System.Drawing.Point(684, 52);
            this.numericUpDownImportance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownImportance.Name = "numericUpDownImportance";
            this.numericUpDownImportance.Size = new System.Drawing.Size(42, 27);
            this.numericUpDownImportance.TabIndex = 46;
            this.numericUpDownImportance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ResultMessage
            // 
            this.ResultMessage.AutoSize = true;
            this.ResultMessage.BackColor = System.Drawing.Color.Transparent;
            this.ResultMessage.Location = new System.Drawing.Point(46, 64);
            this.ResultMessage.Name = "ResultMessage";
            this.ResultMessage.Size = new System.Drawing.Size(0, 15);
            this.ResultMessage.TabIndex = 5;
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
            this.labelTitle.Size = new System.Drawing.Size(313, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Ajouter une enquête";
            // 
            // EnqueteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EnqueteAdd";
            this.Text = "AjoutEnquete";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImportance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonPhone;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonForename;
        private System.Windows.Forms.Button buttonName;
        private System.Windows.Forms.Label labelPlaignant;
        private System.Windows.Forms.Label labelEnqueteur;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelDepartement;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBoxDepartement;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ResultMessage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Label labelInfracteur;
        private System.Windows.Forms.Button buttonChoixInfracteur;
        private System.Windows.Forms.Label labelInfracteurChoisi;
        private System.Windows.Forms.Button buttonChoixPlaignant;
        private System.Windows.Forms.Label labelPlaignantChoisi;
        private System.Windows.Forms.Button buttonChoixEnqueteur;
        private System.Windows.Forms.Label labelEnqueteurChoisi;
        private System.Windows.Forms.Label Commentaires;
        private System.Windows.Forms.Button buttonPJ;
        private System.Windows.Forms.Label labelPJ;
        private System.Windows.Forms.RichTextBox richTextBoxCommentaires;
        private System.Windows.Forms.TextBox textBoxChoixPJ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownImportance;
    }
}
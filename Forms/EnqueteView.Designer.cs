
namespace EnqueteSPA.Forms
{
    partial class EnqueteView
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownImportance = new System.Windows.Forms.NumericUpDown();
            this.labelResultMessage = new System.Windows.Forms.Label();
            this.buttonEtat = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBoxSubject = new System.Windows.Forms.RichTextBox();
            this.listViewPJ = new System.Windows.Forms.ListView();
            this.file = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.idEpj = new System.Windows.Forms.ColumnHeader();
            this.richTextBoxCommentaires = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonPJ = new System.Windows.Forms.Button();
            this.labelPJ = new System.Windows.Forms.Label();
            this.Commentaires = new System.Windows.Forms.Label();
            this.labelInfracteurChoisi = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImportance)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.labelTitle.Size = new System.Drawing.Size(136, 45);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Enquête";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDownImportance);
            this.panel1.Controls.Add(this.labelResultMessage);
            this.panel1.Controls.Add(this.buttonEtat);
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 100);
            this.panel1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(354, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 30);
            this.label2.TabIndex = 45;
            this.label2.Text = "Importance";
            // 
            // numericUpDownImportance
            // 
            this.numericUpDownImportance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numericUpDownImportance.Location = new System.Drawing.Point(484, 49);
            this.numericUpDownImportance.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownImportance.Name = "numericUpDownImportance";
            this.numericUpDownImportance.Size = new System.Drawing.Size(42, 27);
            this.numericUpDownImportance.TabIndex = 3;
            this.numericUpDownImportance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelResultMessage
            // 
            this.labelResultMessage.AutoSize = true;
            this.labelResultMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelResultMessage.Location = new System.Drawing.Point(47, 56);
            this.labelResultMessage.Name = "labelResultMessage";
            this.labelResultMessage.Size = new System.Drawing.Size(0, 20);
            this.labelResultMessage.TabIndex = 2;
            // 
            // buttonEtat
            // 
            this.buttonEtat.BackColor = System.Drawing.Color.Red;
            this.buttonEtat.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEtat.ForeColor = System.Drawing.Color.White;
            this.buttonEtat.Location = new System.Drawing.Point(548, 45);
            this.buttonEtat.Name = "buttonEtat";
            this.buttonEtat.Size = new System.Drawing.Size(173, 35);
            this.buttonEtat.TabIndex = 1;
            this.buttonEtat.Text = "Rendre l\'enquête";
            this.buttonEtat.UseVisualStyleBackColor = false;
            this.buttonEtat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonEtat_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.buttonUpdate);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.richTextBoxSubject);
            this.panel2.Controls.Add(this.listViewPJ);
            this.panel2.Controls.Add(this.richTextBoxCommentaires);
            this.panel2.Controls.Add(this.buttonAdd);
            this.panel2.Controls.Add(this.buttonPJ);
            this.panel2.Controls.Add(this.labelPJ);
            this.panel2.Controls.Add(this.Commentaires);
            this.panel2.Controls.Add(this.labelInfracteurChoisi);
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
            this.panel2.Location = new System.Drawing.Point(47, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(711, 432);
            this.panel2.TabIndex = 23;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.AutoEllipsis = true;
            this.buttonUpdate.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonUpdate.ForeColor = System.Drawing.Color.White;
            this.buttonUpdate.Location = new System.Drawing.Point(528, 385);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(146, 39);
            this.buttonUpdate.TabIndex = 44;
            this.buttonUpdate.Text = "Modifier";
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(355, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 30);
            this.label1.TabIndex = 43;
            this.label1.Text = "Sujet - Animal(aux) concerné(s)";
            // 
            // richTextBoxSubject
            // 
            this.richTextBoxSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSubject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxSubject.Location = new System.Drawing.Point(355, 40);
            this.richTextBoxSubject.Name = "richTextBoxSubject";
            this.richTextBoxSubject.Size = new System.Drawing.Size(319, 29);
            this.richTextBoxSubject.TabIndex = 42;
            this.richTextBoxSubject.Text = "";
            // 
            // listViewPJ
            // 
            this.listViewPJ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listViewPJ.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.file,
            this.date,
            this.idEpj});
            this.listViewPJ.HideSelection = false;
            this.listViewPJ.Location = new System.Drawing.Point(14, 306);
            this.listViewPJ.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.listViewPJ.Name = "listViewPJ";
            this.listViewPJ.Size = new System.Drawing.Size(307, 118);
            this.listViewPJ.TabIndex = 41;
            this.listViewPJ.UseCompatibleStateImageBehavior = false;
            this.listViewPJ.View = System.Windows.Forms.View.Details;
            this.listViewPJ.Click += new System.EventHandler(this.listView1_Click);
            // 
            // file
            // 
            this.file.Text = "Fichier";
            this.file.Width = 180;
            // 
            // date
            // 
            this.date.Text = "Date d\'ajout";
            this.date.Width = 120;
            // 
            // idEpj
            // 
            this.idEpj.Text = "";
            this.idEpj.Width = 0;
            // 
            // richTextBoxCommentaires
            // 
            this.richTextBoxCommentaires.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCommentaires.Location = new System.Drawing.Point(355, 109);
            this.richTextBoxCommentaires.Name = "richTextBoxCommentaires";
            this.richTextBoxCommentaires.Size = new System.Drawing.Size(319, 258);
            this.richTextBoxCommentaires.TabIndex = 38;
            this.richTextBoxCommentaires.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.AutoEllipsis = true;
            this.buttonAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAdd.ForeColor = System.Drawing.Color.White;
            this.buttonAdd.Location = new System.Drawing.Point(1032, 710);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(146, 39);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Ajouter";
            this.buttonAdd.UseVisualStyleBackColor = false;
            // 
            // buttonPJ
            // 
            this.buttonPJ.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonPJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPJ.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPJ.Location = new System.Drawing.Point(237, 273);
            this.buttonPJ.Name = "buttonPJ";
            this.buttonPJ.Size = new System.Drawing.Size(75, 27);
            this.buttonPJ.TabIndex = 37;
            this.buttonPJ.Text = "Upload";
            this.buttonPJ.UseVisualStyleBackColor = false;
            this.buttonPJ.Click += new System.EventHandler(this.buttonPJ_Click);
            // 
            // labelPJ
            // 
            this.labelPJ.AutoSize = true;
            this.labelPJ.BackColor = System.Drawing.Color.Transparent;
            this.labelPJ.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPJ.ForeColor = System.Drawing.Color.White;
            this.labelPJ.Location = new System.Drawing.Point(14, 266);
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
            this.Commentaires.Location = new System.Drawing.Point(355, 76);
            this.Commentaires.Name = "Commentaires";
            this.Commentaires.Size = new System.Drawing.Size(154, 30);
            this.Commentaires.TabIndex = 27;
            this.Commentaires.Text = "Commentaires";
            // 
            // labelInfracteurChoisi
            // 
            this.labelInfracteurChoisi.AutoSize = true;
            this.labelInfracteurChoisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfracteurChoisi.Location = new System.Drawing.Point(25, 238);
            this.labelInfracteurChoisi.Name = "labelInfracteurChoisi";
            this.labelInfracteurChoisi.Size = new System.Drawing.Size(112, 21);
            this.labelInfracteurChoisi.TabIndex = 23;
            this.labelInfracteurChoisi.Text = "NomInfracteur";
            // 
            // labelPlaignantChoisi
            // 
            this.labelPlaignantChoisi.AutoSize = true;
            this.labelPlaignantChoisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlaignantChoisi.Location = new System.Drawing.Point(25, 184);
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
            this.buttonChoixEnqueteur.Location = new System.Drawing.Point(173, 105);
            this.buttonChoixEnqueteur.Name = "buttonChoixEnqueteur";
            this.buttonChoixEnqueteur.Size = new System.Drawing.Size(75, 23);
            this.buttonChoixEnqueteur.TabIndex = 20;
            this.buttonChoixEnqueteur.Text = "Choisir";
            this.buttonChoixEnqueteur.UseVisualStyleBackColor = false;
            this.buttonChoixEnqueteur.Click += new System.EventHandler(this.buttonChoixEnqueteur_Click);
            // 
            // labelEnqueteurChoisi
            // 
            this.labelEnqueteurChoisi.AutoSize = true;
            this.labelEnqueteurChoisi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnqueteurChoisi.Location = new System.Drawing.Point(25, 128);
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
            this.labelInfracteur.Location = new System.Drawing.Point(25, 212);
            this.labelInfracteur.Name = "labelInfracteur";
            this.labelInfracteur.Size = new System.Drawing.Size(106, 30);
            this.labelInfracteur.TabIndex = 17;
            this.labelInfracteur.Text = "Infracteur";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(86, 76);
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
            this.buttonPhone.Location = new System.Drawing.Point(1763, 227);
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
            this.buttonLocation.Location = new System.Drawing.Point(1763, 159);
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
            this.buttonForename.Location = new System.Drawing.Point(1763, 91);
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
            this.buttonName.Location = new System.Drawing.Point(1763, 23);
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
            this.labelPlaignant.Location = new System.Drawing.Point(25, 156);
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
            this.labelEnqueteur.Location = new System.Drawing.Point(25, 98);
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
            this.labelDate.Location = new System.Drawing.Point(22, 67);
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
            this.labelDepartement.Location = new System.Drawing.Point(25, 0);
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
            this.textBoxDepartement.Location = new System.Drawing.Point(25, 33);
            this.textBoxDepartement.Name = "textBoxDepartement";
            this.textBoxDepartement.PlaceholderText = "ex: 57, 78 ...";
            this.textBoxDepartement.Size = new System.Drawing.Size(150, 22);
            this.textBoxDepartement.TabIndex = 0;
            this.textBoxDepartement.Tag = "";
            // 
            // EnqueteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EnqueteView";
            this.Text = "EnqueteView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownImportance)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox richTextBoxCommentaires;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonPJ;
        private System.Windows.Forms.Label labelPJ;
        private System.Windows.Forms.Label Commentaires;
        private System.Windows.Forms.Label labelInfracteurChoisi;
        private System.Windows.Forms.Label labelPlaignantChoisi;
        private System.Windows.Forms.Button buttonChoixEnqueteur;
        private System.Windows.Forms.Label labelEnqueteurChoisi;
        private System.Windows.Forms.Label labelInfracteur;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
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
        private System.Windows.Forms.ListView listViewPJ;
        private System.Windows.Forms.ColumnHeader file;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader idEpj;
        private System.Windows.Forms.Button buttonEtat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxSubject;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelResultMessage;
        private System.Windows.Forms.NumericUpDown numericUpDownImportance;
        private System.Windows.Forms.Label label2;
    }
}
﻿namespace LibraryManagementSystem.ui
{
    partial class LibrarianForm
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.idUserBox = new MaterialSkin.Controls.MaterialTextBox();
            this.idBookBox = new MaterialSkin.Controls.MaterialTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.registerLoanBtn = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.credentialPage = new System.Windows.Forms.TabPage();
            this.titleBookBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorBookBox = new MaterialSkin.Controls.MaterialTextBox();
            this.copiesBookBox = new MaterialSkin.Controls.MaterialTextBox();
            this.idBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.saveChangesBtn = new MaterialSkin.Controls.MaterialButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.titleBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorBox = new MaterialSkin.Controls.MaterialTextBox();
            this.categoryBox = new MaterialSkin.Controls.MaterialComboBox();
            this.copiesSlide = new MaterialSkin.Controls.MaterialSlider();
            this.yearBox = new MaterialSkin.Controls.MaterialTextBox();
            this.registerBookBtn = new MaterialSkin.Controls.MaterialButton();
            this.buscarTxt = new MaterialSkin.Controls.MaterialLabel();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.titleSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.authorSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.searchTitleBtn = new MaterialSkin.Controls.MaterialButton();
            this.searchAuthorBtn = new MaterialSkin.Controls.MaterialButton();
            this.searchCategoryBtn = new MaterialSkin.Controls.MaterialButton();
            this.categorySearchBox = new MaterialSkin.Controls.MaterialComboBox();
            this.bookListView = new MaterialSkin.Controls.MaterialListView();
            this.idListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copiesListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1.SuspendLayout();
            this.credentialPage.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.dataPage.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.registerLoanBtn);
            this.tabPage1.Controls.Add(this.idBookBox);
            this.tabPage1.Controls.Add(this.idUserBox);
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(786, 357);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registrar préstamo";
            // 
            // idUserBox
            // 
            this.idUserBox.AnimateReadOnly = false;
            this.idUserBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idUserBox.Depth = 0;
            this.idUserBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idUserBox.LeadingIcon = null;
            this.idUserBox.Location = new System.Drawing.Point(424, 90);
            this.idUserBox.MaxLength = 50;
            this.idUserBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idUserBox.Multiline = false;
            this.idUserBox.Name = "idUserBox";
            this.idUserBox.Size = new System.Drawing.Size(281, 50);
            this.idUserBox.TabIndex = 4;
            this.idUserBox.Text = "";
            this.idUserBox.TrailingIcon = null;
            // 
            // idBookBox
            // 
            this.idBookBox.AnimateReadOnly = false;
            this.idBookBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBookBox.Depth = 0;
            this.idBookBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBookBox.LeadingIcon = null;
            this.idBookBox.Location = new System.Drawing.Point(67, 90);
            this.idBookBox.MaxLength = 50;
            this.idBookBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idBookBox.Multiline = false;
            this.idBookBox.Name = "idBookBox";
            this.idBookBox.Size = new System.Drawing.Size(281, 50);
            this.idBookBox.TabIndex = 5;
            this.idBookBox.Text = "";
            this.idBookBox.TrailingIcon = null;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(246, 233);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(281, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // registerLoanBtn
            // 
            this.registerLoanBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerLoanBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerLoanBtn.Depth = 0;
            this.registerLoanBtn.HighEmphasis = true;
            this.registerLoanBtn.Icon = null;
            this.registerLoanBtn.Location = new System.Drawing.Point(296, 315);
            this.registerLoanBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerLoanBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerLoanBtn.Name = "registerLoanBtn";
            this.registerLoanBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerLoanBtn.Size = new System.Drawing.Size(180, 36);
            this.registerLoanBtn.TabIndex = 7;
            this.registerLoanBtn.Text = "Registrar préstamo";
            this.registerLoanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerLoanBtn.UseAccentColor = false;
            this.registerLoanBtn.UseVisualStyleBackColor = true;
            this.registerLoanBtn.Click += new System.EventHandler(this.registerLoanBtn_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(293, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(173, 19);
            this.materialLabel1.TabIndex = 13;
            this.materialLabel1.Text = "REGISTRAR PRÉSTAMO";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(311, 191);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(150, 19);
            this.materialLabel2.TabIndex = 14;
            this.materialLabel2.Text = "Fecha de devolución:";
            // 
            // credentialPage
            // 
            this.credentialPage.BackColor = System.Drawing.SystemColors.Control;
            this.credentialPage.Controls.Add(this.saveChangesBtn);
            this.credentialPage.Controls.Add(this.materialLabel3);
            this.credentialPage.Controls.Add(this.idBox);
            this.credentialPage.Controls.Add(this.copiesBookBox);
            this.credentialPage.Controls.Add(this.authorBookBox);
            this.credentialPage.Controls.Add(this.titleBookBox);
            this.credentialPage.Location = new System.Drawing.Point(4, 22);
            this.credentialPage.Name = "credentialPage";
            this.credentialPage.Padding = new System.Windows.Forms.Padding(3);
            this.credentialPage.Size = new System.Drawing.Size(786, 357);
            this.credentialPage.TabIndex = 1;
            this.credentialPage.Text = "Modificar libro";
            // 
            // titleBookBox
            // 
            this.titleBookBox.AnimateReadOnly = false;
            this.titleBookBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBookBox.Depth = 0;
            this.titleBookBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleBookBox.LeadingIcon = null;
            this.titleBookBox.Location = new System.Drawing.Point(49, 178);
            this.titleBookBox.MaxLength = 50;
            this.titleBookBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleBookBox.Multiline = false;
            this.titleBookBox.Name = "titleBookBox";
            this.titleBookBox.Size = new System.Drawing.Size(184, 50);
            this.titleBookBox.TabIndex = 0;
            this.titleBookBox.Text = "";
            this.titleBookBox.TrailingIcon = null;
            // 
            // authorBookBox
            // 
            this.authorBookBox.AnimateReadOnly = false;
            this.authorBookBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorBookBox.Depth = 0;
            this.authorBookBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorBookBox.LeadingIcon = null;
            this.authorBookBox.Location = new System.Drawing.Point(534, 178);
            this.authorBookBox.MaxLength = 50;
            this.authorBookBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorBookBox.Multiline = false;
            this.authorBookBox.Name = "authorBookBox";
            this.authorBookBox.Size = new System.Drawing.Size(184, 50);
            this.authorBookBox.TabIndex = 1;
            this.authorBookBox.Text = "";
            this.authorBookBox.TrailingIcon = null;
            // 
            // copiesBookBox
            // 
            this.copiesBookBox.AnimateReadOnly = false;
            this.copiesBookBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.copiesBookBox.Depth = 0;
            this.copiesBookBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.copiesBookBox.LeadingIcon = null;
            this.copiesBookBox.Location = new System.Drawing.Point(291, 178);
            this.copiesBookBox.MaxLength = 50;
            this.copiesBookBox.MouseState = MaterialSkin.MouseState.OUT;
            this.copiesBookBox.Multiline = false;
            this.copiesBookBox.Name = "copiesBookBox";
            this.copiesBookBox.Size = new System.Drawing.Size(184, 50);
            this.copiesBookBox.TabIndex = 2;
            this.copiesBookBox.Text = "";
            this.copiesBookBox.TrailingIcon = null;
            // 
            // idBox
            // 
            this.idBox.AnimateReadOnly = false;
            this.idBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idBox.Depth = 0;
            this.idBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBox.LeadingIcon = null;
            this.idBox.Location = new System.Drawing.Point(275, 80);
            this.idBox.MaxLength = 50;
            this.idBox.MouseState = MaterialSkin.MouseState.OUT;
            this.idBox.Multiline = false;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(216, 50);
            this.idBox.TabIndex = 3;
            this.idBox.Text = "";
            this.idBox.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(310, 21);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(142, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "ACTUALIZAR LIBRO";
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveChangesBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveChangesBtn.Depth = 0;
            this.saveChangesBtn.HighEmphasis = true;
            this.saveChangesBtn.Icon = null;
            this.saveChangesBtn.Location = new System.Drawing.Point(303, 294);
            this.saveChangesBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveChangesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveChangesBtn.Size = new System.Drawing.Size(157, 36);
            this.saveChangesBtn.TabIndex = 5;
            this.saveChangesBtn.Text = "GUARDAR CAMBIOS";
            this.saveChangesBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveChangesBtn.UseAccentColor = false;
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            this.saveChangesBtn.Click += new System.EventHandler(this.saveChangesBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.buscarTxt);
            this.tabPage2.Controls.Add(this.registerBookBtn);
            this.tabPage2.Controls.Add(this.yearBox);
            this.tabPage2.Controls.Add(this.copiesSlide);
            this.tabPage2.Controls.Add(this.authorBox);
            this.tabPage2.Controls.Add(this.titleBox);
            this.tabPage2.Controls.Add(this.categoryBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(786, 357);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Registrar libro";
            // 
            // titleBox
            // 
            this.titleBox.AnimateReadOnly = false;
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Depth = 0;
            this.titleBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleBox.LeadingIcon = null;
            this.titleBox.Location = new System.Drawing.Point(63, 66);
            this.titleBox.MaxLength = 50;
            this.titleBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleBox.Multiline = false;
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(281, 50);
            this.titleBox.TabIndex = 3;
            this.titleBox.Text = "";
            this.titleBox.TrailingIcon = null;
            // 
            // authorBox
            // 
            this.authorBox.AnimateReadOnly = false;
            this.authorBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorBox.Depth = 0;
            this.authorBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorBox.LeadingIcon = null;
            this.authorBox.Location = new System.Drawing.Point(63, 163);
            this.authorBox.MaxLength = 50;
            this.authorBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorBox.Multiline = false;
            this.authorBox.Name = "authorBox";
            this.authorBox.Size = new System.Drawing.Size(281, 50);
            this.authorBox.TabIndex = 4;
            this.authorBox.Text = "";
            this.authorBox.TrailingIcon = null;
            // 
            // categoryBox
            // 
            this.categoryBox.AutoResize = false;
            this.categoryBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categoryBox.Depth = 0;
            this.categoryBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.categoryBox.DropDownHeight = 174;
            this.categoryBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryBox.DropDownWidth = 121;
            this.categoryBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.categoryBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.IntegralHeight = false;
            this.categoryBox.ItemHeight = 43;
            this.categoryBox.Items.AddRange(new object[] {
            "CATEGORÍA",
            "AVENTURAS",
            "CIENCIA FICCIÓN",
            "ROMANCE",
            "FANTASÍA",
            "NOVELA",
            "CUENTO"});
            this.categoryBox.Location = new System.Drawing.Point(439, 162);
            this.categoryBox.MaxDropDownItems = 4;
            this.categoryBox.MouseState = MaterialSkin.MouseState.OUT;
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(281, 49);
            this.categoryBox.StartIndex = 0;
            this.categoryBox.TabIndex = 5;
            // 
            // copiesSlide
            // 
            this.copiesSlide.Depth = 0;
            this.copiesSlide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.copiesSlide.Location = new System.Drawing.Point(239, 246);
            this.copiesSlide.MouseState = MaterialSkin.MouseState.HOVER;
            this.copiesSlide.Name = "copiesSlide";
            this.copiesSlide.Size = new System.Drawing.Size(325, 40);
            this.copiesSlide.TabIndex = 6;
            this.copiesSlide.Text = "Numero de copias";
            // 
            // yearBox
            // 
            this.yearBox.AnimateReadOnly = false;
            this.yearBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.yearBox.Depth = 0;
            this.yearBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.yearBox.LeadingIcon = null;
            this.yearBox.Location = new System.Drawing.Point(439, 66);
            this.yearBox.MaxLength = 50;
            this.yearBox.MouseState = MaterialSkin.MouseState.OUT;
            this.yearBox.Multiline = false;
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(281, 50);
            this.yearBox.TabIndex = 7;
            this.yearBox.Text = "";
            this.yearBox.TrailingIcon = null;
            // 
            // registerBookBtn
            // 
            this.registerBookBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.registerBookBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.registerBookBtn.Depth = 0;
            this.registerBookBtn.HighEmphasis = true;
            this.registerBookBtn.Icon = null;
            this.registerBookBtn.Location = new System.Drawing.Point(328, 325);
            this.registerBookBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.registerBookBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.registerBookBtn.Name = "registerBookBtn";
            this.registerBookBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.registerBookBtn.Size = new System.Drawing.Size(143, 36);
            this.registerBookBtn.TabIndex = 8;
            this.registerBookBtn.Text = "Registrar libro";
            this.registerBookBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerBookBtn.UseAccentColor = false;
            this.registerBookBtn.UseVisualStyleBackColor = true;
            this.registerBookBtn.Click += new System.EventHandler(this.registerBookBtn_Click);
            // 
            // buscarTxt
            // 
            this.buscarTxt.AutoSize = true;
            this.buscarTxt.Depth = 0;
            this.buscarTxt.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.buscarTxt.Location = new System.Drawing.Point(325, 21);
            this.buscarTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(133, 19);
            this.buscarTxt.TabIndex = 13;
            this.buscarTxt.Text = "REGISTRAR LIBRO";
            // 
            // dataPage
            // 
            this.dataPage.BackColor = System.Drawing.SystemColors.Control;
            this.dataPage.Controls.Add(this.bookListView);
            this.dataPage.Controls.Add(this.searchCategoryBtn);
            this.dataPage.Controls.Add(this.searchAuthorBtn);
            this.dataPage.Controls.Add(this.searchTitleBtn);
            this.dataPage.Controls.Add(this.authorSearchBox);
            this.dataPage.Controls.Add(this.titleSearchBox);
            this.dataPage.Controls.Add(this.categorySearchBox);
            this.dataPage.Location = new System.Drawing.Point(4, 22);
            this.dataPage.Name = "dataPage";
            this.dataPage.Padding = new System.Windows.Forms.Padding(3);
            this.dataPage.Size = new System.Drawing.Size(786, 357);
            this.dataPage.TabIndex = 0;
            this.dataPage.Text = "Buscar libro";
            // 
            // titleSearchBox
            // 
            this.titleSearchBox.AnimateReadOnly = false;
            this.titleSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleSearchBox.Depth = 0;
            this.titleSearchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.titleSearchBox.LeadingIcon = null;
            this.titleSearchBox.Location = new System.Drawing.Point(15, 19);
            this.titleSearchBox.MaxLength = 50;
            this.titleSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.titleSearchBox.Multiline = false;
            this.titleSearchBox.Name = "titleSearchBox";
            this.titleSearchBox.Size = new System.Drawing.Size(214, 50);
            this.titleSearchBox.TabIndex = 0;
            this.titleSearchBox.Text = "";
            this.titleSearchBox.TrailingIcon = null;
            // 
            // authorSearchBox
            // 
            this.authorSearchBox.AnimateReadOnly = false;
            this.authorSearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.authorSearchBox.Depth = 0;
            this.authorSearchBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.authorSearchBox.LeadingIcon = null;
            this.authorSearchBox.Location = new System.Drawing.Point(15, 142);
            this.authorSearchBox.MaxLength = 50;
            this.authorSearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.authorSearchBox.Multiline = false;
            this.authorSearchBox.Name = "authorSearchBox";
            this.authorSearchBox.Size = new System.Drawing.Size(214, 50);
            this.authorSearchBox.TabIndex = 1;
            this.authorSearchBox.Text = "";
            this.authorSearchBox.TrailingIcon = null;
            // 
            // searchTitleBtn
            // 
            this.searchTitleBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchTitleBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchTitleBtn.Depth = 0;
            this.searchTitleBtn.HighEmphasis = true;
            this.searchTitleBtn.Icon = null;
            this.searchTitleBtn.Location = new System.Drawing.Point(77, 78);
            this.searchTitleBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchTitleBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchTitleBtn.Name = "searchTitleBtn";
            this.searchTitleBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchTitleBtn.Size = new System.Drawing.Size(77, 36);
            this.searchTitleBtn.TabIndex = 4;
            this.searchTitleBtn.Text = "Buscar";
            this.searchTitleBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchTitleBtn.UseAccentColor = false;
            this.searchTitleBtn.UseVisualStyleBackColor = true;
            this.searchTitleBtn.Click += new System.EventHandler(this.searchTitleBtn_Click);
            // 
            // searchAuthorBtn
            // 
            this.searchAuthorBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchAuthorBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchAuthorBtn.Depth = 0;
            this.searchAuthorBtn.HighEmphasis = true;
            this.searchAuthorBtn.Icon = null;
            this.searchAuthorBtn.Location = new System.Drawing.Point(77, 201);
            this.searchAuthorBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchAuthorBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchAuthorBtn.Name = "searchAuthorBtn";
            this.searchAuthorBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchAuthorBtn.Size = new System.Drawing.Size(77, 36);
            this.searchAuthorBtn.TabIndex = 5;
            this.searchAuthorBtn.Text = "Buscar";
            this.searchAuthorBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchAuthorBtn.UseAccentColor = false;
            this.searchAuthorBtn.UseVisualStyleBackColor = true;
            // 
            // searchCategoryBtn
            // 
            this.searchCategoryBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchCategoryBtn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.searchCategoryBtn.Depth = 0;
            this.searchCategoryBtn.HighEmphasis = true;
            this.searchCategoryBtn.Icon = null;
            this.searchCategoryBtn.Location = new System.Drawing.Point(77, 316);
            this.searchCategoryBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchCategoryBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.searchCategoryBtn.Name = "searchCategoryBtn";
            this.searchCategoryBtn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.searchCategoryBtn.Size = new System.Drawing.Size(77, 36);
            this.searchCategoryBtn.TabIndex = 6;
            this.searchCategoryBtn.Text = "Buscar";
            this.searchCategoryBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.searchCategoryBtn.UseAccentColor = false;
            this.searchCategoryBtn.UseVisualStyleBackColor = true;
            // 
            // categorySearchBox
            // 
            this.categorySearchBox.AutoResize = false;
            this.categorySearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.categorySearchBox.Depth = 0;
            this.categorySearchBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.categorySearchBox.DropDownHeight = 174;
            this.categorySearchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorySearchBox.DropDownWidth = 121;
            this.categorySearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.categorySearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.categorySearchBox.FormattingEnabled = true;
            this.categorySearchBox.IntegralHeight = false;
            this.categorySearchBox.ItemHeight = 43;
            this.categorySearchBox.Items.AddRange(new object[] {
            "CATEGORÍA",
            "AVENTURAS",
            "CIENCIA FICCIÓN",
            "ROMANCE",
            "FANTASÍA",
            "NOVELA",
            "CUENTO"});
            this.categorySearchBox.Location = new System.Drawing.Point(15, 258);
            this.categorySearchBox.MaxDropDownItems = 4;
            this.categorySearchBox.MouseState = MaterialSkin.MouseState.OUT;
            this.categorySearchBox.Name = "categorySearchBox";
            this.categorySearchBox.Size = new System.Drawing.Size(214, 49);
            this.categorySearchBox.StartIndex = 0;
            this.categorySearchBox.TabIndex = 7;
            // 
            // bookListView
            // 
            this.bookListView.AutoSizeTable = false;
            this.bookListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bookListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idListView,
            this.titleListView,
            this.authorListView,
            this.categoryListView,
            this.copiesListView,
            this.yearListView});
            this.bookListView.Depth = 0;
            this.bookListView.Dock = System.Windows.Forms.DockStyle.Right;
            this.bookListView.FullRowSelect = true;
            this.bookListView.HideSelection = false;
            this.bookListView.Location = new System.Drawing.Point(265, 3);
            this.bookListView.MinimumSize = new System.Drawing.Size(200, 100);
            this.bookListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.bookListView.MouseState = MaterialSkin.MouseState.OUT;
            this.bookListView.Name = "bookListView";
            this.bookListView.OwnerDraw = true;
            this.bookListView.Size = new System.Drawing.Size(518, 351);
            this.bookListView.TabIndex = 8;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            // 
            // idListView
            // 
            this.idListView.Text = "ID";
            this.idListView.Width = 50;
            // 
            // titleListView
            // 
            this.titleListView.Text = "Titulo";
            this.titleListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleListView.Width = 120;
            // 
            // authorListView
            // 
            this.authorListView.Text = "Autor";
            this.authorListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorListView.Width = 100;
            // 
            // categoryListView
            // 
            this.categoryListView.Text = "Categoría";
            this.categoryListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.categoryListView.Width = 100;
            // 
            // copiesListView
            // 
            this.copiesListView.Text = "Copias";
            this.copiesListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.copiesListView.Width = 80;
            // 
            // yearListView
            // 
            this.yearListView.Text = "Año";
            this.yearListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.dataPage);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.credentialPage);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 11;
            // 
            // LibrarianForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "LibrarianForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil: Bibliotecario";
            this.Load += new System.EventHandler(this.LibrarianForm_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.credentialPage.ResumeLayout(false);
            this.credentialPage.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            this.materialTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton registerLoanBtn;
        private MaterialSkin.Controls.MaterialTextBox idBookBox;
        private MaterialSkin.Controls.MaterialTextBox idUserBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TabPage credentialPage;
        private MaterialSkin.Controls.MaterialButton saveChangesBtn;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox idBox;
        private MaterialSkin.Controls.MaterialTextBox copiesBookBox;
        private MaterialSkin.Controls.MaterialTextBox authorBookBox;
        private MaterialSkin.Controls.MaterialTextBox titleBookBox;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialLabel buscarTxt;
        private MaterialSkin.Controls.MaterialButton registerBookBtn;
        private MaterialSkin.Controls.MaterialTextBox yearBox;
        private MaterialSkin.Controls.MaterialSlider copiesSlide;
        private MaterialSkin.Controls.MaterialTextBox authorBox;
        private MaterialSkin.Controls.MaterialTextBox titleBox;
        private MaterialSkin.Controls.MaterialComboBox categoryBox;
        private System.Windows.Forms.TabPage dataPage;
        private MaterialSkin.Controls.MaterialListView bookListView;
        private System.Windows.Forms.ColumnHeader idListView;
        private System.Windows.Forms.ColumnHeader titleListView;
        private System.Windows.Forms.ColumnHeader authorListView;
        private System.Windows.Forms.ColumnHeader categoryListView;
        private System.Windows.Forms.ColumnHeader copiesListView;
        private System.Windows.Forms.ColumnHeader yearListView;
        private MaterialSkin.Controls.MaterialButton searchCategoryBtn;
        private MaterialSkin.Controls.MaterialButton searchAuthorBtn;
        private MaterialSkin.Controls.MaterialButton searchTitleBtn;
        private MaterialSkin.Controls.MaterialTextBox authorSearchBox;
        private MaterialSkin.Controls.MaterialTextBox titleSearchBox;
        private MaterialSkin.Controls.MaterialComboBox categorySearchBox;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
    }
}
namespace LibraryManagementSystem.ui
{
    partial class UserForm
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
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.dataPage = new System.Windows.Forms.TabPage();
            this.bookListView = new MaterialSkin.Controls.MaterialListView();
            this.idListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.copiesListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.yearListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchCategoryBtn = new MaterialSkin.Controls.MaterialButton();
            this.searchAuthorBtn = new MaterialSkin.Controls.MaterialButton();
            this.searchTitleBtn = new MaterialSkin.Controls.MaterialButton();
            this.authorSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.titleSearchBox = new MaterialSkin.Controls.MaterialTextBox();
            this.categorySearchBox = new MaterialSkin.Controls.MaterialComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.registerLoanBtn = new MaterialSkin.Controls.MaterialButton();
            this.idLoanListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookLoanListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateLoanListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDateLoanListView = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialTabControl1.SuspendLayout();
            this.dataPage.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.dataPage);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 12;
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.materialListView1);
            this.tabPage1.Controls.Add(this.registerLoanBtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(786, 357);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Historial préstamo";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idLoanListView,
            this.bookLoanListView,
            this.dateLoanListView,
            this.dueDateLoanListView});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.HideSelection = false;
            this.materialListView1.Location = new System.Drawing.Point(0, 0);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(786, 293);
            this.materialListView1.TabIndex = 8;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            this.materialListView1.SelectedIndexChanged += new System.EventHandler(this.materialListView1_SelectedIndexChanged);
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
            this.registerLoanBtn.Size = new System.Drawing.Size(169, 36);
            this.registerLoanBtn.TabIndex = 7;
            this.registerLoanBtn.Text = "Cargar préstamos";
            this.registerLoanBtn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.registerLoanBtn.UseAccentColor = false;
            this.registerLoanBtn.UseVisualStyleBackColor = true;
            this.registerLoanBtn.Click += new System.EventHandler(this.registerLoanBtn_Click);
            // 
            // idLoanListView
            // 
            this.idLoanListView.Text = "ID";
            // 
            // bookLoanListView
            // 
            this.bookLoanListView.Text = "Libro";
            this.bookLoanListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.bookLoanListView.Width = 300;
            // 
            // dateLoanListView
            // 
            this.dateLoanListView.Text = "Fecha préstamo";
            this.dateLoanListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dateLoanListView.Width = 200;
            // 
            // dueDateLoanListView
            // 
            this.dueDateLoanListView.Text = "Fecha devolución";
            this.dueDateLoanListView.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dueDateLoanListView.Width = 200;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Perfil: Usuario";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.dataPage.ResumeLayout(false);
            this.dataPage.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
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
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialButton registerLoanBtn;
        private MaterialSkin.Controls.MaterialListView materialListView1;
        private System.Windows.Forms.ColumnHeader idLoanListView;
        private System.Windows.Forms.ColumnHeader bookLoanListView;
        private System.Windows.Forms.ColumnHeader dateLoanListView;
        private System.Windows.Forms.ColumnHeader dueDateLoanListView;
    }
}
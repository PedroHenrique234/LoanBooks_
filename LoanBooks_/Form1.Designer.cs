namespace LoanBooks_
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPagePrincipal = new System.Windows.Forms.TabPage();
            this.tabPageAuthor = new System.Windows.Forms.TabPage();
            this.pnlAuthor = new System.Windows.Forms.Panel();
            this.groupBoxSearchAuthor = new System.Windows.Forms.GroupBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.cmbAuthorNationalitySearch = new System.Windows.Forms.ComboBox();
            this.txtAuthorNameSearch = new System.Windows.Forms.TextBox();
            this.lblAuthorNationalitySearch = new System.Windows.Forms.Label();
            this.lblAuthorNameSearch = new System.Windows.Forms.Label();
            this.tabPageClient = new System.Windows.Forms.TabPage();
            this.tabPagePublishingCompany = new System.Windows.Forms.TabPage();
            this.tabPageTheme = new System.Windows.Forms.TabPage();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridViewAuthor = new System.Windows.Forms.DataGridView();
            this.btnNewAuthor = new System.Windows.Forms.Button();
            this.btnEditAuthor = new System.Windows.Forms.Button();
            this.btnDeletAuthor = new System.Windows.Forms.Button();
            this.groupBoxSearchClient = new System.Windows.Forms.GroupBox();
            this.btnSearchClient = new System.Windows.Forms.Button();
            this.txtIdNameSearch = new System.Windows.Forms.TextBox();
            this.txtClientNameSearch = new System.Windows.Forms.TextBox();
            this.lblClientId = new System.Windows.Forms.Label();
            this.lblNameClient = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tab.SuspendLayout();
            this.tabPageAuthor.SuspendLayout();
            this.pnlAuthor.SuspendLayout();
            this.groupBoxSearchAuthor.SuspendLayout();
            this.tabPageClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).BeginInit();
            this.groupBoxSearchClient.SuspendLayout();
            this.pnlClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPagePrincipal);
            this.tab.Controls.Add(this.tabPageAuthor);
            this.tab.Controls.Add(this.tabPageClient);
            this.tab.Controls.Add(this.tabPagePublishingCompany);
            this.tab.Controls.Add(this.tabPageTheme);
            this.tab.Controls.Add(this.tabPageBook);
            this.tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab.Location = new System.Drawing.Point(0, 0);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(1214, 711);
            this.tab.TabIndex = 0;
            this.tab.SelectedIndexChanged += new System.EventHandler(this.tabPrincipal_SelectedIndexChanged);
            // 
            // tabPagePrincipal
            // 
            this.tabPagePrincipal.Location = new System.Drawing.Point(4, 24);
            this.tabPagePrincipal.Name = "tabPagePrincipal";
            this.tabPagePrincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrincipal.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePrincipal.TabIndex = 0;
            this.tabPagePrincipal.Text = "Principal";
            this.tabPagePrincipal.UseVisualStyleBackColor = true;
            // 
            // tabPageAuthor
            // 
            this.tabPageAuthor.Controls.Add(this.pnlAuthor);
            this.tabPageAuthor.Controls.Add(this.groupBoxSearchAuthor);
            this.tabPageAuthor.Location = new System.Drawing.Point(4, 24);
            this.tabPageAuthor.Name = "tabPageAuthor";
            this.tabPageAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAuthor.Size = new System.Drawing.Size(1206, 683);
            this.tabPageAuthor.TabIndex = 1;
            this.tabPageAuthor.Text = "Author";
            this.tabPageAuthor.UseVisualStyleBackColor = true;
            // 
            // pnlAuthor
            // 
            this.pnlAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAuthor.BackColor = System.Drawing.Color.Transparent;
            this.pnlAuthor.Controls.Add(this.btnDeletAuthor);
            this.pnlAuthor.Controls.Add(this.btnEditAuthor);
            this.pnlAuthor.Controls.Add(this.btnNewAuthor);
            this.pnlAuthor.Controls.Add(this.dataGridViewAuthor);
            this.pnlAuthor.Location = new System.Drawing.Point(8, 123);
            this.pnlAuthor.Name = "pnlAuthor";
            this.pnlAuthor.Size = new System.Drawing.Size(1190, 539);
            this.pnlAuthor.TabIndex = 6;
            // 
            // groupBoxSearchAuthor
            // 
            this.groupBoxSearchAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSearchAuthor.Controls.Add(this.btnSearchAuthor);
            this.groupBoxSearchAuthor.Controls.Add(this.cmbAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.txtAuthorNameSearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNationalitySearch);
            this.groupBoxSearchAuthor.Controls.Add(this.lblAuthorNameSearch);
            this.groupBoxSearchAuthor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchAuthor.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchAuthor.Name = "groupBoxSearchAuthor";
            this.groupBoxSearchAuthor.Size = new System.Drawing.Size(1190, 111);
            this.groupBoxSearchAuthor.TabIndex = 5;
            this.groupBoxSearchAuthor.TabStop = false;
            this.groupBoxSearchAuthor.Text = "Consulta";
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(563, 43);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(75, 29);
            this.btnSearchAuthor.TabIndex = 9;
            this.btnSearchAuthor.Text = "Buscar";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            // 
            // cmbAuthorNationalitySearch
            // 
            this.cmbAuthorNationalitySearch.FormattingEnabled = true;
            this.cmbAuthorNationalitySearch.Location = new System.Drawing.Point(353, 43);
            this.cmbAuthorNationalitySearch.Name = "cmbAuthorNationalitySearch";
            this.cmbAuthorNationalitySearch.Size = new System.Drawing.Size(190, 29);
            this.cmbAuthorNationalitySearch.TabIndex = 8;
            // 
            // txtAuthorNameSearch
            // 
            this.txtAuthorNameSearch.Location = new System.Drawing.Point(6, 43);
            this.txtAuthorNameSearch.Name = "txtAuthorNameSearch";
            this.txtAuthorNameSearch.Size = new System.Drawing.Size(272, 29);
            this.txtAuthorNameSearch.TabIndex = 7;
            // 
            // lblAuthorNationalitySearch
            // 
            this.lblAuthorNationalitySearch.AutoSize = true;
            this.lblAuthorNationalitySearch.Location = new System.Drawing.Point(353, 19);
            this.lblAuthorNationalitySearch.Name = "lblAuthorNationalitySearch";
            this.lblAuthorNationalitySearch.Size = new System.Drawing.Size(122, 21);
            this.lblAuthorNationalitySearch.TabIndex = 6;
            this.lblAuthorNationalitySearch.Text = "Nacionalidade";
            // 
            // lblAuthorNameSearch
            // 
            this.lblAuthorNameSearch.AutoSize = true;
            this.lblAuthorNameSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAuthorNameSearch.Location = new System.Drawing.Point(6, 19);
            this.lblAuthorNameSearch.Name = "lblAuthorNameSearch";
            this.lblAuthorNameSearch.Size = new System.Drawing.Size(126, 21);
            this.lblAuthorNameSearch.TabIndex = 5;
            this.lblAuthorNameSearch.Text = "Nome do autor";
            // 
            // tabPageClient
            // 
            this.tabPageClient.Controls.Add(this.pnlClient);
            this.tabPageClient.Controls.Add(this.groupBoxSearchClient);
            this.tabPageClient.Location = new System.Drawing.Point(4, 24);
            this.tabPageClient.Name = "tabPageClient";
            this.tabPageClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClient.Size = new System.Drawing.Size(1206, 683);
            this.tabPageClient.TabIndex = 2;
            this.tabPageClient.Text = "Client";
            this.tabPageClient.UseVisualStyleBackColor = true;
            // 
            // tabPagePublishingCompany
            // 
            this.tabPagePublishingCompany.Location = new System.Drawing.Point(4, 24);
            this.tabPagePublishingCompany.Name = "tabPagePublishingCompany";
            this.tabPagePublishingCompany.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePublishingCompany.Size = new System.Drawing.Size(1206, 683);
            this.tabPagePublishingCompany.TabIndex = 3;
            this.tabPagePublishingCompany.Text = "PublishingCompany";
            this.tabPagePublishingCompany.UseVisualStyleBackColor = true;
            // 
            // tabPageTheme
            // 
            this.tabPageTheme.Location = new System.Drawing.Point(4, 24);
            this.tabPageTheme.Name = "tabPageTheme";
            this.tabPageTheme.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTheme.Size = new System.Drawing.Size(1206, 683);
            this.tabPageTheme.TabIndex = 4;
            this.tabPageTheme.Text = "Themes";
            this.tabPageTheme.UseVisualStyleBackColor = true;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Location = new System.Drawing.Point(4, 24);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(1206, 683);
            this.tabPageBook.TabIndex = 5;
            this.tabPageBook.Text = "Book";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridViewAuthor
            // 
            this.dataGridViewAuthor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridViewAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAuthor.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewAuthor.Name = "dataGridViewAuthor";
            this.dataGridViewAuthor.RowTemplate.Height = 25;
            this.dataGridViewAuthor.Size = new System.Drawing.Size(1190, 473);
            this.dataGridViewAuthor.TabIndex = 0;
            // 
            // btnNewAuthor
            // 
            this.btnNewAuthor.BackColor = System.Drawing.Color.White;
            this.btnNewAuthor.BackgroundImage = global::LoanBooks_.Properties.Resources.Add;
            this.btnNewAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewAuthor.Location = new System.Drawing.Point(6, 3);
            this.btnNewAuthor.Name = "btnNewAuthor";
            this.btnNewAuthor.Size = new System.Drawing.Size(40, 40);
            this.btnNewAuthor.TabIndex = 1;
            this.btnNewAuthor.UseVisualStyleBackColor = false;
            // 
            // btnEditAuthor
            // 
            this.btnEditAuthor.BackColor = System.Drawing.Color.White;
            this.btnEditAuthor.BackgroundImage = global::LoanBooks_.Properties.Resources.Edit;
            this.btnEditAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditAuthor.Location = new System.Drawing.Point(52, 3);
            this.btnEditAuthor.Name = "btnEditAuthor";
            this.btnEditAuthor.Size = new System.Drawing.Size(40, 40);
            this.btnEditAuthor.TabIndex = 2;
            this.btnEditAuthor.UseVisualStyleBackColor = false;
            // 
            // btnDeletAuthor
            // 
            this.btnDeletAuthor.BackColor = System.Drawing.Color.White;
            this.btnDeletAuthor.BackgroundImage = global::LoanBooks_.Properties.Resources.Delete;
            this.btnDeletAuthor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeletAuthor.Location = new System.Drawing.Point(98, 3);
            this.btnDeletAuthor.Name = "btnDeletAuthor";
            this.btnDeletAuthor.Size = new System.Drawing.Size(40, 40);
            this.btnDeletAuthor.TabIndex = 3;
            this.btnDeletAuthor.UseVisualStyleBackColor = false;
            // 
            // groupBoxSearchClient
            // 
            this.groupBoxSearchClient.Controls.Add(this.btnSearchClient);
            this.groupBoxSearchClient.Controls.Add(this.txtIdNameSearch);
            this.groupBoxSearchClient.Controls.Add(this.txtClientNameSearch);
            this.groupBoxSearchClient.Controls.Add(this.lblClientId);
            this.groupBoxSearchClient.Controls.Add(this.lblNameClient);
            this.groupBoxSearchClient.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBoxSearchClient.Location = new System.Drawing.Point(8, 6);
            this.groupBoxSearchClient.Name = "groupBoxSearchClient";
            this.groupBoxSearchClient.Size = new System.Drawing.Size(1190, 111);
            this.groupBoxSearchClient.TabIndex = 0;
            this.groupBoxSearchClient.TabStop = false;
            this.groupBoxSearchClient.Text = "Consulta de Cliente";
            // 
            // btnSearchClient
            // 
            this.btnSearchClient.Location = new System.Drawing.Point(563, 43);
            this.btnSearchClient.Name = "btnSearchClient";
            this.btnSearchClient.Size = new System.Drawing.Size(75, 29);
            this.btnSearchClient.TabIndex = 10;
            this.btnSearchClient.Text = "Busca";
            this.btnSearchClient.UseVisualStyleBackColor = true;
            // 
            // txtIdNameSearch
            // 
            this.txtIdNameSearch.Location = new System.Drawing.Point(353, 43);
            this.txtIdNameSearch.Name = "txtIdNameSearch";
            this.txtIdNameSearch.Size = new System.Drawing.Size(190, 29);
            this.txtIdNameSearch.TabIndex = 9;
            // 
            // txtClientNameSearch
            // 
            this.txtClientNameSearch.Location = new System.Drawing.Point(6, 43);
            this.txtClientNameSearch.Name = "txtClientNameSearch";
            this.txtClientNameSearch.Size = new System.Drawing.Size(272, 29);
            this.txtClientNameSearch.TabIndex = 8;
            // 
            // lblClientId
            // 
            this.lblClientId.AutoSize = true;
            this.lblClientId.Location = new System.Drawing.Point(353, 19);
            this.lblClientId.Name = "lblClientId";
            this.lblClientId.Size = new System.Drawing.Size(105, 21);
            this.lblClientId.TabIndex = 7;
            this.lblClientId.Text = "Id do cliente";
            // 
            // lblNameClient
            // 
            this.lblNameClient.AutoSize = true;
            this.lblNameClient.Location = new System.Drawing.Point(6, 19);
            this.lblNameClient.Name = "lblNameClient";
            this.lblNameClient.Size = new System.Drawing.Size(57, 21);
            this.lblNameClient.TabIndex = 6;
            this.lblNameClient.Text = "Nome";
            // 
            // pnlClient
            // 
            this.pnlClient.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClient.Controls.Add(this.button3);
            this.pnlClient.Controls.Add(this.button2);
            this.pnlClient.Controls.Add(this.button1);
            this.pnlClient.Controls.Add(this.dataGridViewClient);
            this.pnlClient.Location = new System.Drawing.Point(8, 123);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(1190, 539);
            this.pnlClient.TabIndex = 1;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(0, 66);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.RowTemplate.Height = 25;
            this.dataGridViewClient.Size = new System.Drawing.Size(1190, 473);
            this.dataGridViewClient.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::LoanBooks_.Properties.Resources.Add;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(26, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(216, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 711);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tab);
            this.Name = "frmPrincipal";
            this.Text = "Biblioteca";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tab.ResumeLayout(false);
            this.tabPageAuthor.ResumeLayout(false);
            this.pnlAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.ResumeLayout(false);
            this.groupBoxSearchAuthor.PerformLayout();
            this.tabPageClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAuthor)).EndInit();
            this.groupBoxSearchClient.ResumeLayout(false);
            this.groupBoxSearchClient.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl tab;
        private TabPage tabPagePrincipal;
        private TabPage tabPageAuthor;
        private StatusStrip statusStrip1;
        private TabPage tabPageClient;
        private TabPage tabPagePublishingCompany;
        private TabPage tabPageTheme;
        private TabPage tabPageBook;
        private GroupBox groupBoxSearchAuthor;
        private Button btnSearchAuthor;
        private ComboBox cmbAuthorNationalitySearch;
        private TextBox txtAuthorNameSearch;
        private Label lblAuthorNationalitySearch;
        private Label lblAuthorNameSearch;
        private Panel pnlAuthor;
        private Button btnDeletAuthor;
        private Button btnEditAuthor;
        private Button btnNewAuthor;
        private DataGridView dataGridViewAuthor;
        private GroupBox groupBoxSearchClient;
        private Button btnSearchClient;
        private TextBox txtIdNameSearch;
        private TextBox txtClientNameSearch;
        private Label lblClientId;
        private Label lblNameClient;
        private Panel pnlClient;
        private DataGridView dataGridViewClient;
        private Button button3;
        private Button button2;
        private Button button1;
    }
}
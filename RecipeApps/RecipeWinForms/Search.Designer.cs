namespace RecipeWinForms
{
    partial class Search
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
            tblMain = new TableLayoutPanel();
            gRecipe = new DataGridView();
            tblSearch = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnNew = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gRecipe).BeginInit();
            tblSearch.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(gRecipe, 0, 1);
            tblMain.Controls.Add(tblSearch, 0, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 86F));
            tblMain.Size = new Size(711, 511);
            tblMain.TabIndex = 0;
            // 
            // gRecipe
            // 
            gRecipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gRecipe.Dock = DockStyle.Fill;
            gRecipe.Location = new Point(4, 75);
            gRecipe.Margin = new Padding(4);
            gRecipe.Name = "gRecipe";
            gRecipe.Size = new Size(703, 432);
            gRecipe.TabIndex = 0;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 4;
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblSearch.Controls.Add(lblSearch, 0, 0);
            tblSearch.Controls.Add(txtSearch, 1, 0);
            tblSearch.Controls.Add(btnSearch, 2, 0);
            tblSearch.Controls.Add(btnNew, 3, 0);
            tblSearch.Location = new Point(4, 4);
            tblSearch.Margin = new Padding(4);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 1;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblSearch.Size = new Size(464, 63);
            tblSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(108, 63);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Recipe Name";
            lblSearch.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Location = new Point(119, 3);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(110, 57);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Location = new Point(235, 3);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(110, 57);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            btnNew.Dock = DockStyle.Fill;
            btnNew.Location = new Point(351, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(110, 57);
            btnNew.TabIndex = 3;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 511);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Search";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gRecipe).EndInit();
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private DataGridView gRecipe;
        private TableLayoutPanel tblSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnNew;
    }
}
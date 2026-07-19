namespace RecipeWinForms
{
    partial class frmCookbook
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
            lstUserName = new ComboBox();
            btnSave = new Button();
            btnDelete = new Button();
            lblCBName = new Label();
            lblUser = new Label();
            lblPrice = new Label();
            lblActive = new Label();
            txtPrice = new TextBox();
            tblDate = new TableLayoutPanel();
            lblDateCreated = new Label();
            dtpDateCookbookCreated = new DateTimePicker();
            chkCookBookStatus = new CheckBox();
            txtCookbookName = new TextBox();
            tblMain.SuspendLayout();
            tblDate.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(lstUserName, 1, 2);
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(btnDelete, 1, 0);
            tblMain.Controls.Add(lblCBName, 0, 1);
            tblMain.Controls.Add(lblUser, 0, 2);
            tblMain.Controls.Add(lblPrice, 0, 3);
            tblMain.Controls.Add(lblActive, 0, 4);
            tblMain.Controls.Add(txtPrice, 1, 3);
            tblMain.Controls.Add(tblDate, 2, 3);
            tblMain.Controls.Add(chkCookBookStatus, 1, 4);
            tblMain.Controls.Add(txtCookbookName, 1, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Margin = new Padding(4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.32258F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 12.9032259F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 13.0645161F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15.8064518F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 42.9032249F));
            tblMain.Size = new Size(850, 620);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(138, 178);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(262, 29);
            lstUserName.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(4, 4);
            btnSave.Margin = new Padding(4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(109, 66);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(139, 4);
            btnDelete.Margin = new Padding(4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(134, 66);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblCBName
            // 
            lblCBName.AutoSize = true;
            lblCBName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCBName.Location = new Point(4, 95);
            lblCBName.Margin = new Padding(4, 0, 4, 0);
            lblCBName.Name = "lblCBName";
            lblCBName.Size = new Size(127, 21);
            lblCBName.TabIndex = 2;
            lblCBName.Text = "Cookbook Name";
            lblCBName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 175);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(3, 256);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(44, 21);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            lblPrice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActive
            // 
            lblActive.AutoSize = true;
            lblActive.Location = new Point(3, 354);
            lblActive.Name = "lblActive";
            lblActive.Size = new Size(52, 21);
            lblActive.TabIndex = 6;
            lblActive.Text = "Active";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(138, 259);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(262, 29);
            txtPrice.TabIndex = 9;
            // 
            // tblDate
            // 
            tblDate.ColumnCount = 1;
            tblDate.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblDate.Controls.Add(lblDateCreated, 0, 0);
            tblDate.Controls.Add(dtpDateCookbookCreated, 0, 1);
            tblDate.Dock = DockStyle.Fill;
            tblDate.Location = new Point(406, 259);
            tblDate.Name = "tblDate";
            tblDate.RowCount = 2;
            tblDate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDate.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDate.Size = new Size(441, 92);
            tblDate.TabIndex = 10;
            // 
            // lblDateCreated
            // 
            lblDateCreated.Anchor = AnchorStyles.Top;
            lblDateCreated.AutoSize = true;
            lblDateCreated.Location = new Point(170, 0);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(100, 21);
            lblDateCreated.TabIndex = 0;
            lblDateCreated.Text = "Date Created";
            // 
            // dtpDateCookbookCreated
            // 
            dtpDateCookbookCreated.Anchor = AnchorStyles.Top;
            dtpDateCookbookCreated.Location = new Point(90, 49);
            dtpDateCookbookCreated.Name = "dtpDateCookbookCreated";
            dtpDateCookbookCreated.Size = new Size(261, 29);
            dtpDateCookbookCreated.TabIndex = 1;
            // 
            // chkCookBookStatus
            // 
            chkCookBookStatus.AutoSize = true;
            chkCookBookStatus.Location = new Point(138, 357);
            chkCookBookStatus.Name = "chkCookBookStatus";
            chkCookBookStatus.Size = new Size(15, 14);
            chkCookBookStatus.TabIndex = 11;
            chkCookBookStatus.UseVisualStyleBackColor = true;
            // 
            // txtCookbookName
            // 
            txtCookbookName.Location = new Point(138, 98);
            txtCookbookName.Name = "txtCookbookName";
            txtCookbookName.Size = new Size(262, 29);
            txtCookbookName.TabIndex = 12;
            // 
            // frmCookbook
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 620);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmCookbook";
            Text = "Cookbook - Suppers On the go";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDate.ResumeLayout(false);
            tblDate.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private Button btnDelete;
        private Label lblCBName;
        private ComboBox lstUserName;
        private Label lblUser;
        private Label lblPrice;
        private Label lblActive;
        private TextBox txtPrice;
        private TableLayoutPanel tblDate;
        private Label lblDateCreated;
        private CheckBox chkCookBookStatus;
        private TextBox txtCookbookName;
        private DateTimePicker dtpDateCookbookCreated;
    }
}
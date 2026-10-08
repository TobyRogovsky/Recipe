namespace RecipeWinForms
{
    partial class frmLogin
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
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblUserID = new Label();
            txtUserID = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(btnLogin, 0, 4);
            tblMain.Controls.Add(lblPassword, 0, 2);
            tblMain.Controls.Add(txtPassword, 0, 3);
            tblMain.Controls.Add(lblUserID, 0, 0);
            tblMain.Controls.Add(txtUserID, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 5;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9999962F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0000019F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(384, 211);
            tblMain.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = true;
            btnLogin.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(3, 171);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 37);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(3, 84);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(111, 32);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(3, 129);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 39);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(3, 0);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(91, 32);
            lblUserID.TabIndex = 0;
            lblUserID.Text = "User ID";
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserID.Location = new Point(3, 45);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(200, 39);
            txtUserID.TabIndex = 3;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 211);
            Controls.Add(tblMain);
            Name = "frmLogin";
            Text = "frmLogin";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblUserID;
        private Label lblPassword;
        private TextBox txtPassword;
        private TextBox txtUserID;
        private Button btnLogin;
    }
}
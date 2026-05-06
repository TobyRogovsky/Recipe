namespace RecipeWinForms
{
    partial class frmRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecipe));
            tblMain = new TableLayoutPanel();
            lstUserName = new ComboBox();
            lblUser = new Label();
            lblCuisine = new Label();
            txtArchivedDate = new TextBox();
            txtPublishedDate = new TextBox();
            lblArchivedDate = new Label();
            lblPublishedDate = new Label();
            lblDraftDate = new Label();
            txtRecipeStatus = new TextBox();
            txtCalories = new TextBox();
            lblCalories = new Label();
            lblRecipeName = new Label();
            lblRecipeStatus = new Label();
            txtRecipeName = new TextBox();
            dtpDraftDate = new DateTimePicker();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            lstCuisineName = new ComboBox();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tblMain.Controls.Add(lstUserName, 1, 7);
            tblMain.Controls.Add(lblUser, 0, 7);
            tblMain.Controls.Add(lblCuisine, 0, 6);
            tblMain.Controls.Add(txtArchivedDate, 1, 5);
            tblMain.Controls.Add(txtPublishedDate, 1, 4);
            tblMain.Controls.Add(lblArchivedDate, 0, 5);
            tblMain.Controls.Add(lblPublishedDate, 0, 4);
            tblMain.Controls.Add(lblDraftDate, 0, 3);
            tblMain.Controls.Add(txtRecipeStatus, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(lblCalories, 0, 1);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblRecipeStatus, 0, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(dtpDraftDate, 1, 3);
            tblMain.Controls.Add(toolStrip1, 1, 8);
            tblMain.Controls.Add(lstCuisineName, 1, 6);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 9;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103687F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1103716F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1137047F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 11.1137047F));
            tblMain.Size = new Size(800, 459);
            tblMain.TabIndex = 0;
            // 
            // lstUserName
            // 
            lstUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(139, 353);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(262, 33);
            lstUserName.TabIndex = 26;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Location = new Point(3, 350);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(130, 51);
            lblUser.TabIndex = 25;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(3, 300);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(130, 50);
            lblCuisine.TabIndex = 23;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtArchivedDate
            // 
            txtArchivedDate.Dock = DockStyle.Fill;
            txtArchivedDate.Location = new Point(139, 253);
            txtArchivedDate.Multiline = true;
            txtArchivedDate.Name = "txtArchivedDate";
            txtArchivedDate.Size = new Size(658, 44);
            txtArchivedDate.TabIndex = 21;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.Dock = DockStyle.Fill;
            txtPublishedDate.Location = new Point(139, 203);
            txtPublishedDate.Multiline = true;
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(658, 44);
            txtPublishedDate.TabIndex = 20;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(3, 250);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(130, 50);
            lblArchivedDate.TabIndex = 15;
            lblArchivedDate.Text = "Archived Date";
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(3, 200);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(130, 50);
            lblPublishedDate.TabIndex = 14;
            lblPublishedDate.Text = "Published Date";
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.Dock = DockStyle.Fill;
            lblDraftDate.Location = new Point(3, 150);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(130, 50);
            lblDraftDate.TabIndex = 13;
            lblDraftDate.Text = "Draft Date";
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(139, 103);
            txtRecipeStatus.Multiline = true;
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(658, 44);
            txtRecipeStatus.TabIndex = 5;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(139, 53);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(658, 44);
            txtCalories.TabIndex = 4;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(3, 50);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(130, 50);
            lblCalories.TabIndex = 2;
            lblCalories.Text = "Calories";
            lblCalories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(130, 50);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(3, 100);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(130, 50);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.Text = "Recipe Status";
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(139, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(658, 44);
            txtRecipeName.TabIndex = 3;
            // 
            // dtpDraftDate
            // 
            dtpDraftDate.Location = new Point(139, 153);
            dtpDraftDate.Name = "dtpDraftDate";
            dtpDraftDate.Size = new Size(262, 29);
            dtpDraftDate.TabIndex = 19;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            toolStrip1.Location = new Point(136, 401);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(664, 58);
            toolStrip1.TabIndex = 22;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(60, 60);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 58);
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(98, 55);
            btnDelete.Text = "Delete";
            // 
            // lstCuisineName
            // 
            lstCuisineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(139, 303);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(262, 33);
            lstCuisineName.TabIndex = 24;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 459);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private TextBox txtCalories;
        private Label lblCalories;
        private Label lblRecipeName;
        private Label lblRecipeStatus;
        private TextBox txtRecipeName;
        private Label lblDraftDate;
        private TextBox txtRecipeStatus;
        private Label lblArchivedDate;
        private Label lblPublishedDate;
        private DateTimePicker dtpDraftDate;
        private TextBox txtArchivedDate;
        private TextBox txtPublishedDate;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private ComboBox lstUserName;
        private Label lblUser;
        private Label lblCuisine;
        private ComboBox lstCuisineName;
    }
}
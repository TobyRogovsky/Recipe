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
            lblArchivedDate = new Label();
            lblPublishedDate = new Label();
            lblDraftDate = new Label();
            txtArchivedDate = new TextBox();
            txtPublishedDate = new TextBox();
            txtRecipeStatus = new TextBox();
            txtCalories = new TextBox();
            lblCalories = new Label();
            lblRecipeName = new Label();
            lblRecipeStatus = new Label();
            txtRecipeName = new TextBox();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            dtpDraftDate = new DateTimePicker();
            tblMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tblMain.Controls.Add(lblArchivedDate, 0, 5);
            tblMain.Controls.Add(lblPublishedDate, 0, 4);
            tblMain.Controls.Add(lblDraftDate, 0, 3);
            tblMain.Controls.Add(txtArchivedDate, 1, 5);
            tblMain.Controls.Add(txtPublishedDate, 1, 4);
            tblMain.Controls.Add(txtRecipeStatus, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(lblCalories, 0, 1);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblRecipeStatus, 0, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Controls.Add(toolStrip1, 1, 6);
            tblMain.Controls.Add(dtpDraftDate, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tblMain.Size = new Size(800, 459);
            tblMain.TabIndex = 0;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(3, 325);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(130, 65);
            lblArchivedDate.TabIndex = 15;
            lblArchivedDate.Text = "Archived Date";
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(3, 260);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(130, 65);
            lblPublishedDate.TabIndex = 14;
            lblPublishedDate.Text = "Published Date";
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.Dock = DockStyle.Fill;
            lblDraftDate.Location = new Point(3, 195);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(130, 65);
            lblDraftDate.TabIndex = 13;
            lblDraftDate.Text = "Draft Date";
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtArchivedDate
            // 
            txtArchivedDate.Dock = DockStyle.Fill;
            txtArchivedDate.Location = new Point(139, 328);
            txtArchivedDate.Multiline = true;
            txtArchivedDate.Name = "txtArchivedDate";
            txtArchivedDate.Size = new Size(658, 59);
            txtArchivedDate.TabIndex = 12;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.Dock = DockStyle.Fill;
            txtPublishedDate.Location = new Point(139, 263);
            txtPublishedDate.Multiline = true;
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(658, 59);
            txtPublishedDate.TabIndex = 10;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(139, 133);
            txtRecipeStatus.Multiline = true;
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(658, 59);
            txtRecipeStatus.TabIndex = 5;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(139, 68);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(658, 59);
            txtCalories.TabIndex = 4;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(3, 65);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(130, 65);
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
            lblRecipeName.Size = new Size(130, 65);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(3, 130);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(130, 65);
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
            txtRecipeName.Size = new Size(658, 59);
            txtRecipeName.TabIndex = 3;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.Fill;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete });
            toolStrip1.Location = new Point(136, 390);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(664, 69);
            toolStrip1.TabIndex = 18;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(47, 66);
            btnSave.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 69);
            // 
            // btnDelete
            // 
            btnDelete.AutoSize = false;
            btnDelete.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 60);
            btnDelete.Text = "Delete";
            // 
            // dtpDraftDate
            // 
            dtpDraftDate.Location = new Point(139, 198);
            dtpDraftDate.Name = "dtpDraftDate";
            dtpDraftDate.Size = new Size(262, 29);
            dtpDraftDate.TabIndex = 19;
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
        private TextBox txtArchivedDate;
        private TextBox txtPublishedDate;
        private TextBox txtRecipeStatus;
        private Label lblArchivedDate;
        private Label lblPublishedDate;
        private ToolStrip toolStrip1;
        private ToolStripButton btnSave;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnDelete;
        private DateTimePicker dtpDraftDate;
    }
}
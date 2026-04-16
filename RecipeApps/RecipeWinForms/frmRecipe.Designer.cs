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
            tblMain = new TableLayoutPanel();
            lblArchivedDate = new Label();
            lblPublishedDate = new Label();
            lblDraftDate = new Label();
            txtArchivedDate = new TextBox();
            txtPublishedDate = new TextBox();
            txtDraftDate = new TextBox();
            txtRecipeStatus = new TextBox();
            txtCalories = new TextBox();
            lblCalories = new Label();
            lblRecipeName = new Label();
            lblRecipeStatus = new Label();
            txtRecipeName = new TextBox();
            lblCuisine = new Label();
            txtCuisine = new TextBox();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tblMain.Controls.Add(txtCuisine, 1, 6);
            tblMain.Controls.Add(lblCuisine, 0, 6);
            tblMain.Controls.Add(lblArchivedDate, 0, 5);
            tblMain.Controls.Add(lblPublishedDate, 0, 4);
            tblMain.Controls.Add(lblDraftDate, 0, 3);
            tblMain.Controls.Add(txtArchivedDate, 1, 5);
            tblMain.Controls.Add(txtPublishedDate, 1, 4);
            tblMain.Controls.Add(txtDraftDate, 1, 3);
            tblMain.Controls.Add(txtRecipeStatus, 1, 2);
            tblMain.Controls.Add(txtCalories, 1, 1);
            tblMain.Controls.Add(lblCalories, 0, 1);
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblRecipeStatus, 0, 2);
            tblMain.Controls.Add(txtRecipeName, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 7;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857151F));
            tblMain.Size = new Size(800, 450);
            tblMain.TabIndex = 0;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.Dock = DockStyle.Fill;
            lblArchivedDate.Location = new Point(3, 320);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(130, 64);
            lblArchivedDate.TabIndex = 15;
            lblArchivedDate.Text = "Archived Date";
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.Dock = DockStyle.Fill;
            lblPublishedDate.Location = new Point(3, 256);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(130, 64);
            lblPublishedDate.TabIndex = 14;
            lblPublishedDate.Text = "Published Date";
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.Dock = DockStyle.Fill;
            lblDraftDate.Location = new Point(3, 192);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(130, 64);
            lblDraftDate.TabIndex = 13;
            lblDraftDate.Text = "Draft Date";
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtArchivedDate
            // 
            txtArchivedDate.Dock = DockStyle.Fill;
            txtArchivedDate.Location = new Point(139, 323);
            txtArchivedDate.Multiline = true;
            txtArchivedDate.Name = "txtArchivedDate";
            txtArchivedDate.Size = new Size(658, 58);
            txtArchivedDate.TabIndex = 12;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.Dock = DockStyle.Fill;
            txtPublishedDate.Location = new Point(139, 259);
            txtPublishedDate.Multiline = true;
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(658, 58);
            txtPublishedDate.TabIndex = 10;
            // 
            // txtDraftDate
            // 
            txtDraftDate.Dock = DockStyle.Fill;
            txtDraftDate.Location = new Point(139, 195);
            txtDraftDate.Multiline = true;
            txtDraftDate.Name = "txtDraftDate";
            txtDraftDate.Size = new Size(658, 58);
            txtDraftDate.TabIndex = 8;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(139, 131);
            txtRecipeStatus.Multiline = true;
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.Size = new Size(658, 58);
            txtRecipeStatus.TabIndex = 5;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(139, 67);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(658, 58);
            txtCalories.TabIndex = 4;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Dock = DockStyle.Fill;
            lblCalories.Location = new Point(3, 64);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(130, 64);
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
            lblRecipeName.Size = new Size(130, 64);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Dock = DockStyle.Fill;
            lblRecipeStatus.Location = new Point(3, 128);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(130, 64);
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
            txtRecipeName.Size = new Size(658, 58);
            txtRecipeName.TabIndex = 3;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Dock = DockStyle.Fill;
            lblCuisine.Location = new Point(3, 384);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(130, 66);
            lblCuisine.TabIndex = 16;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtCuisine
            // 
            txtCuisine.Dock = DockStyle.Fill;
            txtCuisine.Location = new Point(139, 387);
            txtCuisine.Multiline = true;
            txtCuisine.Name = "txtCuisine";
            txtCuisine.Size = new Size(658, 60);
            txtCuisine.TabIndex = 17;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblMain);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
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
        private TextBox txtDraftDate;
        private TextBox txtRecipeStatus;
        private Label lblArchivedDate;
        private Label lblPublishedDate;
        private TextBox txtCuisine;
        private Label lblCuisine;
    }
}
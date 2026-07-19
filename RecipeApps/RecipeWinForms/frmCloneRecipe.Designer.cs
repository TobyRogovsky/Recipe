namespace RecipeWinForms
{
    partial class frmCloneRecipe
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
            lstRecipes = new ComboBox();
            btnClone = new Button();
            tblMain.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(lstRecipes, 0, 0);
            tblMain.Controls.Add(btnClone, 0, 1);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblMain.Size = new Size(444, 141);
            tblMain.TabIndex = 0;
            // 
            // lstRecipes
            // 
            lstRecipes.Anchor = AnchorStyles.Left;
            lstRecipes.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstRecipes.FormattingEnabled = true;
            lstRecipes.Location = new Point(3, 20);
            lstRecipes.Name = "lstRecipes";
            lstRecipes.Size = new Size(438, 29);
            lstRecipes.TabIndex = 0;
            // 
            // btnClone
            // 
            btnClone.Anchor = AnchorStyles.None;
            btnClone.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnClone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClone.Location = new Point(138, 78);
            btnClone.Name = "btnClone";
            btnClone.Size = new Size(168, 55);
            btnClone.TabIndex = 1;
            btnClone.Text = "Clone";
            btnClone.UseVisualStyleBackColor = true;
            // 
            // frmCloneRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 141);
            Controls.Add(tblMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmCloneRecipe";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Clone Recipe";
            tblMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private ComboBox lstRecipes;
        private Button btnClone;
    }
}
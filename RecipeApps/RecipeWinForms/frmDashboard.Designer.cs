namespace RecipeWinForms
{
    partial class frmDashboard
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
            btnMealList = new Button();
            lblHeartyHearth = new Label();
            lblDesc = new Label();
            gData = new DataGridView();
            btnRecipeList = new Button();
            btnCookbookList = new Button();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.Controls.Add(btnMealList, 1, 3);
            tblMain.Controls.Add(lblHeartyHearth, 0, 0);
            tblMain.Controls.Add(lblDesc, 0, 1);
            tblMain.Controls.Add(gData, 0, 2);
            tblMain.Controls.Add(btnRecipeList, 0, 3);
            tblMain.Controls.Add(btnCookbookList, 2, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 19.81982F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 51.2415352F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 29.1196384F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(709, 503);
            tblMain.TabIndex = 0;
            // 
            // btnMealList
            // 
            btnMealList.Location = new Point(135, 376);
            btnMealList.Name = "btnMealList";
            btnMealList.Size = new Size(126, 57);
            btnMealList.TabIndex = 4;
            btnMealList.Text = "Meal List";
            btnMealList.UseVisualStyleBackColor = true;
            // 
            // lblHeartyHearth
            // 
            tblMain.SetColumnSpan(lblHeartyHearth, 3);
            lblHeartyHearth.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeartyHearth.Location = new Point(3, 0);
            lblHeartyHearth.Name = "lblHeartyHearth";
            lblHeartyHearth.Size = new Size(703, 60);
            lblHeartyHearth.TabIndex = 0;
            lblHeartyHearth.Text = "Hearty Hearth Desktop App";
            lblHeartyHearth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDesc
            // 
            lblDesc.Anchor = AnchorStyles.Top;
            tblMain.SetColumnSpan(lblDesc, 3);
            lblDesc.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesc.Location = new Point(3, 60);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(703, 87);
            lblDesc.TabIndex = 1;
            lblDesc.Text = "Welcome to the Hearty Hearth desktop app. In this app, you can create recipes and cookbooks.";
            lblDesc.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gData
            // 
            gData.Anchor = AnchorStyles.Top;
            gData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblMain.SetColumnSpan(gData, 3);
            gData.Location = new Point(86, 150);
            gData.Name = "gData";
            gData.Size = new Size(537, 220);
            gData.TabIndex = 2;
            // 
            // btnRecipeList
            // 
            btnRecipeList.Location = new Point(3, 376);
            btnRecipeList.Name = "btnRecipeList";
            btnRecipeList.Size = new Size(126, 57);
            btnRecipeList.TabIndex = 3;
            btnRecipeList.Text = "Recipe List";
            btnRecipeList.UseVisualStyleBackColor = true;
            // 
            // btnCookbookList
            // 
            btnCookbookList.Location = new Point(267, 376);
            btnCookbookList.Name = "btnCookbookList";
            btnCookbookList.Size = new Size(126, 57);
            btnCookbookList.TabIndex = 5;
            btnCookbookList.Text = "Cookbook List";
            btnCookbookList.UseVisualStyleBackColor = true;
            // 
            // frmDashboard
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 503);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDashboard";
            Text = "Dashboard";
            tblMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblHeartyHearth;
        private Label lblDesc;
        private DataGridView gData;
        private Button btnCookbookList;
        private Button btnMealList;
        private Button btnRecipeList;
    }
}
namespace RecipeWinForms
{
    partial class frmDataMaintenance
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
            btnSave = new Button();
            gData = new DataGridView();
            pnlRadioButtons = new FlowLayoutPanel();
            rbnUsers = new RadioButton();
            rbnIngredients = new RadioButton();
            rbnCourse = new RadioButton();
            rbnCuisine = new RadioButton();
            rbnMeasurement = new RadioButton();
            tblMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gData).BeginInit();
            pnlRadioButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.55701F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.4429855F));
            tblMain.Controls.Add(btnSave, 0, 0);
            tblMain.Controls.Add(gData, 1, 1);
            tblMain.Controls.Add(pnlRadioButtons, 0, 1);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 2;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 9.469699F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 90.5303F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(763, 528);
            tblMain.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.AutoSize = true;
            btnSave.Location = new Point(3, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 36);
            btnSave.TabIndex = 0;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // gData
            // 
            gData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gData.Dock = DockStyle.Fill;
            gData.Location = new Point(198, 53);
            gData.Name = "gData";
            gData.Size = new Size(562, 472);
            gData.TabIndex = 1;
            // 
            // pnlRadioButtons
            // 
            pnlRadioButtons.Controls.Add(rbnUsers);
            pnlRadioButtons.Controls.Add(rbnIngredients);
            pnlRadioButtons.Controls.Add(rbnCourse);
            pnlRadioButtons.Controls.Add(rbnCuisine);
            pnlRadioButtons.Controls.Add(rbnMeasurement);
            pnlRadioButtons.Dock = DockStyle.Fill;
            pnlRadioButtons.FlowDirection = FlowDirection.TopDown;
            pnlRadioButtons.Location = new Point(3, 53);
            pnlRadioButtons.Name = "pnlRadioButtons";
            pnlRadioButtons.Size = new Size(189, 472);
            pnlRadioButtons.TabIndex = 2;
            // 
            // rbnUsers
            // 
            rbnUsers.AutoSize = true;
            rbnUsers.Checked = true;
            rbnUsers.Location = new Point(3, 3);
            rbnUsers.Name = "rbnUsers";
            rbnUsers.Size = new Size(67, 25);
            rbnUsers.TabIndex = 3;
            rbnUsers.TabStop = true;
            rbnUsers.Text = "Users";
            rbnUsers.UseVisualStyleBackColor = true;
            // 
            // rbnIngredients
            // 
            rbnIngredients.AutoSize = true;
            rbnIngredients.Location = new Point(3, 34);
            rbnIngredients.Name = "rbnIngredients";
            rbnIngredients.Size = new Size(106, 25);
            rbnIngredients.TabIndex = 4;
            rbnIngredients.Text = "Ingredients";
            rbnIngredients.UseVisualStyleBackColor = true;
            // 
            // rbnCourse
            // 
            rbnCourse.AutoSize = true;
            rbnCourse.Location = new Point(3, 65);
            rbnCourse.Name = "rbnCourse";
            rbnCourse.Size = new Size(84, 25);
            rbnCourse.TabIndex = 5;
            rbnCourse.Text = "Courses";
            rbnCourse.UseVisualStyleBackColor = true;
            // 
            // rbnCuisine
            // 
            rbnCuisine.AutoSize = true;
            rbnCuisine.Location = new Point(3, 96);
            rbnCuisine.Name = "rbnCuisine";
            rbnCuisine.Size = new Size(79, 25);
            rbnCuisine.TabIndex = 7;
            rbnCuisine.Text = "Cuisine";
            rbnCuisine.UseVisualStyleBackColor = true;
            // 
            // rbnMeasurement
            // 
            rbnMeasurement.AutoSize = true;
            rbnMeasurement.Location = new Point(3, 127);
            rbnMeasurement.Name = "rbnMeasurement";
            rbnMeasurement.Size = new Size(124, 25);
            rbnMeasurement.TabIndex = 8;
            rbnMeasurement.Text = "Measurement";
            rbnMeasurement.UseVisualStyleBackColor = true;
            // 
            // frmDataMaintenance
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 528);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmDataMaintenance";
            Text = "Data Maintenance";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gData).EndInit();
            pnlRadioButtons.ResumeLayout(false);
            pnlRadioButtons.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Button btnSave;
        private DataGridView gData;
        private FlowLayoutPanel pnlRadioButtons;
        private RadioButton rbnUsers;
        private RadioButton rbnIngredients;
        private RadioButton rbnCourse;
        private RadioButton rbnCuisine;
        private RadioButton rbnMeasurement;
    }
}
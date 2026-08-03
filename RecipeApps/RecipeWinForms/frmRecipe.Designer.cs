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
            tbChildRecords = new TabControl();
            tbIngredients = new TabPage();
            tblIngredients = new TableLayoutPanel();
            btnSaveIngredient = new Button();
            gIngredients = new DataGridView();
            tbSteps = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnSaveSteps = new Button();
            gSteps = new DataGridView();
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
            lstCuisineName = new ComboBox();
            toolStrip1 = new ToolStrip();
            btnSave = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnDelete = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            btnChangeStatus = new ToolStripButton();
            dtpDraftDate = new DateTimePicker();
            tblMain.SuspendLayout();
            tbChildRecords.SuspendLayout();
            tbIngredients.SuspendLayout();
            tblIngredients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).BeginInit();
            tbSteps.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.AutoScroll = true;
            tblMain.ColumnCount = 2;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83F));
            tblMain.Controls.Add(tbChildRecords, 0, 9);
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
            tblMain.Controls.Add(lstCuisineName, 1, 6);
            tblMain.Controls.Add(toolStrip1, 1, 8);
            tblMain.Controls.Add(dtpDraftDate, 1, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 10;
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle());
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(988, 566);
            tblMain.TabIndex = 0;
            // 
            // tbChildRecords
            // 
            tblMain.SetColumnSpan(tbChildRecords, 2);
            tbChildRecords.Controls.Add(tbIngredients);
            tbChildRecords.Controls.Add(tbSteps);
            tbChildRecords.Dock = DockStyle.Fill;
            tbChildRecords.Location = new Point(3, 322);
            tbChildRecords.Name = "tbChildRecords";
            tbChildRecords.SelectedIndex = 0;
            tbChildRecords.Size = new Size(982, 241);
            tbChildRecords.TabIndex = 28;
            // 
            // tbIngredients
            // 
            tbIngredients.Controls.Add(tblIngredients);
            tbIngredients.Location = new Point(4, 30);
            tbIngredients.Name = "tbIngredients";
            tbIngredients.Padding = new Padding(3);
            tbIngredients.Size = new Size(974, 207);
            tbIngredients.TabIndex = 0;
            tbIngredients.Text = "Ingredients";
            tbIngredients.UseVisualStyleBackColor = true;
            // 
            // tblIngredients
            // 
            tblIngredients.ColumnCount = 1;
            tblIngredients.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 969F));
            tblIngredients.Controls.Add(btnSaveIngredient, 0, 0);
            tblIngredients.Controls.Add(gIngredients, 0, 1);
            tblIngredients.Dock = DockStyle.Fill;
            tblIngredients.Location = new Point(3, 3);
            tblIngredients.Name = "tblIngredients";
            tblIngredients.RowCount = 2;
            tblIngredients.RowStyles.Add(new RowStyle());
            tblIngredients.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblIngredients.Size = new Size(968, 201);
            tblIngredients.TabIndex = 0;
            // 
            // btnSaveIngredient
            // 
            btnSaveIngredient.AutoSize = true;
            btnSaveIngredient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSaveIngredient.Location = new Point(3, 3);
            btnSaveIngredient.Name = "btnSaveIngredient";
            btnSaveIngredient.Size = new Size(128, 31);
            btnSaveIngredient.TabIndex = 0;
            btnSaveIngredient.Text = "Save Ingredient";
            btnSaveIngredient.UseVisualStyleBackColor = true;
            // 
            // gIngredients
            // 
            gIngredients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gIngredients.Dock = DockStyle.Fill;
            gIngredients.Location = new Point(3, 40);
            gIngredients.Name = "gIngredients";
            gIngredients.Size = new Size(963, 158);
            gIngredients.TabIndex = 1;
            // 
            // tbSteps
            // 
            tbSteps.Controls.Add(tableLayoutPanel1);
            tbSteps.Location = new Point(4, 30);
            tbSteps.Name = "tbSteps";
            tbSteps.Padding = new Padding(3);
            tbSteps.Size = new Size(974, 207);
            tbSteps.TabIndex = 1;
            tbSteps.Text = "Steps";
            tbSteps.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(btnSaveSteps, 0, 0);
            tableLayoutPanel1.Controls.Add(gSteps, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6153851F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85.38461F));
            tableLayoutPanel1.Size = new Size(968, 201);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnSaveSteps
            // 
            btnSaveSteps.AutoSize = true;
            btnSaveSteps.Location = new Point(3, 3);
            btnSaveSteps.Name = "btnSaveSteps";
            btnSaveSteps.Size = new Size(194, 23);
            btnSaveSteps.TabIndex = 1;
            btnSaveSteps.Text = "Save Steps";
            btnSaveSteps.UseVisualStyleBackColor = true;
            // 
            // gSteps
            // 
            gSteps.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gSteps.Dock = DockStyle.Fill;
            gSteps.Location = new Point(3, 32);
            gSteps.Name = "gSteps";
            gSteps.ScrollBars = ScrollBars.Vertical;
            gSteps.Size = new Size(962, 166);
            gSteps.TabIndex = 2;
            // 
            // lstUserName
            // 
            lstUserName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstUserName.FormattingEnabled = true;
            lstUserName.Location = new Point(170, 258);
            lstUserName.Name = "lstUserName";
            lstUserName.Size = new Size(262, 33);
            lstUserName.TabIndex = 26;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(3, 255);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(42, 21);
            lblUser.TabIndex = 25;
            lblUser.Text = "User";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCuisine
            // 
            lblCuisine.AutoSize = true;
            lblCuisine.Location = new Point(3, 216);
            lblCuisine.Name = "lblCuisine";
            lblCuisine.Size = new Size(61, 21);
            lblCuisine.TabIndex = 23;
            lblCuisine.Text = "Cuisine";
            lblCuisine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtArchivedDate
            // 
            txtArchivedDate.Dock = DockStyle.Fill;
            txtArchivedDate.Location = new Point(170, 183);
            txtArchivedDate.Multiline = true;
            txtArchivedDate.Name = "txtArchivedDate";
            txtArchivedDate.ReadOnly = true;
            txtArchivedDate.Size = new Size(815, 30);
            txtArchivedDate.TabIndex = 21;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.Dock = DockStyle.Fill;
            txtPublishedDate.Location = new Point(170, 144);
            txtPublishedDate.Multiline = true;
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.ReadOnly = true;
            txtPublishedDate.Size = new Size(815, 33);
            txtPublishedDate.TabIndex = 20;
            // 
            // lblArchivedDate
            // 
            lblArchivedDate.AutoSize = true;
            lblArchivedDate.Location = new Point(3, 180);
            lblArchivedDate.Name = "lblArchivedDate";
            lblArchivedDate.Size = new Size(107, 21);
            lblArchivedDate.TabIndex = 15;
            lblArchivedDate.Text = "Archived Date";
            lblArchivedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublishedDate
            // 
            lblPublishedDate.AutoSize = true;
            lblPublishedDate.Location = new Point(3, 141);
            lblPublishedDate.Name = "lblPublishedDate";
            lblPublishedDate.Size = new Size(114, 21);
            lblPublishedDate.TabIndex = 14;
            lblPublishedDate.Text = "Published Date";
            lblPublishedDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDraftDate
            // 
            lblDraftDate.AutoSize = true;
            lblDraftDate.Location = new Point(3, 106);
            lblDraftDate.Name = "lblDraftDate";
            lblDraftDate.Size = new Size(81, 21);
            lblDraftDate.TabIndex = 13;
            lblDraftDate.Text = "Draft Date";
            lblDraftDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeStatus
            // 
            txtRecipeStatus.Dock = DockStyle.Fill;
            txtRecipeStatus.Location = new Point(170, 72);
            txtRecipeStatus.Multiline = true;
            txtRecipeStatus.Name = "txtRecipeStatus";
            txtRecipeStatus.ReadOnly = true;
            txtRecipeStatus.Size = new Size(815, 31);
            txtRecipeStatus.TabIndex = 5;
            // 
            // txtCalories
            // 
            txtCalories.Dock = DockStyle.Fill;
            txtCalories.Location = new Point(170, 37);
            txtCalories.Multiline = true;
            txtCalories.Name = "txtCalories";
            txtCalories.Size = new Size(815, 29);
            txtCalories.TabIndex = 4;
            // 
            // lblCalories
            // 
            lblCalories.AutoSize = true;
            lblCalories.Location = new Point(3, 34);
            lblCalories.Name = "lblCalories";
            lblCalories.Size = new Size(66, 21);
            lblCalories.TabIndex = 2;
            lblCalories.Text = "Calories";
            lblCalories.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Location = new Point(3, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(102, 21);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.Text = "Recipe Name";
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRecipeStatus
            // 
            lblRecipeStatus.AutoSize = true;
            lblRecipeStatus.Location = new Point(3, 69);
            lblRecipeStatus.Name = "lblRecipeStatus";
            lblRecipeStatus.Size = new Size(102, 21);
            lblRecipeStatus.TabIndex = 1;
            lblRecipeStatus.Text = "Recipe Status";
            lblRecipeStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Dock = DockStyle.Fill;
            txtRecipeName.Location = new Point(170, 3);
            txtRecipeName.Multiline = true;
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new Size(815, 28);
            txtRecipeName.TabIndex = 3;
            // 
            // lstCuisineName
            // 
            lstCuisineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstCuisineName.FormattingEnabled = true;
            lstCuisineName.Location = new Point(170, 219);
            lstCuisineName.Name = "lstCuisineName";
            lstCuisineName.Size = new Size(262, 33);
            lstCuisineName.TabIndex = 24;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnSave, toolStripSeparator1, btnDelete, toolStripSeparator2, btnChangeStatus });
            toolStrip1.Location = new Point(167, 294);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(651, 25);
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
            toolStripSeparator1.Size = new Size(6, 25);
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
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 25);
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnChangeStatus.Image = (Image)resources.GetObject("btnChangeStatus.Image");
            btnChangeStatus.ImageTransparentColor = Color.Magenta;
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(87, 22);
            btnChangeStatus.Text = "Change Status";
            // 
            // dtpDraftDate
            // 
            dtpDraftDate.Location = new Point(170, 109);
            dtpDraftDate.Name = "dtpDraftDate";
            dtpDraftDate.Size = new Size(262, 29);
            dtpDraftDate.TabIndex = 19;
            // 
            // frmRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 566);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MinimumSize = new Size(800, 600);
            Name = "frmRecipe";
            Text = "Recipe";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tbChildRecords.ResumeLayout(false);
            tbIngredients.ResumeLayout(false);
            tblIngredients.ResumeLayout(false);
            tblIngredients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gIngredients).EndInit();
            tbSteps.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gSteps).EndInit();
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
        private TabControl tbChildRecords;
        private TabPage tbIngredients;
        private TableLayoutPanel tblIngredients;
        private Button btnSaveIngredient;
        private TabPage tbSteps;
        private DataGridView gIngredients;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnSaveSteps;
        private DataGridView gSteps;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton btnChangeStatus;
    }
}
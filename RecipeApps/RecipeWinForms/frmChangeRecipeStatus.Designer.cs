namespace RecipeWinForms
{
    partial class frmChangeRecipeStatus
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
            lblRecipeName = new Label();
            lblCurrentStatus = new Label();
            lblStatusDates = new Label();
            tblDates = new TableLayoutPanel();
            lblDrafted = new Label();
            lblPublished = new Label();
            lblArchived = new Label();
            txtDraftDate = new TextBox();
            txtPublishedDate = new TextBox();
            txtArchivedDate = new TextBox();
            btnDraft = new Button();
            btnPublish = new Button();
            btnArchive = new Button();
            tblMain.SuspendLayout();
            tblDates.SuspendLayout();
            SuspendLayout();
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 4;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblMain.Controls.Add(lblRecipeName, 0, 0);
            tblMain.Controls.Add(lblCurrentStatus, 1, 1);
            tblMain.Controls.Add(lblStatusDates, 0, 2);
            tblMain.Controls.Add(tblDates, 1, 2);
            tblMain.Controls.Add(btnDraft, 1, 3);
            tblMain.Controls.Add(btnPublish, 2, 3);
            tblMain.Controls.Add(btnArchive, 3, 3);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 4;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 22.2222214F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 22.0370369F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 25.1851845F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 30.37037F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblMain.Size = new Size(767, 540);
            tblMain.TabIndex = 0;
            // 
            // lblRecipeName
            // 
            tblMain.SetColumnSpan(lblRecipeName, 4);
            lblRecipeName.Dock = DockStyle.Fill;
            lblRecipeName.Location = new Point(3, 3);
            lblRecipeName.Margin = new Padding(3);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new Size(761, 114);
            lblRecipeName.TabIndex = 0;
            lblRecipeName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentStatus
            // 
            tblMain.SetColumnSpan(lblCurrentStatus, 2);
            lblCurrentStatus.Dock = DockStyle.Fill;
            lblCurrentStatus.Location = new Point(194, 123);
            lblCurrentStatus.Margin = new Padding(3);
            lblCurrentStatus.Name = "lblCurrentStatus";
            lblCurrentStatus.Size = new Size(376, 113);
            lblCurrentStatus.TabIndex = 1;
            lblCurrentStatus.Text = "Current Status:";
            lblCurrentStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatusDates
            // 
            lblStatusDates.AutoSize = true;
            lblStatusDates.Dock = DockStyle.Fill;
            lblStatusDates.Location = new Point(3, 242);
            lblStatusDates.Margin = new Padding(3, 3, 3, 0);
            lblStatusDates.Name = "lblStatusDates";
            lblStatusDates.Size = new Size(185, 133);
            lblStatusDates.TabIndex = 2;
            lblStatusDates.Text = "Status Dates";
            lblStatusDates.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tblDates
            // 
            tblDates.ColumnCount = 3;
            tblMain.SetColumnSpan(tblDates, 3);
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDates.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tblDates.Controls.Add(lblDrafted, 0, 0);
            tblDates.Controls.Add(lblPublished, 1, 0);
            tblDates.Controls.Add(lblArchived, 2, 0);
            tblDates.Controls.Add(txtDraftDate, 0, 1);
            tblDates.Controls.Add(txtPublishedDate, 1, 1);
            tblDates.Controls.Add(txtArchivedDate, 2, 1);
            tblDates.Dock = DockStyle.Fill;
            tblDates.Location = new Point(194, 242);
            tblDates.Name = "tblDates";
            tblDates.RowCount = 2;
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDates.Size = new Size(570, 130);
            tblDates.TabIndex = 3;
            // 
            // lblDrafted
            // 
            lblDrafted.AutoSize = true;
            lblDrafted.Dock = DockStyle.Fill;
            lblDrafted.Location = new Point(3, 0);
            lblDrafted.Name = "lblDrafted";
            lblDrafted.Size = new Size(184, 65);
            lblDrafted.TabIndex = 0;
            lblDrafted.Text = "Drafted";
            lblDrafted.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPublished
            // 
            lblPublished.AutoSize = true;
            lblPublished.Dock = DockStyle.Fill;
            lblPublished.Location = new Point(193, 0);
            lblPublished.Name = "lblPublished";
            lblPublished.Size = new Size(184, 65);
            lblPublished.TabIndex = 1;
            lblPublished.Text = "Published";
            lblPublished.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblArchived
            // 
            lblArchived.AutoSize = true;
            lblArchived.Dock = DockStyle.Fill;
            lblArchived.Location = new Point(383, 0);
            lblArchived.Name = "lblArchived";
            lblArchived.Size = new Size(184, 65);
            lblArchived.TabIndex = 2;
            lblArchived.Text = "Archived";
            lblArchived.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtDraftDate
            // 
            txtDraftDate.Location = new Point(3, 68);
            txtDraftDate.Name = "txtDraftDate";
            txtDraftDate.Size = new Size(184, 29);
            txtDraftDate.TabIndex = 3;
            // 
            // txtPublishedDate
            // 
            txtPublishedDate.Location = new Point(193, 68);
            txtPublishedDate.Name = "txtPublishedDate";
            txtPublishedDate.Size = new Size(184, 29);
            txtPublishedDate.TabIndex = 4;
            // 
            // txtArchivedDate
            // 
            txtArchivedDate.Location = new Point(383, 68);
            txtArchivedDate.Name = "txtArchivedDate";
            txtArchivedDate.Size = new Size(184, 29);
            txtArchivedDate.TabIndex = 5;
            // 
            // btnDraft
            // 
            btnDraft.AutoSize = true;
            btnDraft.Location = new Point(194, 378);
            btnDraft.Name = "btnDraft";
            btnDraft.Size = new Size(75, 31);
            btnDraft.TabIndex = 4;
            btnDraft.Text = "Draft";
            btnDraft.UseVisualStyleBackColor = true;
            // 
            // btnPublish
            // 
            btnPublish.AutoSize = true;
            btnPublish.Location = new Point(385, 378);
            btnPublish.Name = "btnPublish";
            btnPublish.Size = new Size(75, 31);
            btnPublish.TabIndex = 5;
            btnPublish.Text = "Publish";
            btnPublish.UseVisualStyleBackColor = true;
            // 
            // btnArchive
            // 
            btnArchive.AutoSize = true;
            btnArchive.Location = new Point(576, 378);
            btnArchive.Name = "btnArchive";
            btnArchive.Size = new Size(75, 31);
            btnArchive.TabIndex = 6;
            btnArchive.Text = "Archive";
            btnArchive.UseVisualStyleBackColor = true;
            // 
            // frmChangeRecipeStatus
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(767, 540);
            Controls.Add(tblMain);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "frmChangeRecipeStatus";
            Text = "Recipe - Change Status";
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tblDates.ResumeLayout(false);
            tblDates.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblMain;
        private Label lblRecipeName;
        private Label lblCurrentStatus;
        private Label lblStatusDates;
        private TableLayoutPanel tblDates;
        private Label lblDrafted;
        private Label lblPublished;
        private Label lblArchived;
        private TextBox txtDraftDate;
        private TextBox txtPublishedDate;
        private TextBox txtArchivedDate;
        private Button btnDraft;
        private Button btnPublish;
        private Button btnArchive;
    }
}
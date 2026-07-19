namespace RecipeWinForms
{
    partial class frmMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnuMain = new MenuStrip();
            mnuFile = new ToolStripMenuItem();
            mnuDashboard = new ToolStripMenuItem();
            recipesToolStripMenuItem = new ToolStripMenuItem();
            mnuRecipeList = new ToolStripMenuItem();
            mnuRecipeNew = new ToolStripMenuItem();
            mnuCloneRecipe = new ToolStripMenuItem();
            mnuMeals = new ToolStripMenuItem();
            mnuMealList = new ToolStripMenuItem();
            mnuCookbooks = new ToolStripMenuItem();
            mnuCookbookList = new ToolStripMenuItem();
            mnuCookbookNew = new ToolStripMenuItem();
            mnuAutoCreate = new ToolStripMenuItem();
            mnuDataMaintenance = new ToolStripMenuItem();
            mnuEditData = new ToolStripMenuItem();
            mnuWindows = new ToolStripMenuItem();
            mnuTile = new ToolStripMenuItem();
            mnuCascade = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tsMain = new ToolStrip();
            tsbTab = new ToolStripButton();
            mnuMain.SuspendLayout();
            tsMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuFile, recipesToolStripMenuItem, mnuMeals, mnuCookbooks, mnuDataMaintenance, mnuWindows });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 29);
            mnuMain.TabIndex = 0;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            mnuFile.DropDownItems.AddRange(new ToolStripItem[] { mnuDashboard });
            mnuFile.Font = new Font("Segoe UI", 12F);
            mnuFile.Name = "mnuFile";
            mnuFile.Size = new Size(46, 25);
            mnuFile.Text = "File";
            // 
            // mnuDashboard
            // 
            mnuDashboard.Name = "mnuDashboard";
            mnuDashboard.Size = new Size(156, 26);
            mnuDashboard.Text = "Dashboard";
            // 
            // recipesToolStripMenuItem
            // 
            recipesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuRecipeList, mnuRecipeNew, mnuCloneRecipe });
            recipesToolStripMenuItem.Font = new Font("Segoe UI", 12F);
            recipesToolStripMenuItem.Name = "recipesToolStripMenuItem";
            recipesToolStripMenuItem.Size = new Size(75, 25);
            recipesToolStripMenuItem.Text = "Recipes";
            // 
            // mnuRecipeList
            // 
            mnuRecipeList.Name = "mnuRecipeList";
            mnuRecipeList.Size = new Size(182, 26);
            mnuRecipeList.Text = "List";
            // 
            // mnuRecipeNew
            // 
            mnuRecipeNew.Name = "mnuRecipeNew";
            mnuRecipeNew.Size = new Size(182, 26);
            mnuRecipeNew.Text = "New Recipe";
            // 
            // mnuCloneRecipe
            // 
            mnuCloneRecipe.Name = "mnuCloneRecipe";
            mnuCloneRecipe.Size = new Size(182, 26);
            mnuCloneRecipe.Text = "Clone a Recipe";
            // 
            // mnuMeals
            // 
            mnuMeals.DropDownItems.AddRange(new ToolStripItem[] { mnuMealList });
            mnuMeals.Font = new Font("Segoe UI", 12F);
            mnuMeals.Name = "mnuMeals";
            mnuMeals.Size = new Size(63, 25);
            mnuMeals.Text = "Meals";
            // 
            // mnuMealList
            // 
            mnuMealList.Name = "mnuMealList";
            mnuMealList.Size = new Size(104, 26);
            mnuMealList.Text = "List";
            // 
            // mnuCookbooks
            // 
            mnuCookbooks.DropDownItems.AddRange(new ToolStripItem[] { mnuCookbookList, mnuCookbookNew, mnuAutoCreate });
            mnuCookbooks.Font = new Font("Segoe UI", 12F);
            mnuCookbooks.Name = "mnuCookbooks";
            mnuCookbooks.Size = new Size(100, 25);
            mnuCookbooks.Text = "Cookbooks";
            // 
            // mnuCookbookList
            // 
            mnuCookbookList.Name = "mnuCookbookList";
            mnuCookbookList.Size = new Size(187, 26);
            mnuCookbookList.Text = "List";
            // 
            // mnuCookbookNew
            // 
            mnuCookbookNew.Name = "mnuCookbookNew";
            mnuCookbookNew.Size = new Size(187, 26);
            mnuCookbookNew.Text = "New Cookbook";
            // 
            // mnuAutoCreate
            // 
            mnuAutoCreate.Name = "mnuAutoCreate";
            mnuAutoCreate.Size = new Size(187, 26);
            mnuAutoCreate.Text = "Auto Create";
            // 
            // mnuDataMaintenance
            // 
            mnuDataMaintenance.DropDownItems.AddRange(new ToolStripItem[] { mnuEditData });
            mnuDataMaintenance.Font = new Font("Segoe UI", 12F);
            mnuDataMaintenance.Name = "mnuDataMaintenance";
            mnuDataMaintenance.Size = new Size(147, 25);
            mnuDataMaintenance.Text = "Data Maintenance";
            // 
            // mnuEditData
            // 
            mnuEditData.Name = "mnuEditData";
            mnuEditData.Size = new Size(142, 26);
            mnuEditData.Text = "Edit Data";
            // 
            // mnuWindows
            // 
            mnuWindows.DropDownItems.AddRange(new ToolStripItem[] { mnuTile, mnuCascade });
            mnuWindows.Font = new Font("Segoe UI", 12F);
            mnuWindows.Name = "mnuWindows";
            mnuWindows.Size = new Size(87, 25);
            mnuWindows.Text = "Windows";
            // 
            // mnuTile
            // 
            mnuTile.Name = "mnuTile";
            mnuTile.Size = new Size(137, 26);
            mnuTile.Text = "Tile";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Size = new Size(137, 26);
            mnuCascade.Text = "Cascade";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tsMain
            // 
            tsMain.Items.AddRange(new ToolStripItem[] { tsbTab });
            tsMain.Location = new Point(0, 29);
            tsMain.Name = "tsMain";
            tsMain.Size = new Size(800, 25);
            tsMain.TabIndex = 2;
            tsMain.Text = "toolStrip1";
            // 
            // tsbTab
            // 
            tsbTab.DisplayStyle = ToolStripItemDisplayStyle.Text;
            tsbTab.Image = (Image)resources.GetObject("tsbTab.Image");
            tsbTab.ImageTransparentColor = Color.Magenta;
            tsbTab.Name = "tsbTab";
            tsbTab.Size = new Size(23, 22);
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tsMain);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Name = "frmMain";
            Text = "Hearty Hearth - Main";
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            tsMain.ResumeLayout(false);
            tsMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFile;
        private ToolStripMenuItem recipesToolStripMenuItem;
        private ToolStripMenuItem mnuMeals;
        private ToolStripMenuItem mnuCookbooks;
        private ToolStripMenuItem mnuDataMaintenance;
        private ToolStripMenuItem mnuWindows;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem mnuDashboard;
        private ToolStripMenuItem mnuRecipeList;
        private ToolStripMenuItem mnuRecipeNew;
        private ToolStripMenuItem mnuCloneRecipe;
        private ToolStripMenuItem mnuMealList;
        private ToolStripMenuItem mnuCookbookList;
        private ToolStripMenuItem mnuCookbookNew;
        private ToolStripMenuItem mnuAutoCreate;
        private ToolStripMenuItem mnuEditData;
        private ToolStripMenuItem mnuTile;
        private ToolStripMenuItem mnuCascade;
        private ToolStrip tsMain;
        private ToolStripButton tsbTab;
    }
}
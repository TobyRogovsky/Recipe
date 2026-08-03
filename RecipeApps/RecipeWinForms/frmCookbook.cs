using CPUFramework;
using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtCookbook = new();
        DataTable dtCookbookRecipe = new();

        BindingSource bindsource = new();

        public frmCookbook()
        {
            InitializeComponent();
            SetupCookbookRecipeGrid();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveRecipes.Click += BtnSaveRecipes_Click;
            gCookbookRecipe.CellClick += GCookbookRecipe_CellClick;            
        }

        public void ShowForm(int cookbookID)
        {
            dtCookbook = Cookbook.Load(cookbookID);
            bindsource.DataSource = dtCookbook;
            DataTable dtUser = DataMaintenance.GetDataList("User");
            if (dtUser.Rows.Count == 0)
            {
                throw new Exception("At least one user must be created before adding a cookbook.");
            }
            if (cookbookID == 0)
            {
                dtCookbook.Rows[0]["UserID"] = dtUser.Rows[0]["UserID"];
            }
            if (cookbookID == 0)
            {
                dtCookbook.Rows[0]["UserID"] =
                    dtUser.Rows[0]["UserID"];
            }            
            WinFormsUtility.SetControlBinding(chkCookbookStatus, bindsource);
            WinFormsUtility.SetControlBinding(txtCookbookName,bindsource);
            WinFormsUtility.SetControlBinding(txtPrice,bindsource);
            WinFormsUtility.SetListBinding(lstUserName,dtUser,dtCookbook, "User");
            WinFormsUtility.SetControlBinding(dtpDateCookbookCreated,bindsource);
            LoadCookbookRecipes(cookbookID);
            SetExistingCookbookControls(cookbookID != 0);
            this.Tag = cookbookID;
        }

        private void SetupCookbookRecipeGrid()
        {
            gCookbookRecipe.AutoGenerateColumns = false;
            gCookbookRecipe.Columns.Clear();
            DataTable dtRecipe = Recipe.GetListOfRecipes("");
            WinFormsUtility.AddComboBoxToGrid(gCookbookRecipe, dtRecipe, "Recipe", "RecipeName", 0);
            DataGridViewTextBoxColumn sequenceColumn = new();
            sequenceColumn.Name = "RecipeSequence";
            sequenceColumn.HeaderText = "Sequence";
            sequenceColumn.DataPropertyName = "RecipeSequence";
            sequenceColumn.Width = 80;
            gCookbookRecipe.Columns.Add(sequenceColumn);
            WinFormsUtility.AddDeleteButtonToGrid(gCookbookRecipe, "Delete");
            gCookbookRecipe.AllowUserToAddRows = true;
        }

        private void SetExistingCookbookControls(bool enabled)
        {
            btnDelete.Enabled = enabled;
            btnSaveRecipes.Enabled = enabled;
            gCookbookRecipe.Enabled = enabled;
        }

        private void LoadCookbookRecipes(int cookbookID)
        {
            dtCookbookRecipe =Cookbook.GetCookbookRecipe(cookbookID);
            DataTable dtRecipe = Cookbook.GetRecipeList();
            DataGridViewComboBoxColumn recipeColumn =(DataGridViewComboBoxColumn)gCookbookRecipe.Columns["Recipe"]!;
            recipeColumn.DataSource = dtRecipe;
            gCookbookRecipe.DataSource = dtCookbookRecipe;
        }

        private void RefreshCookbookList()
        {
            frmCookbookList? cookbooklist = ((frmMain)MdiParent!).GetOpenForm<frmCookbookList>();

            if (cookbooklist != null)
            {
                cookbooklist.LoadList();
            }
        }

        private bool Save()
        {
            bool saved = false;

            Application.UseWaitCursor = true;

            try
            {
                bindsource.EndEdit();
                int cookbookID = Cookbook.Save(dtCookbook);             
                this.Tag = cookbookID;
                RefreshCookbookList();
                bindsource.ResetBindings(false);
                SetExistingCookbookControls(cookbookID != 0);
                MessageBox.Show("Cookbook saved successfully.","Cookbook");
                saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message, "Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

            return saved;
        }

        private void ClickCookbookRecipe(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (gCookbookRecipe.Columns[e.ColumnIndex].Name != "Delete")
            {
                return;
            }

            DataRowView? rowView =
                gCookbookRecipe.Rows[e.RowIndex].DataBoundItem as DataRowView;

            if (rowView == null)
            {
                return;
            }

            int cookbookRecipeID = rowView.Row["CookbookRecipeID"] == DBNull.Value
                ? 0
                : Convert.ToInt32(rowView.Row["CookbookRecipeID"]);

            try
            {
                if (cookbookRecipeID != 0)
                {
                    Cookbook.DeleteCookbookRecipe(cookbookRecipeID);
                }

                rowView.Row.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cookbook Recipes");
            }
        }

        private void SaveCookbookRecipes()
        {
            Application.UseWaitCursor = true;
            try
            {
                gCookbookRecipe.EndEdit();
                int cookbookID =
                    SQLUtility.GetValueFromFirstRowAsInt(dtCookbook,"CookbookID");
                if (cookbookID == 0)
                {
                    MessageBox.Show("Save the cookbook before adding recipes.","Cookbook");
                    return;
                }
                Cookbook.SaveCookbookRecipes(dtCookbookRecipe, cookbookID);
                MessageBox.Show("Cookbook recipes saved successfully.","Cookbook");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Cookbook Recipes");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void Delete()
        {
            DialogResult response = MessageBox.Show("Are you sure you want to delete this record?","Cookbook",MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Cookbook.Delete(dtCookbook);
                RefreshCookbookList();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Cookbook");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void GCookbookRecipe_CellClick(object? sender,DataGridViewCellEventArgs e)
        {
            ClickCookbookRecipe(e);
        }
        

        private void BtnSaveRecipes_Click(object? sender,EventArgs e)
        {
            SaveCookbookRecipes();
        }

        private void BtnDelete_Click(object? sender,EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender,EventArgs e)
        {
            Save();
        }
    }
}
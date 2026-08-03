using CPUFramework;
using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new();
        DataTable dtinstruction = new();
        DataTable dtrecipeingredient = new();
        BindingSource bindsource = new();

        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredients.CellClick += GIngredients_CellClick;
            gSteps.CellClick += GSteps_CellClick;            
        }

        public void ShowForm(int recipeID)
        {
            dtrecipe = Recipe.Load(recipeID);
            bindsource.DataSource = dtrecipe;
            if (recipeID == 0)
            {
                DataTable dtCuisine = DataMaintenance.GetDataList("Cuisine");
                DataTable dtUser = DataMaintenance.GetDataList("User");
                dtrecipe.Rows[0]["CuisineID"] = dtCuisine.Rows[0]["CuisineID"];
                dtrecipe.Rows[0]["UserID"] = dtUser.Rows[0]["UserID"];
            }

            BindRecipeControls();
            BindRecipeLists();            
            SetExistingRecipeControls(recipeID != 0);
            if (recipeID != 0)
            {
                LoadRecipeIngredients();
                LoadInstructions();
            }
        }

        private void BindRecipeControls()
        {
            WinFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WinFormsUtility.SetControlBinding(txtCalories, bindsource);
            WinFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            WinFormsUtility.SetControlBinding(dtpDraftDate, bindsource);
            WinFormsUtility.SetControlBinding(txtPublishedDate, bindsource);
            WinFormsUtility.SetControlBinding(txtArchivedDate, bindsource);
        }

        private void LoadRecipeIngredients()
        {
            int recipeID = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID");
            dtrecipeingredient = Recipe.GetRecipeIngredientList(recipeID);
            gIngredients.AutoGenerateColumns = false;
            gIngredients.Columns.Clear();
            AddIngredientColumns();
            gIngredients.AllowUserToAddRows = true;
            gIngredients.DataSource = dtrecipeingredient;
        }

        private void AddIngredientColumns()
        {
            DataTable dtIngredient = DataMaintenance.GetDataList("Ingredient");
            DataTable dtMeasurement = DataMaintenance.GetDataList("Measurement");
            WinFormsUtility.AddComboBoxToGrid(gIngredients, dtIngredient, "Ingredient", "IngredientName", 0);
            WinFormsUtility.AddComboBoxToGrid(gIngredients, dtMeasurement, "Measurement", "MeasurementType", 1);
            gIngredients.Columns.Add(CreateTextColumn("Amount", "Amount", 75));
            gIngredients.Columns.Add(CreateTextColumn("Sequence", "IngredientSequence", 75));
            WinFormsUtility.AddDeleteButtonToGrid(gIngredients, "Delete");
        }        

        private DataGridViewTextBoxColumn CreateTextColumn(string headerText, string dataPropertyName, int width)
        {
            return new DataGridViewTextBoxColumn
            {
                Name = headerText,
                HeaderText = headerText,
                DataPropertyName = dataPropertyName,
                Width = width
            };
        }        

        private void BindRecipeLists()
        {
            DataTable dtCuisine = DataMaintenance.GetDataList("Cuisine");
            DataTable dtUser = DataMaintenance.GetDataList("User");
            WinFormsUtility.SetListBinding(lstCuisineName, dtCuisine, dtrecipe, "Cuisine");
            WinFormsUtility.SetListBinding(lstUserName, dtUser, dtrecipe, "User");
        }

        private void LoadInstructions()
        {
            int recipeID = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID");
            dtinstruction = Recipe.GetInstructionList(recipeID);
            gSteps.AutoGenerateColumns = true;
            gSteps.DataSource = dtinstruction;
            WinFormsUtility.HideColumns(gSteps, "InstructionID", "RecipeID");
            if (gSteps.Columns.Contains("Instructions"))
            {
                gSteps.Columns["Instructions"]!.HeaderText = "Step";

                gSteps.Columns["Instructions"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            if (gSteps.Columns.Contains("InstructionSequence"))
            {
                gSteps.Columns["InstructionSequence"]!.HeaderText = "Sequence";

                gSteps.Columns["InstructionSequence"]!.Width = 80;
            }
            if (!gSteps.Columns.Contains("Delete"))
            {
                WinFormsUtility.AddDeleteButtonToGrid(gSteps, "Delete");
            }
            gSteps.AllowUserToAddRows = true;
        }

        private void SetRecipeID(DataTable dt, int recipeID)
        {
            foreach (DataRow r in dt.Rows)
            {
                if (r.RowState != DataRowState.Deleted)
                {
                    r["RecipeID"] = recipeID;
                }
            }
        }

        private void SaveRecipeChildRows(DataTable dt, DataGridView grid, Action<DataTable> saveMethod, Action loadMethod, string successMessage, string errorTitle)
        {
            Application.UseWaitCursor = true;
            try
            {
                grid.EndEdit();
                int recipeID = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID");
                if (recipeID == 0)
                {
                    MessageBox.Show("Save the recipe before adding ingredients or steps.", "Recipe");
                    return;
                }
                SetRecipeID(dt, recipeID);
                saveMethod(dt);
                loadMethod();
                MessageBox.Show(successMessage, "Recipe");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, errorTitle);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private void ReloadRecipe(int recipeID)
        {
            dtrecipe = Recipe.Load(recipeID);
            bindsource.DataSource = dtrecipe;
            BindRecipeControls();
            BindRecipeLists();
        }

        private void SaveRecipeIngredients()
        {
            SaveRecipeChildRows(dtrecipeingredient, gIngredients, Recipe.SaveRecipeIngredients, LoadRecipeIngredients,
                "Ingredients saved successfully.", "Recipe Ingredients");
        }

        private void SaveSteps()
        {
            SaveRecipeChildRows(dtinstruction, gSteps, Recipe.SaveInstructions, LoadInstructions,
                "Steps saved successfully.", "Recipe Steps");
        }
        

        private void SetExistingRecipeControls(bool enabled)
        {
            btnDelete.Enabled = enabled;
            btnSaveIngredient.Enabled = enabled;
            btnSaveSteps.Enabled = enabled;
            gIngredients.Enabled = enabled;
            gSteps.Enabled = enabled;
            btnChangeStatus.Enabled = enabled;
        }

        private void RefreshRecipeList()
        {
            frmRecipeList? recipeList = ((frmMain)MdiParent!).GetOpenForm<frmRecipeList>();

            if (recipeList != null)
            {
                recipeList.LoadList();
            }
        }

        private void Delete()
        {
            DialogResult response =MessageBox.Show("Are you sure you want to delete this record?", "Recipe",MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                RefreshRecipeList();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }

        private bool Save()
        {
            bool saved = false;

            Application.UseWaitCursor = true;

            try
            {
                bindsource.EndEdit();
                Recipe.Save(dtrecipe);
                int recipeID =SQLUtility.GetValueFromFirstRowAsInt(dtrecipe,"RecipeID");
                Tag = recipeID;
                RefreshRecipeList();
                SetExistingRecipeControls(recipeID != 0);
                LoadRecipeIngredients();
                LoadInstructions();
                MessageBox.Show("Recipe saved successfully.", "Recipe");
                saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
            return saved;
        }

        private void DeleteChildRow(DataGridView grid, DataGridViewCellEventArgs e, string idColumn, Action<int> deleteMethod)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (grid.Columns[e.ColumnIndex].Name != "Delete")
            {
                return;
            }

            DataRowView? rowView = grid.Rows[e.RowIndex].DataBoundItem as DataRowView;

            if (rowView == null)
            {
                return;
            }

            int id = rowView.Row[idColumn] == DBNull.Value ? 0 : Convert.ToInt32(rowView.Row[idColumn]);

            try
            {
                if (id != 0)
                {
                    deleteMethod(id);
                }

                rowView.Row.Delete();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
        }

        private void ChangeStatus()
        {
            if (dtrecipe.Rows.Count == 0)
            {
                return;
            }

            int recipeID = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeID");

            if (recipeID == 0)
            {
                MessageBox.Show("Save the recipe before changing its status.", "Recipe");
                return;
            }

            frmChangeRecipeStatus frm = new();

            if (frm.ShowForm(recipeID) == DialogResult.OK)
            {
                ReloadRecipe(recipeID);
                RefreshRecipeList();
            }
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredients();
        }

        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveSteps();
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }

        private void GIngredients_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteChildRow(gIngredients, e, "RecipeIngredientID", Recipe.DeleteRecipeIngredient);
        }

        private void GSteps_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            DeleteChildRow(gSteps, e, "InstructionID", Recipe.DeleteInstruction);
        }

        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeStatus();
        }
        
    }
}
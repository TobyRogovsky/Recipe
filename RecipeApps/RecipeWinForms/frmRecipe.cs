using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        BindingSource bindsource = new BindingSource();
        public frmRecipe()
        {

            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeID)
        {
            dtrecipe = Recipe.Load(recipeID);
            bindsource.DataSource = dtrecipe;
            
            if (recipeID == 0)
            {
                DataRow r = dtrecipe.NewRow();
                r["RecipeID"] = 0;
                r["RecipeName"] = "";
                r["DraftDate"] = DateTime.Now;
                r["Calories"] = 0;
                dtrecipe.Rows.Add(r);
            }

            DataTable dtCuisine = Recipe.GetCuisineList(0);
            DataTable dtUser = Recipe.GetUserList(0);

            if (recipeID == 0)
            {
                dtrecipe.Rows[0]["CuisineID"] = dtCuisine.Rows[0]["CuisineID"];
                dtrecipe.Rows[0]["UserID"] = dtUser.Rows[0]["UserID"];

                txtRecipeStatus.Text = "Draft";
            }

            WinFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WinFormsUtility.SetControlBinding(txtCalories, bindsource);
            WinFormsUtility.SetControlBinding(dtpDraftDate, bindsource);
            WinFormsUtility.SetControlBinding(txtPublishedDate, bindsource);
            WinFormsUtility.SetControlBinding(txtArchivedDate, bindsource);

            if (recipeID != 0)
            {
                WinFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);
            }

            WinFormsUtility.SetListBinding(lstCuisineName, dtCuisine, dtrecipe, "Cuisine");
            WinFormsUtility.SetListBinding(lstUserName, dtUser, dtrecipe, "User");

            txtPublishedDate.ReadOnly = true;
            txtArchivedDate.ReadOnly = true;
            txtRecipeStatus.ReadOnly = true;

            this.Show();
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this record?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
                this.Close();
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

        private void Save()
        {
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Save(dtrecipe);
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


        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


    }
}

using CPUFramework;
using System.Data;
using CPUWinFormsFramework;
using System.Diagnostics;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {

            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int recipeID)
        {
            dtrecipe = Recipe.Load(recipeID);

            DataTable dtCuisine = Recipe.GetCuisineList(0);
            DataTable dtUser = Recipe.GetUserList(0);

            if (recipeID == 0)
            {
                dtrecipe.Rows[0]["CuisineID"] = dtCuisine.Rows[0]["CuisineID"];
                dtrecipe.Rows[0]["UserID"] = dtUser.Rows[0]["UserID"];

                txtRecipeStatus.Text = "Draft";
            }

            WinFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WinFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WinFormsUtility.SetControlBinding(dtpDraftDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtPublishedDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtArchivedDate, dtrecipe);

            if (recipeID != 0)
            {
                WinFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);
            }

            WinFormsUtility.SetListBinding(lstCuisineName, dtCuisine, dtrecipe, "Cuisine");
            WinFormsUtility.SetListBinding(lstUserName, dtUser, dtrecipe, "User");

            txtPublishedDate.ReadOnly = true;
            txtArchivedDate.ReadOnly = true;
            txtRecipeStatus.ReadOnly = true;

            this.Show();
        }


        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            Recipe.Delete(dtrecipe);
            this.Close();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            this.Validate();
            Recipe.Save(dtrecipe);
        }

        
    }
}

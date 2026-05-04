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

            WinFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WinFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WinFormsUtility.SetControlBinding(dtpDraftDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtPublishedDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtArchivedDate, dtrecipe);

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

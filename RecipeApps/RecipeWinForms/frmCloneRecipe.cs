using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCloneRecipe : Form
    {
        DataTable dtrecipe = new();

        public frmCloneRecipe()
        {
            InitializeComponent();
            Load += FrmCloneRecipe_Load;
            btnClone.Click += BtnClone_Click;
        }

        private void FrmCloneRecipe_Load(object? sender, EventArgs e)
        {
            dtrecipe = Recipe.GetListOfRecipes("");
            lstRecipe.DataSource = dtrecipe;
            lstRecipe.DisplayMember = "RecipeName";
            lstRecipe.ValueMember = "RecipeID";
        }
        private void Clone()
        {
            int recipeID =WinFormsUtility.GetIDFromComboBox(lstRecipe);
            if (recipeID == 0)
            {
                MessageBox.Show("Please select a recipe.","Clone Recipe");
                return;
            }
            try
            {
                Recipe.Clone(recipeID);
                frmMain main = (frmMain)MdiParent!;
                main.OpenForm(typeof(frmRecipeList));
                main.GetOpenForm<frmRecipeList>()?.LoadList();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Clone Recipe");
            }
        }

        private void BtnClone_Click(object? sender, EventArgs e)
        {
            Clone();
        }
        
    }
}
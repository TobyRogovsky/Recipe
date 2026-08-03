using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmRecipeList : Form
    {
        public frmRecipeList()
        {
            InitializeComponent();
            this.Shown += FrmRecipeList_Shown;
            btnNew.Click += BtnNew_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
        }        

        public void LoadList()
        {            
            gRecipe.DataSource = Recipe.GetRecipeList();
            WinFormsUtility.FormatGridForSearchResult(gRecipe, "Recipe");
        }

        private void FrmRecipeList_Shown(object? sender, EventArgs e)
        {
            LoadList();
        }        


        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent!).OpenForm(typeof(frmRecipe), 0);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = WinFormsUtility.GetIdFromGrid(gRecipe, e.RowIndex, "RecipeID");
                ((frmMain)MdiParent!).OpenForm(typeof(frmRecipe), id);
            }
        }
    }
}

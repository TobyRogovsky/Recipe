using CPUFramework;
using System.Data;
using CPUWinFormsFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();            
            btnSearch.Click += BtnSearch_Click;
            gRecipe.CellDoubleClick += GRecipe_CellDoubleClick;
            btnNew.Click += BtnNew_Click;
            WinFormsUtility.FormatGridForSearchResult(gRecipe);
        }
      

        private void ShowRecipe(int rowindex)
        {
            int id = 0;
            if (rowindex > -1)
            {
                id = (int)gRecipe.Rows[rowindex].Cells["RecipeID"].Value;
                
            }
            frmRecipe frm = new frmRecipe();
            frm.ShowForm(id);
        }        

        private void SearchRecipe(string recipename)
        {
            DataTable dt = Recipe.GetListOfRecipes();
            gRecipe.DataSource = dt;
        }
      

        private void BtnSearch_Click(object? sender, EventArgs e)
        {
            SearchRecipe(txtSearch.Text);
        }

        private void GRecipe_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {            
            ShowRecipe(e.RowIndex);
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ShowRecipe(-1);
        }


    }
}

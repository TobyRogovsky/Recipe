using CPUFramework;
using System.Data;
using CPUWinFormsFramework;

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
            string sql = "select RecipeID, RecipeName from recipe r where r.recipename like '%" + recipename + "%'";
            DataTable dt = SQLUtility.GetDataTable(sql);
            gRecipe.DataSource = dt;
            gRecipe.Columns["RecipeID"].Visible = false;
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

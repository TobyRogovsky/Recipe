using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookBookList : Form
    {
        public frmCookBookList()
        {
            InitializeComponent();
            btnNew.Click += BtnNew_Click;
            this.Shown += FrmCookBookList_Shown;
            gCookbook.DoubleClick += GCookbook_DoubleClick;
        }      

        public void LoadList()
        {
            DataTable dt = Recipe.GetCookbookList(0);
            gCookbook.DataSource = dt;
            gCookbook.Columns["CookbookID"]!.Visible = false;
            gCookbook.Columns["CookBookStatus"]!.Visible = false;
            gCookbook.Columns["NumRecipes"]!.Visible = false;
            WinFormsUtility.FormatGridForSearchResult(gCookbook, "Cookbook");
        }

        private void FrmCookBookList_Shown(object? sender, EventArgs e)
        {
            LoadList();
        }
        private void GCookbook_DoubleClick(object? sender, EventArgs e)
        {
            if (gCookbook.CurrentRow != null)
            {
                int cookbookID =
                    (int)gCookbook.CurrentRow.Cells["CookbookID"].Value!;

                ((frmMain)MdiParent!).OpenForm(
                    typeof(frmCookbook),
                    cookbookID
                );
            }
        }


        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent!).OpenForm(typeof(frmCookbook), 0);
        }
    }
}

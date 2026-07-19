using System.Data;
using CPUWinFormsFramework;
using RecipeSystem;

namespace RecipeWinForms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            btnRecipeList.Click += BtnRecipeList_Click;
            btnMealList.Click += BtnMealList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            this.Shown += FrmDashboard_Shown;
        }

        private void LoadDashboard()
        {
            DataTable dt = Recipe.GetDashboardStats();
            gData.DataSource = dt;
            WinFormsUtility.FormatGridForSearchResult(gData, "Dashboard");
            gData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
                

        private void FrmDashboard_Shown(object? sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent!).OpenForm(typeof(frmRecipeList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent!).OpenForm(typeof(frmMeal));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent!).OpenForm(typeof(frmCookBookList));
        }
    }
}

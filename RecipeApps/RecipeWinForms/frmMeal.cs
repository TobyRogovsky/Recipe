using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmMeal : Form
    {
        public frmMeal()
        {
            InitializeComponent();
            this.Shown += FrmMeal_Shown;            
        }       

        public void LoadList()
        {
            DataTable dt = DataMaintenance.GetDataList("Meal");
            gMeal.DataSource = dt;
            WinFormsUtility.FormatGridForSearchResult(gMeal, "Meal");
        }

        private void FrmMeal_Shown(object? sender, EventArgs e)
        {
            LoadList();
        }
        
    }
}

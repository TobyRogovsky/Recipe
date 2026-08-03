using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            btnNew.Click += BtnNew_Click;
            this.Shown += FrmCookbookList_Shown;
            gCookbook.CellDoubleClick += GCookbook_CellDoubleClick; 
        }        

        public void LoadList()
        {
            DataTable dt = DataMaintenance.GetDataList("Cookbook");
            gCookbook.DataSource = dt;
            WinFormsUtility.FormatGridForSearchResult(gCookbook, "Cookbook");
            WinFormsUtility.HideColumns(gCookbook, "CookbookID", "CookbookStatus");
        }

        private void FrmCookbookList_Shown(object? sender, EventArgs e)
        {
            LoadList();
        }
        
        private void GCookbook_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int cookbookID = WinFormsUtility.GetIdFromGrid(gCookbook, e.RowIndex, "CookbookID");
                ((frmMain)MdiParent!).OpenForm(typeof(frmCookbook), cookbookID);
            }
        }

        private void BtnNew_Click(object? sender, EventArgs e)
        {
            ((frmMain)MdiParent!).OpenForm(typeof(frmCookbook), 0);
        }
    }
}

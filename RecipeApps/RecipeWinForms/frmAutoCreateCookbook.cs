using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmAutoCreateCookbook : Form
    {
        public frmAutoCreateCookbook()
        {
            InitializeComponent();
            this.Shown += FrmAutoCreateCookbook_Shown;
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
        }

        private void FrmAutoCreateCookbook_Shown(object? sender,EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            DataTable dtUser = DataMaintenance.GetDataList("User");
            lstUser.DataSource = dtUser;
            lstUser.DisplayMember = "UserName";
            lstUser.ValueMember = "UserID";
        }

        private void CreateCookbook()
        {
            try
            {
                int userID = WinFormsUtility.GetIDFromComboBox(lstUser);
                if (userID == 0)
                {
                    MessageBox.Show("Please select a user.", "Auto-Create Cookbook");
                    return;
                }
                int cookbookID = Cookbook.AutoCreate(userID);
                MessageBox.Show("The cookbook was created successfully.", "Cookbook Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ((frmMain)MdiParent!).OpenForm(typeof(frmCookbook), cookbookID);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Create Cookbook", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCreateCookbook_Click(object? sender,EventArgs e)
        {
            CreateCookbook(); 
        }
        
    }
}
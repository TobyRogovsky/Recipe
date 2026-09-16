using RecipeSystem;
using System.Configuration;
namespace RecipeWinForms
{
    public partial class frmLogin : Form
    {        
        
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            txtUserID.Text = LoginCredentials.UserID;
            txtPassword.Text = LoginCredentials.Password;
        }

        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            // DEV
            // string connectionstring = ConfigurationManager.ConnectionStrings["devconn"].ConnectionString;

            // LIVE
            string connectionstring = ConfigurationManager.ConnectionStrings["liveconn"].ConnectionString;
            try
            {
                DBManager.SetConnectionString(connectionstring, txtUserID.Text, txtPassword.Text);                    
                Hide();
                frmMain frm = new frmMain();
                frm.ShowDialog();

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login Failed");
            }
        }
    }
}

using RecipeSystem;
using System.Configuration;
namespace RecipeWinForms;
using RecipeWinForms.Properties;

public partial class frmLogin : Form
{

    public frmLogin()
    {
        InitializeComponent();
        btnLogin.Click += BtnLogin_Click;

        txtUserID.Text = Settings.Default.userid;
        txtPassword.Text = Settings.Default.password;
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
            Settings.Default.userid = txtUserID.Text;
            Settings.Default.password = txtPassword.Text;
            Settings.Default.Save();
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

using RecipeSystem;
using System.Configuration;
namespace RecipeWinForms;
using RecipeWinForms.Properties;

public partial class frmLogin : Form
{

    public frmLogin()
    {
        InitializeComponent();
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        WindowState = FormWindowState.Normal;
        MaximizeBox = false;
        MinimizeBox = false;
        ShowInTaskbar = false;
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
            DialogResult = DialogResult.OK;
            Close();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Login Failed");
        }
    }
}

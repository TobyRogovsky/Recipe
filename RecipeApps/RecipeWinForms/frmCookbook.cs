using CPUWinFormsFramework;
using RecipeSystem;
using System;
using System.Data;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmCookbook : Form
    {
        DataTable dtCookbook = new();
        BindingSource bindsource = new();

        public frmCookbook()
        {
            InitializeComponent();            
        }      

        public void ShowForm(int cookbookID)
        {
            dtCookbook = Cookbook.Load(cookbookID);
            bindsource.DataSource = dtCookbook;

            if (cookbookID == 0)
            {
                DataRow r = dtCookbook.NewRow();
                r["CookbookID"] = 0;
                r["CookbookName"] = "";
                r["Price"] = 0;
                r["DateCookbookCreated"] = DateTime.Now;
                r["CookBookStatus"] = 1;
                dtCookbook.Rows.Add(r);
            }

            DataTable dtUser = Recipe.GetUserList(0);

            if (cookbookID == 0)
            {
                dtCookbook.Rows[0]["UserID"] = dtUser.Rows[0]["UserID"];
            }

            WinFormsUtility.SetControlBinding(chkCookBookStatus, bindsource);
            WinFormsUtility.SetControlBinding(txtCookbookName,bindsource);
            WinFormsUtility.SetControlBinding(txtPrice, bindsource);
            WinFormsUtility.SetListBinding(lstUserName, dtUser,dtCookbook, "User");
            WinFormsUtility.SetControlBinding(dtpDateCookbookCreated, bindsource);
        }
    }
}
    
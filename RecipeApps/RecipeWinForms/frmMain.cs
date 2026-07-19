using CPUWinFormsFramework;

namespace RecipeWinForms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            mnuDashboard.Click += MnuDasbhoard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuRecipeNew.Click += MnuRecipeNew_Click;
            mnuCloneRecipe.Click += MnuCloneRecipe_Click;
            mnuMealList.Click += MnuMealList_Click;
            this.Shown += FrmMain_Shown;
        }

        
        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WinFormsUtility.IsFormOpen(frmtype, pkvalue);

            Form? newfrm = null;

            if (b == false)
            {
                if (frmtype == typeof(frmDashboard))
                {
                    frmDashboard f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    f.LoadForm(pkvalue);
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMeal))
                {
                    frmMeal f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookBookList))
                {
                    frmCookBookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    f.ShowForm(pkvalue);
                    newfrm = f;
                }

                if (newfrm != null)
                {
                    newfrm.MdiParent = this;
                    newfrm.Tag = pkvalue;

                    if (frmtype != typeof(frmCloneRecipe))
                    {
                        newfrm.WindowState = FormWindowState.Maximized;
                    }

                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;

                    newfrm.Show();
                    WinFormsUtility.SetupNav(tsMain);
                }
            }
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WinFormsUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WinFormsUtility.SetupNav(tsMain);
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMeal));
        }

        private void MnuCloneRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuRecipeNew_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuDasbhoard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

    }

}

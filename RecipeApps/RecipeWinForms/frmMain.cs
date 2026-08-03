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
            mnuListCookbooks.Click += MnuListCookbooks_Click;
            mnuCreateCookbook.Click += MnuCreateCookbook_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuCascade.Click += MnuCascade_Click;
            mnuTile.Click += MnuTile_Click;            
            mnuEditData.Click += MnuEditData_Click;
            this.Shown += FrmMain_Shown;
        }        

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private Form? CreateForm(Type formType, int id)
        {
            if (formType == typeof(frmDashboard)) return new frmDashboard();
            if (formType == typeof(frmCloneRecipe)) return new frmCloneRecipe();
            if (formType == typeof(frmRecipeList)) return new frmRecipeList();
            if (formType == typeof(frmDataMaintenance)) return new frmDataMaintenance();
            if (formType == typeof(frmMeal)) return new frmMeal();
            if (formType == typeof(frmCookbookList)) return new frmCookbookList();
            if (formType == typeof(frmAutoCreateCookbook)) return new frmAutoCreateCookbook();

            if (formType == typeof(frmRecipe))
            {
                frmRecipe frm = new();
                frm.ShowForm(id);
                return frm;
            }

            if (formType == typeof(frmCookbook))
            {
                frmCookbook frm = new();
                frm.ShowForm(id);
                return frm;
            }

            return null;
        }
        public void OpenForm(Type formType, int id = 0)
        {
            if (WinFormsUtility.IsFormOpen(formType, id))
            {
                return;
            }
            Form? newForm = CreateForm(formType, id);
            if (newForm == null)
            {
                return;
            }
            newForm.MdiParent = this;
            newForm.Tag = id;
            if (formType != typeof(frmCloneRecipe))
            {
                newForm.WindowState = FormWindowState.Maximized;
            }
            newForm.FormClosed += Newfrm_FormClosed;
            newForm.TextChanged += Newfrm_TextChanged;
            newForm.Show();
            WinFormsUtility.SetupNav(tsMain);
        }

        public T? GetOpenForm<T>() where T : Form
        {
            foreach (Form f in MdiChildren)
            {
                if (f is T)
                {
                    return (T)f;
                }
            }
            return null;
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
            WinFormsUtility.SetupNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WinFormsUtility.SetupNav(tsMain);
        }       

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook), 0);
        }

        private void MnuCreateCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmAutoCreateCookbook));
        }
        private void MnuListCookbooks_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
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
            OpenForm(typeof(frmRecipe), 0);
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuDasbhoard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }

    }

}

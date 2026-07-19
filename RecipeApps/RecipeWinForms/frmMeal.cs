using CPUWinFormsFramework;
using RecipeSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmMeal : Form
    {
        public frmMeal()
        {
            InitializeComponent();
            this.Shown += FrmMeal_Shown;
            gMeal.CellDoubleClick += GMeal_CellDoubleClick;
        }       

        public void LoadList()
        {
            DataTable dt = Recipe.GetMealList(0);
            gMeal.DataSource = dt;
            WinFormsUtility.FormatGridForSearchResult(gMeal, "Meal");
        }

        private void FrmMeal_Shown(object? sender, EventArgs e)
        {
            LoadList();
        }

        private void GMeal_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                int id = WinFormsUtility.GetIdFromGrid(gMeal, e.RowIndex, "MealID");
                ((frmMain)MdiParent!).OpenForm(typeof(frmMeal), id);
            }
        }
    }
}

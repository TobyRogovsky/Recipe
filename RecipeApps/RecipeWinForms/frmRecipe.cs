using CPUFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        public frmRecipe()
        {
            InitializeComponent();
        }

        public void ShowForm(int RecipeID)
        {
            string sql = "Select r.recipename, r.recipestatus, r.draftdate, r.publisheddate, r.archiveddate, r.calories, c.cuisinename from recipe r join cuisine c on r.cuisineID = c.cuisineID where r.recipeID = " + RecipeID.ToString();
            DataTable dt = SQLUtility.GetDataTable(sql);
            txtRecipeName.DataBindings.Add("Text", dt, "RecipeName");
            txtCalories.DataBindings.Add("Text", dt, "Calories");
            txtRecipeStatus.DataBindings.Add("Text", dt, "RecipeStatus");
            txtDraftDate.DataBindings.Add("Text", dt, "DraftDate");
            txtPublishedDate.DataBindings.Add("Text", dt, "PublishedDate");
            txtArchivedDate.DataBindings.Add("Text", dt, "ArchivedDate");
            txtCuisine.DataBindings.Add("Text", dt, "CuisineName");
            this.Show();
        }

    }
}

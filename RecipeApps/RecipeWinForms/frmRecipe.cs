using CPUFramework;
using System.Data;
using CPUWinFormsFramework;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe;
        public frmRecipe()
        {

            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }


        public void ShowForm(int RecipeID)
        {
            string sql = "Select r.RecipeID, r.RecipeName, r.RecipeStatus, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.Calories from recipe r where r.RecipeID = " + RecipeID.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (RecipeID == 0)
            {
                dtrecipe.Rows.Add();
            }
            WinFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WinFormsUtility.SetControlBinding(txtCalories, dtrecipe);
            WinFormsUtility.SetControlBinding(txtRecipeStatus, dtrecipe);
            WinFormsUtility.SetControlBinding(dtpDraftDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtPublishedDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtArchivedDate, dtrecipe);
            
            this.Show();
            txtRecipeStatus.ReadOnly = true;
            Debug.Print(sql);
        }

        private void Save()
        {
            
            DataRow r = dtrecipe.Rows[0];
            int id = 0;
            int.TryParse(r["RecipeID"].ToString(), out id);
            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine, "update recipe set",
                $"RecipeName = '{r["RecipeName"]}',",
                $"Calories = {r["Calories"]},",
                $"DraftDate = '{r["DraftDate"]}'",
                $"where RecipeID = {r["RecipeID"]}");
            }
            else
            {
                sql = "insert into recipe(RecipeName, Calories, DraftDate) ";
                sql += $"select '{r["RecipeName"]}', {r["Calories"]}, '{r["DraftDate"]}'";
            }

            Debug.Print("-----------------------");
            Debug.Print(sql);
            SQLUtility.ExecuteSQL(sql);
        }

        private void Delete()
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            string sql = "Delete recipe where RecipeID = " + id;
            SQLUtility.ExecuteSQL(sql);
            this.Close();
        }
       

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }


    }
}

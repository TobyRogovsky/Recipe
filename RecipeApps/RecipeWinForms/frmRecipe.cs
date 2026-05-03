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
            string sql = "Select r.RecipeID, r.RecipeName, r.DraftDate, r.PublishedDate, r.ArchivedDate, r.Calories from recipe r where r.RecipeID = " + RecipeID.ToString();
            dtrecipe = SQLUtility.GetDataTable(sql);
            if (RecipeID == 0)
            {
                DataRow r = dtrecipe.NewRow();
                r["RecipeName"] = "";                
                r["DraftDate"] = DateTime.Now;
                r["Calories"] = 0;

                dtrecipe.Rows.Add(r);
                txtRecipeStatus.Text = "Draft";
            }
            else
            {
                txtRecipeStatus.Text = SQLUtility.GetDataTable(
                    "select RecipeStatus from recipe where RecipeID = " + RecipeID.ToString()
                ).Rows[0]["RecipeStatus"].ToString();
            }
            WinFormsUtility.SetControlBinding(txtRecipeName, dtrecipe);
            WinFormsUtility.SetControlBinding(txtCalories, dtrecipe);            
            WinFormsUtility.SetControlBinding(dtpDraftDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtPublishedDate, dtrecipe);
            WinFormsUtility.SetControlBinding(txtArchivedDate, dtrecipe);

            txtRecipeStatus.ReadOnly = true;
            
            this.Show();
            txtRecipeStatus.ReadOnly = true;
            Debug.Print(sql);
        }

        private void Save()
        {
            this.Validate();
            dtrecipe.Rows[0].EndEdit();

            DataRow r = dtrecipe.Rows[0];

            int id = 0;
            int.TryParse(r["RecipeID"].ToString(), out id);

            string publisheddate = "null";
            if (r["PublishedDate"].ToString() != "")
            {
                publisheddate = "'" + r["PublishedDate"] + "'";
            }

            string archiveddate = "null";
            if (r["ArchivedDate"].ToString() != "")
            {
                archiveddate = "'" + r["ArchivedDate"] + "'";
            }

            string sql = "";

            if (id > 0)
            {
                sql = string.Join(Environment.NewLine,
                    "update recipe set",
                    $"RecipeName = '{r["RecipeName"]}',",
                    $"Calories = {r["Calories"]},",
                    $"DraftDate = '{r["DraftDate"]}',",
                    $"PublishedDate = {publisheddate},",
                    $"ArchivedDate = {archiveddate}",
                    $"where RecipeID = {id}"
                );
            }
            else
            {
                sql = string.Join(Environment.NewLine,
                    "insert into recipe(RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate)",
                    $"select '{r["RecipeName"]}', {r["Calories"]}, '{r["DraftDate"]}', {publisheddate}, {archiveddate}"
                );
            }

            Debug.Print("-----------------------");
            Debug.Print(sql);

            SQLUtility.ExecuteSQL(sql);

            this.Close();
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

using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{
    public partial class frmChangeRecipeStatus : Form        
    {
        private DataTable dtrecipe = new();
        private int recipeid;
        public frmChangeRecipeStatus()
        {
            InitializeComponent();
            btnDraft.Click += BtnDraft_Click;
            btnPublish.Click += BtnPublish_Click;
            btnArchive.Click += BtnArchive_Click;
        }

        public DialogResult ShowForm(int recipeID)
        {
            recipeid = recipeID;
            if (!LoadRecipe())
            {
                return DialogResult.Cancel;
            }
            return ShowDialog();
        }

        private bool LoadRecipe()
        {
            dtrecipe = Recipe.Load(recipeid);
            if (dtrecipe.Rows.Count == 0)
            {
                MessageBox.Show("The recipe could not be found.", "Recipe Not Found", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            DataRow row = dtrecipe.Rows[0];
            lblRecipeName.Text = row["RecipeName"].ToString();
            lblCurrentStatus.Text = row["RecipeStatus"].ToString();
            txtDraftDate.Text = FormatDate(row["DraftDate"]);
            txtPublishedDate.Text = FormatDate(row["PublishedDate"]);
            txtArchivedDate.Text = FormatDate(row["ArchivedDate"]);
            SetStatusButtons();
            return true;
        }

        private string FormatDate(object value)
        {
            return value == DBNull.Value ? ""  : Convert.ToDateTime(value).ToShortDateString();
        }

        private void SetStatusButtons()
        {
            string currentStatus = lblCurrentStatus.Text.Trim();
            btnDraft.Enabled =!currentStatus.Equals("Draft",StringComparison.OrdinalIgnoreCase);
            btnPublish.Enabled =!currentStatus.Equals("Published",StringComparison.OrdinalIgnoreCase);
            btnArchive.Enabled =!currentStatus.Equals("Archived", StringComparison.OrdinalIgnoreCase);
        }

        private void ChangeStatus(string newStatus)
        {
            string currentStatus = lblCurrentStatus.Text;
            DialogResult result = MessageBox.Show($"Are you sure you want to change this recipe from {currentStatus} to {newStatus}?",
                "Change Recipe Status",  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                Recipe.ChangeStatus(recipeid, newStatus);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to Change Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Archived");
        }

        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Published");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus("Draft");
        }
    }
}

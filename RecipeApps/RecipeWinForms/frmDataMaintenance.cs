using CPUFramework;
using CPUWinFormsFramework;
using RecipeSystem;
using System.Data;

namespace RecipeWinForms
{   
    public partial class frmDataMaintenance : Form
    {
        private enum TableTypeEnum { User, Ingredient, Course,  Cuisine, Measurement}
        DataTable dtlist = new();
        TableTypeEnum currenttabletype = TableTypeEnum.User;
        string deletecolname = "deletecol";
        public frmDataMaintenance()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            this.FormClosing += FrmDataMaintenance_FormClosing;
            gData.CellContentClick += GData_CellContentClick;
            SetupRadioButtons();
            BindData(currenttabletype);
        }

        private void BindData(TableTypeEnum tabletype)
        {
            currenttabletype = tabletype;
            dtlist = DataMaintenance.GetDataList(currenttabletype.ToString());
            gData.Columns.Clear();
            gData.DataSource = dtlist;
            WinFormsUtility.AddDeleteButtonToGrid(gData, deletecolname);
            WinFormsUtility.FormatGridForEdit(gData, currenttabletype.ToString());
        }


        private bool Save()
        {
            bool b = false;
            Cursor = Cursors.WaitCursor;
            try
            {
                DataMaintenance.SaveDataList(dtlist, currenttabletype.ToString());
                b = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            return b;
        }

        private void Delete(int rowindex)
        {            
            int id = WinFormsUtility.GetIdFromGrid(gData, rowindex, currenttabletype.ToString() + "ID");
            if (id != 0)
            {
                DialogResult response;

                if (currenttabletype == TableTypeEnum.User)
                {
                    response = MessageBox.Show( "Are you sure you want to delete this user and all related recipes, meals, and cookbooks?", "Delete User",
                        MessageBoxButtons.YesNo);
                }
                else
                {
                    response = MessageBox.Show("Are you sure you want to delete this record?", "Delete " + currenttabletype.ToString(),MessageBoxButtons.YesNo);
                }
                if (response == DialogResult.No)
                {
                    return;
                }
                try
                {
                    DataMaintenance.DeleteRow(currenttabletype.ToString(), id);
                    BindData(currenttabletype);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (rowindex < gData.Rows.Count)
            {
                gData.Rows.RemoveAt(rowindex);
            }
        }

        private void SetupRadioButtons()
        {
            foreach (Control c in pnlRadioButtons.Controls)
            {
                if (c is RadioButton)
                {
                    c.Click += C_Click;
                }
            }            
            rbnCourse.Tag = TableTypeEnum.Course;
            rbnCuisine.Tag = TableTypeEnum.Cuisine;
            rbnIngredients.Tag = TableTypeEnum.Ingredient;            
            rbnMeasurement.Tag = TableTypeEnum.Measurement;
            rbnUsers.Tag = TableTypeEnum.User;
        }

        private void C_Click(object? sender, EventArgs e)
        {
            if (sender is Control control && control.Tag is TableTypeEnum tableType)
            {
                BindData(tableType);
            }
        }

        private void GData_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            if (gData.Columns[e.ColumnIndex].Name == deletecolname)
            {
                Delete(e.RowIndex);
            }
        }

        private void FrmDataMaintenance_FormClosing(object? sender, FormClosingEventArgs e)
        {
            if (SQLUtility.TableChanges(dtlist))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}

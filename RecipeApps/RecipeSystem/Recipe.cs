using CPUFramework;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable GetListOfRecipes(string recipename)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeName"].Value = recipename;
            if (recipename == "")
            {
                cmd.Parameters["@All"].Value = 1;
            }
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }        
        
        public static DataTable GetRecipeList()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeListGet");
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }
        

        public static DataTable GetInstructionList(int recipeID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("InstructionGet");
            cmd.Parameters["@RecipeID"].Value = recipeID;
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }
        public static DataTable GetRecipeIngredientList(int recipeID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientGet");
            cmd.Parameters["@RecipeID"].Value = recipeID;
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }
        public static void SaveInstructions(DataTable dtInstruction)
        {
            if (dtInstruction.Columns.Contains("InstructionID"))
            {
                dtInstruction.Columns["InstructionID"]!.ReadOnly = false;
            }
            SQLUtility.SaveDataTable(dtInstruction, "InstructionUpdate");
        }

        public static void SaveRecipeIngredients(DataTable dtRecipeIngredient)
        {
            if (dtRecipeIngredient.Columns.Contains("RecipeIngredientID"))
            {
                dtRecipeIngredient.Columns["RecipeIngredientID"]!.ReadOnly = false;
            }
            SQLUtility.SaveDataTable(dtRecipeIngredient, "RecipeIngredientUpdate");
        }

        public static void DeleteRecipeIngredient(int recipeIngredientID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeIngredientDelete");
            SQLUtility.SetParamValue(cmd,"@RecipeIngredientID", recipeIngredientID);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static void DeleteInstruction(int instructionID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("InstructionDelete");
            SQLUtility.SetParamValue(cmd, "@InstructionID", instructionID);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int Clone(int recipeID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeClone");
            SQLUtility.SetParamValue(cmd,"@RecipeID",recipeID);
            DataTable dt = SQLUtility.GetDT(cmd);
            return SQLUtility.GetValueFromFirstRowAsInt(dt,"RecipeID");
        }

        public static void ChangeStatus(int recipeID, string recipeStatus)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeChangeStatus");
            cmd.Parameters["@RecipeID"].Value = recipeID;
            cmd.Parameters["@RecipeStatus"].Value = recipeStatus;
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable Load(int recipeID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeID"].Value = recipeID;
            dt = SQLUtility.GetDT(cmd);

            if (recipeID == 0)
            {
                DataRow r = dt.NewRow();
                r["RecipeID"] = 0;
                r["RecipeName"] = "";
                r["DraftDate"] = DateTime.Now;
                r["Calories"] = 0;

                if (dt.Columns.Contains("RecipeStatus"))
                {
                    r["RecipeStatus"] = "Draft";
                }

                dt.Rows.Add(r);
            }
            return dt;
        }

        public static void Save(DataTable dtRecipe)
        {
            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot save recipe because the table contains no rows.");
            }
            if (dtRecipe.Columns.Contains("RecipeID"))
            {
                dtRecipe.Columns["RecipeID"]!.ReadOnly = false;
            }
            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }


        public static void Delete(DataTable dtRecipe)
        {
            int recipeID = SQLUtility.GetValueFromFirstRowAsInt(dtRecipe,"RecipeID");
            if (recipeID == 0)
            {
                throw new Exception("The recipe must be saved before it can be deleted.");
            }
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd,"@RecipeID",recipeID);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetDashboardStats()
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("DashboardGet");
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }
        

    }
    
}

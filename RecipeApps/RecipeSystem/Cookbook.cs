using CPUFramework;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable GetCookbookRecipe(int cookbookID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeGet");
            cmd.Parameters["@CookbookID"].Value = cookbookID;
            return SQLUtility.GetDT(cmd);
        }

        public static int SaveCookbookRecipe(int cookbookRecipeID,int cookbookID, int recipeID, int recipeSequence)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeUpdate");
            cmd.Parameters["@CookbookRecipeID"].Value = cookbookRecipeID;
            cmd.Parameters["@CookbookRecipeID"].Direction = ParameterDirection.InputOutput;
            cmd.Parameters["@CookbookID"].Value = cookbookID;
            cmd.Parameters["@RecipeID"].Value = recipeID;
            cmd.Parameters["@RecipeSequence"].Value = recipeSequence;
            SQLUtility.ExecuteSQL(cmd);
            return Convert.ToInt32(cmd.Parameters["@CookbookRecipeID"].Value);
        }

        public static void SaveCookbookRecipes(DataTable dtCookbookRecipe, int cookbookID)
        {
            foreach (DataRow r in dtCookbookRecipe.Rows)
            {
                if (r.RowState == DataRowState.Deleted ||
                    r["RecipeID"] == DBNull.Value ||
                    r["RecipeSequence"] == DBNull.Value)
                {
                    continue;
                }

                int cookbookRecipeID = r["CookbookRecipeID"] == DBNull.Value
                    ? 0
                    : Convert.ToInt32(r["CookbookRecipeID"]);

                int newID = SaveCookbookRecipe(
                    cookbookRecipeID,
                    cookbookID,
                    Convert.ToInt32(r["RecipeID"]),
                    Convert.ToInt32(r["RecipeSequence"])
                );

                r["CookbookRecipeID"] = newID;
                r["CookbookID"] = cookbookID;
            }

            dtCookbookRecipe.AcceptChanges();
        }

        public static void DeleteCookbookRecipe(int cookbookRecipeID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookRecipeDelete");
            cmd.Parameters["@CookbookRecipeID"].Value = cookbookRecipeID;
            SQLUtility.ExecuteSQL(cmd);
        }

        public static DataTable GetRecipeList()
        {
            return Recipe.GetListOfRecipes("");
        }

        public static DataTable Load(int CookbookID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            cmd.Parameters["@CookbookID"].Value = CookbookID;
            DataTable dt = SQLUtility.GetDT(cmd);
            if (CookbookID == 0)
            {
                DataRow r = dt.NewRow();
                r["CookbookID"] = 0;
                r["CookbookName"] = "";
                r["Price"] = 0;
                r["DateCookbookCreated"] = DateTime.Now;
                r["CookbookStatus"] = 1;
                dt.Rows.Add(r);
            }
            return dt;
        }

        public static int AutoCreate(int userID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookAutoCreate");
            SQLUtility.SetParamValue(cmd, "@UserID", userID);
            SQLUtility.ExecuteSQL(cmd);
            return Convert.ToInt32(cmd.Parameters["@CookbookID"].Value);
        }

        public static void Delete(DataTable dtCookbook)
        {
            int cookbookID =SQLUtility.GetValueFromFirstRowAsInt(dtCookbook,"CookbookID");
            if (cookbookID == 0)
            {
                throw new Exception("The cookbook must be saved before it can be deleted.");
            }
            SqlCommand cmd =SQLUtility.GetSQLCommand("CookbookDelete");
            SQLUtility.SetParamValue(cmd,"@CookbookID", cookbookID);
            SQLUtility.ExecuteSQL(cmd);
        }

        public static int Save(DataTable dtCookbook)
        {
            if (dtCookbook.Rows.Count == 0)
            {
                throw new Exception(
                    "Cannot save cookbook because the table contains no rows.");
            }
            if (dtCookbook.Columns.Contains("CookbookID"))
            {
                dtCookbook.Columns["CookbookID"]!.ReadOnly = false;
            }
            DataRow r = dtCookbook.Rows[0];
            SQLUtility.SaveDataRow(r, "CookbookUpdate");
            return SQLUtility.GetValueFromFirstRowAsInt(dtCookbook,"CookbookID");
        }

    }
}
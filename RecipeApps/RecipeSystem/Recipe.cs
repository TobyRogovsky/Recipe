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
        public static DataTable GetCuisineList(int cuisineID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("CuisineGet");
            cmd.Parameters["@CuisineID"].Value = cuisineID;
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }

        public static DataTable GetUserList(int userID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("UserGet");
            cmd.Parameters["@UserID"].Value = userID;
            cmd.Parameters["@All"].Value = 1;
            dt = SQLUtility.GetDT(cmd);
            return dt;
        }      

        public static DataTable Load(int recipeID)
        {
            DataTable dt = new();
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeGet");
            cmd.Parameters["@RecipeID"].Value = recipeID;
            dt = SQLUtility.GetDT(cmd);

            return dt;
        }

        public static void Save(DataTable dtRecipe)
        {
            dtRecipe.Columns["RecipeID"]!.ReadOnly = false;

            if (dtRecipe.Rows.Count == 0)
            {
                throw new Exception("Cannot call recipe save method because no rows in table");
            }

            DataRow r = dtRecipe.Rows[0];
            SQLUtility.SaveDataRow(r, "RecipeUpdate");
        }

        
        

        public static void Delete(DataTable dtrecipe)
        {
            int id = (int)dtrecipe.Rows[0]["RecipeID"];
            SqlCommand cmd = SQLUtility.GetSQLCommand("RecipeDelete");
            SQLUtility.SetParamValue(cmd, "@RecipeID", id);
            SQLUtility.ExecuteSQL(cmd);
        }
        
    }
    
}

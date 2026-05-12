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
            cmd.Parameters["@All"].Value = 1;
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
            DataRow r = dtRecipe.Rows[0];
            int id = 0;

            if (r["RecipeID"] != DBNull.Value)
            {
                id = (int)r["RecipeID"];
            }

            string publishedDate = "null";
            string archivedDate = "null";

            if (r["PublishedDate"] != DBNull.Value)
            {
                publishedDate = "'" + r["PublishedDate"] + "'";
            }

            if (r["ArchivedDate"] != DBNull.Value)
            {
                archivedDate = "'" + r["ArchivedDate"] + "'";
            }

            string sql = "";

            if (id == 0)
            {
                sql = string.Join(Environment.NewLine,
                    "insert Recipe(CuisineID, UserID, RecipeName, Calories, DraftDate)",
                    "values(",
                    r["CuisineID"] + ",",
                    r["UserID"] + ",",
                    "'" + r["RecipeName"] + "',",
                    r["Calories"] + ",",
                    "'" + r["DraftDate"] + "'",
                    ")"
                );
            }
            else
            {
                sql = string.Join(Environment.NewLine,
                     "update Recipe set",
                     "RecipeName = '" + r["RecipeName"] + "',",
                     "Calories = " + r["Calories"] + ",",
                     "DraftDate = '" + r["DraftDate"] + "',",
                     "PublishedDate = " + publishedDate + ",",
                     "ArchivedDate = " + archivedDate + ",",
                     "CuisineID = " + r["CuisineID"] + ",",
                     "UserID = " + r["UserID"],
                     "where RecipeID = " + id
                  );
            }
            
            System.Diagnostics.Debug.Print(sql);

            SQLUtility.ExecuteSQL(sql);
        }

        public static void Delete(DataTable dtrecipe)
        {
            int recipeID = (int)dtrecipe.Rows[0]["recipeID"];
            string sql = string.Join(Environment.NewLine,
       "delete RecipeIngredient where recipeID = " + recipeID,
       "delete Instruction where recipeID = " + recipeID,
       "delete RecipeMealCourse where recipeID = " + recipeID,
       "delete CookBookRecipe where recipeID = " + recipeID,
       "delete Recipe where recipeID = " + recipeID
   );
            SQLUtility.ExecuteSQL(sql);
        }
        
    }
    
}

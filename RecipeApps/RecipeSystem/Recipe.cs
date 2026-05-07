using CPUFramework;
using System.Data;

namespace RecipeSystem
{
    public class Recipe
    {
        public static DataTable GetListOfRecipes()
        {
            return SQLUtility.GetDataTable("select RecipeID, RecipeName from Recipe");
        }
        public static DataTable GetCuisineList()
        {
            return SQLUtility.GetDataTable("select CuisineID, CuisineName from Cuisine");
        }

        public static DataTable GetUserList()
        {
            return SQLUtility.GetDataTable("select UserID, UserName from Users");
        }      

        public static DataTable Load(int recipeID)
        {
            string sql = "select r.*, c.CuisineName, u.UserName " +
                         "from recipe r " +
                         "join cuisine c on r.CuisineID = c.CuisineID " +
                         "join Users u on r.UserID = u.UserID " +
                         "where r.RecipeID = " + recipeID.ToString();

            if (recipeID == 0)
            {
                sql = "select * from Recipe where RecipeID = 0";
            }

            DataTable dt = SQLUtility.GetDataTable(sql);

            if (recipeID == 0)
            {
                DataRow r = dt.NewRow();

                r["CuisineID"] = SQLUtility.GetFirstColumnFirstRowValue("select top 1 CuisineID from Cuisine");
                r["UserID"] = SQLUtility.GetFirstColumnFirstRowValue("select top 1 UserID from Users");
                r["RecipeName"] = "";
                r["Calories"] = 0;
                r["DraftDate"] = DateTime.Now;

                dt.Rows.Add(r);
            }

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

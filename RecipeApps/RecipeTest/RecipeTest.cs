using NUnit.Framework.Legacy;
using System.Data;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;


namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString(
                "Server=tcp:dev-tobycpu.database.windows.net,1433;" +
                "Initial Catalog=RecipeDB;" +
                "Persist Security Info=False;" +
                "User ID=TobyR;" +
                "Password=Liron@123;" +
                "MultipleActiveResultSets=False;" +
                "Encrypt=True;" +
                "TrustServerCertificate=False;" +
                "Connection Timeout=30;"
            );
        }

        [Test]
        [TestCase("Test Cookies", 300)]
        [TestCase("Test Smoothie", 150)]
        public void InsertNewRecipe(string recipename, int calories)
        {
            DataTable dt = SQLUtility.GetDataTable("select RecipeID, CuisineID, UserID, RecipeName, Calories, DraftDate, PublishedDate, ArchivedDate from Recipe where RecipeID = 0");

            DataRow r = dt.NewRow();
            int cuisineID = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisineID from Cuisine");
            Assume.That(cuisineID > 0, "can't run test, no cuisine in db");

            int userID = SQLUtility.GetFirstColumnFirstRowValue("select top 1 UserID from Users");
            Assume.That(userID > 0, "can't run test, no users in db");

            string newrecipe = recipename + DateTime.Now.ToString("yyyyMMddHHmmss");

            TestContext.Out.WriteLine("insert recipe with name = " + newrecipe);
            r["CuisineID"] = cuisineID;
            r["UserID"] = userID;
            r["RecipeName"] = newrecipe;
            r["Calories"] = calories;
            r["DraftDate"] = DateTime.Today;
            dt.Rows.Add(r);
            Recipe.Save(dt);

            DataTable dtnew = SQLUtility.GetDataTable(
            "SELECT RecipeID FROM Recipe WHERE RecipeName = '" + newrecipe + "'");

            ClassicAssert.IsTrue(dtnew.Rows.Count > 0, "recipe was not inserted");

            int newid = (int)dtnew.Rows[0]["RecipeID"];

            TestContext.Out.WriteLine("Recipe with name = " + newrecipe +
                " found in DB with pk value = " + newid);

        }


       
        [Test]
        public void EditRecipe()
        {
            int recipeID = GetExistingRecipeID();
            Assume.That(recipeID > 0, "no recipes in db, can't run test");
            int calories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeID = " + recipeID);
            TestContext.Out.WriteLine("calories for recipeID " + recipeID + " is " + calories);
            calories = calories + 1;
            TestContext.Out.WriteLine("change calories to " + calories);
            DataTable dt = Recipe.Load(recipeID);

            dt.Rows[0]["calories"] = calories;
            Recipe.Save(dt);

            int newcalories = SQLUtility.GetFirstColumnFirstRowValue("select calories from recipe where recipeID = " + recipeID);
            ClassicAssert.IsTrue(newcalories == calories, "calories for recipe " + recipeID + " does not equal " + newcalories);
            TestContext.Out.WriteLine("calories for recipe " + recipeID + " " + newcalories);
        }


        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 RecipeID, RecipeName from recipe");
            int recipeID = 0;            
            if (dt.Rows.Count > 0)
            {
                recipeID = (int)dt.Rows[0]["RecipeID"];                
            }
            Assume.That(recipeID > 0, "No recipes in DB, can't run test");
            TestContext.Out.WriteLine("existing recipe with ID " + recipeID);
            TestContext.Out.WriteLine("ensure that app can delete " + recipeID);
            Recipe.Delete(dt);
            DataTable dtdeleted = SQLUtility.GetDataTable("select * from recipe where recipeID = " + recipeID);
            ClassicAssert.IsTrue(dtdeleted.Rows.Count == 0, "record with recipeID " + recipeID + " exists in db");
            TestContext.Out.WriteLine("Record with recipeID " + recipeID + " does not exist in this db");
        }


        [Test]
        public void GetRecipeList()
        {
            int recipecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count(*) from recipe");
            Assume.That(recipecount > 0, "no recipes in DB, can't test");
            TestContext.Out.WriteLine("num of recipes in DB = " + recipecount);
            TestContext.Out.WriteLine("ensure that num of rows returned by app matches " + recipecount);

            DataTable dt = Recipe.GetListOfRecipes("");
            ClassicAssert.IsTrue(dt.Rows.Count == recipecount, "num rows returned by app " + dt.Rows.Count + "does not equal " + recipecount);
            TestContext.Out.WriteLine("number of rows in recipe returned by app = " + dt.Rows.Count);

        }

        private int GetExistingRecipeID()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 recipeID from recipe");
        }      

      
    }
}

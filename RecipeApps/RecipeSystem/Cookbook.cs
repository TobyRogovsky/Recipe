using CPUFramework;
using System.Data;
using Microsoft.Data.SqlClient;

namespace RecipeSystem
{
    public class Cookbook
    {
        public static DataTable Load(int cookbookID)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand("CookbookGet");
            cmd.Parameters["@CookbookID"].Value = cookbookID;
            DataTable dt = SQLUtility.GetDT(cmd);
            return dt;
        }
   
    }
}
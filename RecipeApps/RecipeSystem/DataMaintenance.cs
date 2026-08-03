using CPUFramework;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeSystem
{
    public class DataMaintenance
    {
        public static DataTable GetDataList(string tablename, bool includeblank = false)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Get");
            SQLUtility.SetParamValue(cmd, "@All", 1);
            if (includeblank)
            {
                SQLUtility.SetParamValue(cmd, "@IncludeBlank", true);
            }
            return SQLUtility.GetDT(cmd);
        }

        public static void SaveDataList(DataTable dt, string tablename)
        {
            SQLUtility.SaveDataTable(dt, tablename + "Update");
        }

        public static void DeleteRow(string tablename, int id)
        {
            SqlCommand cmd = SQLUtility.GetSQLCommand(tablename + "Delete");
            SQLUtility.SetParamValue(cmd, $"@{tablename}ID", id);
            SQLUtility.ExecuteSQL(cmd);
        }       

    }
}

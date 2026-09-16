using CPUFramework;

namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLUtility.SetConnString(connectionstring, true);
        }

        public static void SetConnectionString(string connectionstring, string userid, string password)
        {
            SQLUtility.SetConnString(connectionstring, true, userid, password);
        }
    }
}

    
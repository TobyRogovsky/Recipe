using CPUFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(string connectionstring)
        {
            SQLUtility.ConnectionString = connectionstring;
        }

    }
}

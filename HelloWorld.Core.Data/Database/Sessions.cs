using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.Data.Database
{
    class Sessions
    {
        public static Sessions GetSessions
        {
            get
            {
                if(instance == null)
                {
                    instance = new Sessions();
                }

                return instance;
            }
        }

        protected DatabaseConnection GetDatabaseConnection()
        {
            return databaseConnection;
        }

        private Sessions()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseContext"].ToString();
            databaseConnection = new DatabaseConnection(new System.Data.SqlClient.SqlConnection(connectionString)); 
        }

        private static Sessions instance { get; set; }
        private DatabaseConnection databaseConnection { get; set; }
    }
}

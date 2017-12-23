using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Core.Data.Database
{
    class DatabaseConnection
    {
        public DatabaseConnection(SqlConnection Connection)
        {
            this.Connection = Connection;
        }

        private SqlConnection Connection { get; set; }
    }
}

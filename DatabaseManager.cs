using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GabdushevDB_InterfaceAppProject
{
    class DatabaseManager
    {
        public readonly MySqlConnection connection;

        public DatabaseManager()
        {
            connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=gabdushevdb;");
        }

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}

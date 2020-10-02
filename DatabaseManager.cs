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
        private MySqlConnection _connection;

        public MySqlConnection connection { get => _connection; }

        public DatabaseManager()
        {
            _connection = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=gabdushevdb;");
        }

        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}

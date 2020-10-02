using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabdushevDB_InterfaceAppProject
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        public static DatabaseManager database;


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HubForm());
        }

        public static void InitializeDB()
        {
            database = new DatabaseManager();
            database.OpenConnection();
        }
    }
}

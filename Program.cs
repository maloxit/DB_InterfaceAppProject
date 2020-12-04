using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabdushevDB_InterfaceAppProject
{
    struct Globals{
        public int id;
        public decimal budget;
        public DateTime cur_date;
        public DateTime last_update_date;
    };
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            databaseManager = new DatabaseManager();
            ReloadDatabaseGlobals();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new HubForm());
        }

        static DatabaseManager databaseManager;

        public static Globals globals;

        public static void ReloadDatabaseGlobals()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectGlobals, databaseManager.connection);
            MySqlDataReader dataReader;
            globals.id = 0;
            globals.budget = 0M;
            globals.cur_date = DateTime.MinValue;
            globals.last_update_date = DateTime.MinValue;

            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                String[] values = new String[2];
                dataReader.Read();
                globals.id = dataReader.GetInt32("id");
                globals.budget = dataReader.GetDecimal("budget");
                globals.cur_date = dataReader.GetDateTime("cur_date");
                globals.last_update_date = dataReader.GetDateTime("last_update_date");
            }
            catch
            {
                globals.id = int.MinValue;
                globals.budget = decimal.MinValue;
                globals.cur_date = DateTime.MinValue;
                globals.last_update_date = DateTime.MinValue;
                MessageBox.Show("error");
            }
            finally
            {
                databaseManager.CloseConnection();
            }
        }
        class ActiveOrderRow
        {
            public int orderId;
            public int truckId;
            public int daysFromStart;
            public int emptyTransDays;
            public int loadedTransDays;
            public int unloadCityId;
            public int upToDateTruckStatusId;
            public bool isFinished;
        }
        class TruckDowntimeRow
        {
            public decimal downtimeCostPrDay;
            public int downtimeDaysCount;
        }
        public static void ProcessDateUpdate()
        {
            int dateDiff = Convert.ToInt32(globals.cur_date.Subtract(globals.last_update_date).TotalDays);
            Dictionary<int, TruckDowntimeRow> trucksDowntimeDict = new Dictionary<int, TruckDowntimeRow>();
            List<ActiveOrderRow> activeOrderRows = new List<ActiveOrderRow>();
            MySqlCommand sqlCommand1 = new MySqlCommand("", databaseManager.connection);
            MySqlCommand sqlCommand2 = new MySqlCommand("", databaseManager.connection);
            MySqlCommand sqlCommand3 = new MySqlCommand("", databaseManager.connection);
            MySqlCommand sqlCommand4 = new MySqlCommand("", databaseManager.connection);
            MySqlDataReader dataReader;
            try
            {
                sqlCommand1.CommandText = "SELECT `trucks`.`id`, `trucks`.`downtime_cost_pr_d` FROM `trucks` WHERE `trucks`.`truck_status_id` IN ('1','2','3')";
                sqlCommand2.CommandText = "SELECT `orders`.`id`, `orders`.`truck_id`, DATEDIFF( `globals`.`cur_date`, `orders`.`order_date` ) AS D, " +
                    "`route1`.`days`, `route2`.`days`, `orders`.`unload_city_id` FROM `globals`, `orders` " +
                    "JOIN `routes` AS `route1` ON `orders`.`start_city_id` = `route1`.`departure_city_id` AND `orders`.`load_city_id` = `route1`.`destination_city_id` " +
                    "JOIN `routes` AS `route2` ON `orders`.`load_city_id` = `route2`.`departure_city_id` AND `orders`.`unload_city_id` = `route2`.`destination_city_id` " +
                    "WHERE `orders`.`order_status_id` = 1";
                databaseManager.OpenConnection();
                dataReader = sqlCommand1.ExecuteReader();
                while (dataReader.Read())
                {
                    trucksDowntimeDict.Add(dataReader.GetInt32(0), new TruckDowntimeRow { downtimeCostPrDay = dataReader.GetDecimal(1), downtimeDaysCount = dateDiff });
                }
                dataReader.Close();
                dataReader = sqlCommand2.ExecuteReader();
                while (dataReader.Read())
                {
                    activeOrderRows.Add(new ActiveOrderRow {orderId = dataReader.GetInt32(0), truckId = dataReader.GetInt32(1), daysFromStart = dataReader.GetInt32(2), emptyTransDays = dataReader.GetInt32(3), loadedTransDays = dataReader.GetInt32(4), unloadCityId = dataReader.GetInt32(5), upToDateTruckStatusId = 0, isFinished = false});
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                databaseManager.CloseConnection();
            }

            foreach (var aor in activeOrderRows)
            {
                if (aor.daysFromStart < aor.emptyTransDays)
                {
                    aor.upToDateTruckStatusId = 2;
                    trucksDowntimeDict.Remove(aor.truckId);
                }
                else if (aor.daysFromStart < aor.emptyTransDays + aor.loadedTransDays)
                {
                    aor.upToDateTruckStatusId = 3;
                    trucksDowntimeDict.Remove(aor.truckId);
                }
                else
                {
                    aor.isFinished = true;
                    trucksDowntimeDict[aor.truckId].downtimeDaysCount = aor.daysFromStart - aor.emptyTransDays - aor.loadedTransDays;
                }
            }

            sqlCommand1.CommandText = "";
            sqlCommand2.CommandText = "";

            
            try
            {
                
                foreach (var aor in activeOrderRows)
                {
                
                    if (aor.isFinished)
                    {
                        sqlCommand1.CommandText += $"UPDATE `orders` SET `order_status_id` = '2' WHERE `orders`.`id` = @order_id{ aor.orderId }; ";
                        sqlCommand1.Parameters.AddWithValue($"@order_id{ aor.orderId }", aor.orderId);
                        sqlCommand2.CommandText += $"UPDATE `trucks` SET `city_id` = @city_id{ aor.orderId }, `truck_status_id` = '1' WHERE `trucks`.`id` = @truck_id{ aor.orderId }; ";
                        sqlCommand2.Parameters.AddWithValue($"@truck_id{ aor.orderId }", aor.truckId);
                        sqlCommand2.Parameters.AddWithValue($"@city_id{ aor.orderId }", aor.unloadCityId);
                    }
                    else
                    {
                        sqlCommand2.CommandText += $"UPDATE `trucks` SET `truck_status_id` = @truck_status_id{ aor.orderId } WHERE `trucks`.`id` = @truck_id{ aor.orderId }; ";
                        sqlCommand2.Parameters.AddWithValue($"@truck_id{ aor.orderId }", aor.truckId);
                        sqlCommand2.Parameters.AddWithValue($"@truck_status_id{ aor.orderId }", aor.upToDateTruckStatusId);
                    }
                }
                decimal overallDowntimeCost = 0;
                foreach (var tdr in trucksDowntimeDict)
                {
                    if (tdr.Value.downtimeDaysCount > 0)
                    {
                        sqlCommand3.CommandText += $"INSERT INTO `truck_money_trans` (`id`, `value`, `trans_date`, `truck_id`, `truck_money_trans_type_id`) VALUES (NULL, @value{ tdr.Key }, (SELECT `globals`.`cur_date` FROM `globals` WHERE `globals`.`id` = 1), @truck_id{ tdr.Key }, '1'); ";
                        sqlCommand3.Parameters.AddWithValue($"@value{ tdr.Key }", -tdr.Value.downtimeCostPrDay * tdr.Value.downtimeDaysCount);
                        overallDowntimeCost += tdr.Value.downtimeCostPrDay * tdr.Value.downtimeDaysCount;
                        sqlCommand3.Parameters.AddWithValue($"@truck_id{ tdr.Key }", tdr.Key);
                    }
                }

                sqlCommand4.CommandText = DatabaseCommandStringsMamager.updateGlobalBudget + "; " + DatabaseCommandStringsMamager.updateGlobalLastUpdateDateToCurrent;

                sqlCommand4.Parameters.AddWithValue("@budget", Program.globals.budget - overallDowntimeCost);

                databaseManager.OpenConnection();
                if (sqlCommand1.CommandText != "")
                {
                    sqlCommand1.ExecuteNonQuery();
                }
                if (sqlCommand2.CommandText != "")
                {
                    sqlCommand2.ExecuteNonQuery();
                }
                if (sqlCommand3.CommandText != "")
                {
                    sqlCommand3.ExecuteNonQuery();
                }
                if (sqlCommand4.CommandText != "")
                {
                    sqlCommand4.ExecuteNonQuery();
                }

            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                databaseManager.CloseConnection();
                ReloadDatabaseGlobals();
            }
        }
    }
}

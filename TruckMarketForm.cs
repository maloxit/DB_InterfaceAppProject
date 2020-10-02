using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GabdushevDB_InterfaceAppProject
{
    public partial class TruckMarketForm : ChildForm
    {
        private DataGridViewColumn[] sellTruckGridViewColumns;
        private DataGridViewColumn[] buyTruckGridViewColumns;
        
        
        private DatabaseManager databaseManager;

        public TruckMarketForm()
        {
            
            InitializeComponent();
            databaseManager = new DatabaseManager();
            SellTruckGridView_Initialize();
            BuyTruckGridView_Initialize();

        }

        private void SellTruckGridView_Initialize()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `trucks`.`id`, `trucks`.`model`, `cargo_forms`.`name` AS `cargo_form`, `trucks`.`lift_capacity`, `trucks`.`price`, `trucks`.`downtime_cost_pr_d`, `trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d`, `cit`.`city_name` FROM `trucks` LEFT JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` LEFT JOIN( SELECT `cities`.`city_name`, `routes`.`id` FROM `routes` LEFT JOIN `cities` ON `routes`.`departure_city_id` = `cities`.`id` WHERE `routes`.`departure_city_id` = `routes`.`destination_city_id` ) `cit` ON `trucks`.`route_id` = `cit`.`id` WHERE `truck_statuses`.`name` = \"Простой\" ORDER BY `id` ASC", databaseManager.connection);
            MySqlDataReader dataReader;
            sellTruckGridViewColumns = new DataGridViewColumn[]{
                new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    HeaderText = "Код",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "model",
                    HeaderText = "Модель",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "cargo_form",
                    HeaderText = "Форма груза",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "lift_capacity",
                    HeaderText = "Грузоподъемность",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "price",
                    HeaderText = "Цена",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "downtime_cost_pr_d",
                    HeaderText = "Расходы на день простоя",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "transportation_cost_pr_d",
                    HeaderText = "Расходы на день трассе с грузом",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "empty_transp_cost_pr_d",
                    HeaderText = "Расходы на день трассе порожняком",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "city_name",
                    HeaderText = "Город стоянки",
                }
            };
            sellTruckGridView.Columns.AddRange(sellTruckGridViewColumns);
            sellTruckGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sellTruckGridView.MultiSelect = false;
            sellTruckGridView.ReadOnly = true;

            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                object[] values = new object[sellTruckGridViewColumns.Length];
                while (dataReader.Read())
                {
                    dataReader.GetValues(values);
                    sellTruckGridView.Rows.Add(values);
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
        }

        private void BuyTruckGridView_Initialize()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `trucks`.`id`, `trucks`.`model`, `cargo_forms`.`name` AS `cargo_form`, `trucks`.`lift_capacity`, `trucks`.`price`, `trucks`.`downtime_cost_pr_d`, `trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d` FROM `trucks` LEFT JOIN `cargo_forms` ON `trucks`.`cargo_form_id` = `cargo_forms`.`id` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` WHERE `truck_statuses`.`name` = \"Продан/Не куплен\" ORDER BY `id` ASC", databaseManager.connection);
            MySqlDataReader dataReader;
            buyTruckGridViewColumns = new DataGridViewColumn[]{
                new DataGridViewTextBoxColumn
                {
                    Name = "id",
                    HeaderText = "Код",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "model",
                    HeaderText = "Модель",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "cargo_form",
                    HeaderText = "Форма груза",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "lift_capacity",
                    HeaderText = "Грузоподъемность",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "price",
                    HeaderText = "Цена",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "downtime_cost_pr_d",
                    HeaderText = "Расходы на день простоя",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "transportation_cost_pr_d",
                    HeaderText = "Расходы на день трассе с грузом",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "empty_transp_cost_pr_d",
                    HeaderText = "Расходы на день трассе порожняком",
                }
            };
            buyTruckGridView.Columns.AddRange(buyTruckGridViewColumns);
            buyTruckGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            buyTruckGridView.MultiSelect = false;
            buyTruckGridView.ReadOnly = true;

            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                object[] values = new object[buyTruckGridViewColumns.Length];
                while (dataReader.Read())
                {
                    dataReader.GetValues(values);
                    buyTruckGridView.Rows.Add(values);
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
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TruckMarketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GoBack();
        }
    }
}

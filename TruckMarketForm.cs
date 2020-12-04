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
    public partial class TruckMarketForm : Form
    {
        private DataGridViewColumn[] sellTruckDataGridViewColumns;
        private DataGridViewColumn[] buyTruckDataGridViewColumns;
        
        
        private readonly DatabaseManager databaseManager;
        private readonly Dictionary<String, String> citiesDict;

        private DialogResult result;

        public TruckMarketForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            citiesDict = new Dictionary<string, string>();
            SellTruckDataGridView_Initialize();
            BuyTruckDataGridView_Initialize();
            SellTruckDataGridView_Update();
            BuyTruckDataGridView_Update();
            CitiesListBox_Update();
            GlobalsLabelText_Update();
            result = DialogResult.Cancel;
        }

        public void GlobalsLabelText_Update()
        {
            globalsLabel.Text = "Бюджет: " + Program.globals.budget.ToString() + " руб.; Текущая дата: " + Program.globals.cur_date.ToShortDateString() + ";";
        }

        private void SellTruckDataGridView_Initialize()
        {
            sellTruckDataGridViewColumns = new DataGridViewColumn[]{
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
            sellTruckDataGridView.Columns.AddRange(sellTruckDataGridViewColumns);
        }

        private void SellTruckDataGridView_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectTrucksForSelling, databaseManager.connection);
            MySqlDataReader dataReader;
            sellTruckDataGridView.Rows.Clear();
            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                object[] values = new object[sellTruckDataGridViewColumns.Length];
                while (dataReader.Read())
                {
                    dataReader.GetValues(values);
                    sellTruckDataGridView.Rows.Add(values);
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

        private void BuyTruckDataGridView_Initialize()
        {
            buyTruckDataGridViewColumns = new DataGridViewColumn[]{
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
            buyTruckDataGridView.Columns.AddRange(buyTruckDataGridViewColumns);
        }

        private void BuyTruckDataGridView_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectTrucksForBuying, databaseManager.connection);
            MySqlDataReader dataReader;
            buyTruckDataGridView.Rows.Clear();
            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                object[] values = new object[buyTruckDataGridViewColumns.Length];
                while (dataReader.Read())
                {
                    dataReader.GetValues(values);
                    buyTruckDataGridView.Rows.Add(values);
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

        private void CitiesListBox_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectCities, databaseManager.connection);
            MySqlDataReader dataReader;
            citiesListBox.Items.Clear();
            citiesDict.Clear();
            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                String[] values = new String[2];
                while (dataReader.Read())
                {
                    citiesDict.Add(dataReader.GetValue(1).ToString(), dataReader.GetValue(0).ToString());
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
            citiesListBox.Items.AddRange(citiesDict.Keys.ToArray());
            citiesListBox.SelectedIndex = 0;
        }

        private void SellTruckButton_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCommand1 = new MySqlCommand(DatabaseCommandStringsMamager.insertTruckSellMoneyTrans, databaseManager.connection);
            MySqlCommand sqlCommand2 = new MySqlCommand(DatabaseCommandStringsMamager.updateTruckToSold, databaseManager.connection);
            MySqlCommand sqlCommand3 = new MySqlCommand(DatabaseCommandStringsMamager.updateGlobalBudget, databaseManager.connection);
            try
            {
                //@value, @trans_date,  @truck_id
                sqlCommand1.Parameters.AddWithValue("@truck_id", int.Parse(sellTruckDataGridView.SelectedRows[0].Cells["id"].Value.ToString()));
                sqlCommand1.Parameters.AddWithValue("@trans_date", Program.globals.cur_date.Date);
                sqlCommand1.Parameters.AddWithValue("@value", decimal.Parse(sellTruckDataGridView.SelectedRows[0].Cells["price"].Value.ToString()));

                //@truck_id
                sqlCommand2.Parameters.AddWithValue("@truck_id", int.Parse(sellTruckDataGridView.SelectedRows[0].Cells["id"].Value.ToString()));

                //@truck_id
                sqlCommand3.Parameters.AddWithValue("@budget", Program.globals.budget + decimal.Parse(sellTruckDataGridView.SelectedRows[0].Cells["price"].Value.ToString()));

                databaseManager.OpenConnection();

                if (sqlCommand1.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error");
                }
                if (sqlCommand2.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error");
                }
                if (sqlCommand3.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error");
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
            result = DialogResult.OK;
            Program.ReloadDatabaseGlobals();
            GlobalsLabelText_Update();
            BuyTruckDataGridView_Update();
            SellTruckDataGridView_Update();
        }

        private void AddOfferButton_Click(object sender, EventArgs e)
        {
            DialogResult result =  new TruckMarketAddForm().ShowDialog(this);
            switch (result)
            {
                case DialogResult.OK:
                    BuyTruckDataGridView_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }

        private void BuyTruckButton_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCommand1 = new MySqlCommand(DatabaseCommandStringsMamager.insertTruckBuyMoneyTrans, databaseManager.connection);
            MySqlCommand sqlCommand2 = new MySqlCommand(DatabaseCommandStringsMamager.updateTruckToBought, databaseManager.connection);
            MySqlCommand sqlCommand3 = new MySqlCommand(DatabaseCommandStringsMamager.updateGlobalBudget, databaseManager.connection);
            try
            {
                //@value, @trans_date,  @truck_id
                sqlCommand1.Parameters.AddWithValue("@truck_id", int.Parse(buyTruckDataGridView.SelectedRows[0].Cells["id"].Value.ToString()));
                sqlCommand1.Parameters.AddWithValue("@trans_date", Program.globals.cur_date.Date);
                sqlCommand1.Parameters.AddWithValue("@value", -decimal.Parse(buyTruckDataGridView.SelectedRows[0].Cells["price"].Value.ToString()));

                //@city_id, @truck_id
                sqlCommand2.Parameters.AddWithValue("@city_id", citiesDict[citiesListBox.SelectedItem.ToString()]);
                sqlCommand2.Parameters.AddWithValue("@truck_id", int.Parse(buyTruckDataGridView.SelectedRows[0].Cells["id"].Value.ToString()));

                //@budget
                sqlCommand3.Parameters.AddWithValue("@budget", Program.globals.budget - decimal.Parse(buyTruckDataGridView.SelectedRows[0].Cells["price"].Value.ToString()));

                databaseManager.OpenConnection();

                if (sqlCommand1.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error1");
                }
                if (sqlCommand2.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error2");
                }
                if (sqlCommand3.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error3");
                }
            }
            catch
            {
                MessageBox.Show("errorBig");
            }
            finally
            {
                databaseManager.CloseConnection();
            }
            result = DialogResult.OK;
            Program.ReloadDatabaseGlobals();
            GlobalsLabelText_Update();
            BuyTruckDataGridView_Update();
            SellTruckDataGridView_Update();
        }

        private void TruckMarketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}

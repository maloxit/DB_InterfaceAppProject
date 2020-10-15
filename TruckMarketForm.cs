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
        
        
        private readonly DatabaseManager databaseManager;
        private readonly Dictionary<String, String> citiesDict;

        public TruckMarketForm()
        {
            
            InitializeComponent();
            databaseManager = new DatabaseManager();
            citiesDict = new Dictionary<string, string>();
            SellTruckGridView_Initialize();
            BuyTruckGridView_Initialize();
        }

        private void SellTruckGridView_Initialize()
        {
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

            
        }

        private void SellTruckGridView_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectTrucksForSelling, databaseManager.connection);
            MySqlDataReader dataReader;
            sellTruckGridView.Rows.Clear();
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
        }

        private void BuyTruckGridView_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectTrucksForBuying, databaseManager.connection);
            MySqlDataReader dataReader;
            buyTruckGridView.Rows.Clear();
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
        }

        protected void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TruckMarketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GoBack();
        }

        private void TruckMarketForm_Load(object sender, EventArgs e)
        {
            SellTruckGridView_Update();
            BuyTruckGridView_Update();
            CitiesListBox_Update();
        }

        private void SellTruckButton_Click(object sender, EventArgs e)
        {

        }

        private void AddOfferButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChildForm child = new TruckMarketAddForm();
            child.ChildFormGoBack += ChildFormGoBackHandler;
            child.Show();
        }

        private void BuyTruckButton_Click(object sender, EventArgs e)
        {

        }
        public void ChildFormGoBackHandler(ChildForm obj)
        {
            obj.ChildFormGoBack -= ChildFormGoBackHandler;
            this.Show();
            BuyTruckGridView_Update();
        }
    }
}

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
    public partial class OrderForm : Form
    {

        private DataGridViewColumn[] truckDataGridViewColumns;

        struct CargoTypeAndForm
        {
            public int cargoTypeId;
            public int cargoFormId;
            public decimal transCost;
        }

        struct CargoParams
        {
            public CargoTypeAndForm typeAndForm;
            public decimal weight;
            public int loadCityId;
            public int unloadCityId;
            public int loadedTransRouteId;
            public int loadedTransRouteDays;
        }

        struct TrunsParams
        {
            public int startCityId;
            public int selectedTruckId;
            public int emptyTransRouteId;
            public int emptyTransRouteDays;
            public decimal loadedTransCostPerDay;
            public decimal emptyTransCostPerDay;
        }

        struct TruckRow
        {
            public int id;
            public string model;
            public decimal liftCapacity;
            public decimal loadedTransCostPerDay;
            public decimal emptyTransCostPerDay;
            public int cityId;
            public string cityName;
        }

        private readonly Dictionary<string, CargoTypeAndForm> cargoTypeAndFormIdDict;

        private readonly Dictionary<string, int> cityIdDict;

        private readonly Dictionary<string, TruckRow> truckRows;

        private readonly DatabaseManager databaseManager;

        private DialogResult result;

        private CargoParams fixedCargoParams;

        private TrunsParams trunsParams;

        public OrderForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            cargoTypeAndFormIdDict = new Dictionary<string, CargoTypeAndForm>();
            truckRows = new Dictionary<string, TruckRow>();
            cityIdDict = new Dictionary<string, int>();
            CargoParamsGroupBox_Initialize();
            TruckDataGridView_Initialize();
            result = DialogResult.Cancel;
            GlobalsLabelText_Update();
        }

        public void GlobalsLabelText_Update()
        {
            globalsLabel.Text = "Бюджет: " + Program.globals.budget.ToString() + " руб.; Текущая дата: " + Program.globals.cur_date.ToShortDateString() + ";";
        }

        private void CargoParamsGroupBox_Initialize()
        {
            CargoTypeComboBox_Initialize();
            LoadUnloadCityComboBox_Initialize();
        }

        private void CargoTypeComboBox_Initialize()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `cargo_types`.`id`, `cargo_types`.`name`, `cargo_forms`.`id`, `cargo_forms`.`name`, `cargo_types`.`transportation_cost` " +
                "FROM `cargo_types` LEFT JOIN `cargo_forms` ON `cargo_types`.`cargo_form_id` = `cargo_forms`.`id`", databaseManager.connection);
            MySqlDataReader dataReader;
            cargoTypeComboBox.Items.Clear();
            cargoTypeAndFormIdDict.Clear();
            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cargoTypeAndFormIdDict.Add("(" + dataReader.GetString(3) + ")" + dataReader.GetString(1), new CargoTypeAndForm 
                    { 
                        cargoTypeId = dataReader.GetInt32(0), 
                        cargoFormId = dataReader.GetInt32(2), 
                        transCost = dataReader.GetDecimal(4) 
                    });
                }
            }
            catch
            {
                result = DialogResult.Abort;
            }
            finally
            {
                databaseManager.CloseConnection();
            }
            if (result == DialogResult.Abort)
            {
                Close();
            }
            else
            {
                cargoTypeComboBox.Items.AddRange(cargoTypeAndFormIdDict.Keys.ToArray());
            }
        }

        private void LoadUnloadCityComboBox_Initialize()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectCities, databaseManager.connection);
            MySqlDataReader dataReader;
            loadCityComboBox.Items.Clear();
            unloadCityComboBox.Items.Clear();
            cityIdDict.Clear();
            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cityIdDict.Add(dataReader.GetString(1), dataReader.GetInt32(0));
                }
            }
            catch
            {
                result = DialogResult.Abort;
            }
            finally
            {
                databaseManager.CloseConnection();
            }
            if (result == DialogResult.Abort)
            {
                Close();
            }
            else
            {
                loadCityComboBox.Items.AddRange(cityIdDict.Keys.ToArray());
                unloadCityComboBox.Items.AddRange(cityIdDict.Keys.ToArray());
            }
        }

        private void TruckDataGridView_Initialize()
        {
            truckDataGridViewColumns = new DataGridViewColumn[]{
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
                    Name = "lift_capacity",
                    HeaderText = "Грузоподъемность",
                },
                new DataGridViewTextBoxColumn
                {
                    Name = "city_name",
                    HeaderText = "Город стоянки",
                }
            };
            truckDataGridView.Columns.AddRange(truckDataGridViewColumns);
        }

        private void TruckDataGridView_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `trucks`.`id`, `trucks`.`model`, `trucks`.`lift_capacity`, " +
                "`trucks`.`transportation_cost_pr_d`, `trucks`.`empty_transp_cost_pr_d`, `trucks`.`city_id`, `cities`.`city_name` " +
                "FROM `trucks` LEFT JOIN `truck_statuses` ON `trucks`.`truck_status_id` = `truck_statuses`.`id` LEFT JOIN `cities` ON `trucks`.`city_id` = `cities`.`id` " +
                "WHERE `truck_statuses`.`name` = \"Простой\" AND `trucks`.`cargo_form_id` = @cargo_form_id AND `trucks`.`lift_capacity` >= @min_lift ORDER BY `id` ASC", databaseManager.connection);
            MySqlDataReader dataReader;
            truckDataGridView.Rows.Clear();
            truckRows.Clear();
            try
            {
                //@cargo_form_id @min_lift
                sqlCommand.Parameters.AddWithValue("@cargo_form_id", fixedCargoParams.typeAndForm.cargoFormId);
                sqlCommand.Parameters.AddWithValue("@min_lift", fixedCargoParams.weight);
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    truckRows.Add(dataReader.GetInt32(0).ToString(), new TruckRow 
                    {
                        id = dataReader.GetInt32(0),
                        model = dataReader.GetString(1),
                        liftCapacity = dataReader.GetDecimal(2),
                        loadedTransCostPerDay = dataReader.GetDecimal(3),
                        emptyTransCostPerDay = dataReader.GetDecimal(4),
                        cityId = dataReader.GetInt32(5),
                        cityName = dataReader.GetString(6)
                    });
                }
            }
            catch
            {
                MessageBox.Show("error");
            }
            finally
            {
                databaseManager.CloseConnection();
                foreach (KeyValuePair<string, TruckRow> row in truckRows)
                {
                    truckDataGridView.Rows.Add(row.Value.id, row.Value.model, row.Value.liftCapacity, row.Value.cityName);
                }
            }
        }

        protected void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = result;
        }

        private void CargoParamsButton_Click(object sender, EventArgs e)
        {
            if (cargoParamsButton.Text == "Далее")
            {
                if (IsCargoParamsCorect())
                {
                    cargoParamsButton.Text = "Редактировать";
                    cargoParamsGroupBox.Enabled = false;
                    truckSelectGroupBox.Enabled = true;
                    finishButton.Enabled = true;
                    fixedCargoParams.typeAndForm = cargoTypeAndFormIdDict[cargoTypeComboBox.SelectedItem.ToString()];
                    fixedCargoParams.weight = cargoWeightNumericUpDown.Value;
                    fixedCargoParams.loadCityId = cityIdDict[loadCityComboBox.SelectedItem.ToString()];
                    fixedCargoParams.unloadCityId = cityIdDict[unloadCityComboBox.SelectedItem.ToString()];
                    if(FindRoute(fixedCargoParams.loadCityId, fixedCargoParams.unloadCityId, out fixedCargoParams.loadedTransRouteId, out fixedCargoParams.loadedTransRouteDays))
                    {
                        TruckDataGridView_Update();
                    }
                }
                else
                {
                    MessageBox.Show("Введите коректные параметры груза!");
                }
            }
            else
            {
                cargoParamsButton.Text = "Далее";
                cargoParamsGroupBox.Enabled = true;
                truckSelectGroupBox.Enabled = false;
                finishButton.Enabled = false;
                truckDataGridView.Rows.Clear();
                TrunsLabels_Clear();
            }
            
        }

        private bool FindRoute(int departureCityId, int destinationCityId, out int routeId, out int routeDays)
        {
            MySqlCommand sqlCommand = new MySqlCommand("SELECT `routes`.* FROM `routes` " +
                "WHERE `routes`.`departure_city_id` = @departure_city_id AND `routes`.`destination_city_id` = @destination_city_id", databaseManager.connection);
            MySqlDataReader reader;

            try
            {
                //@departure_city_id @destination_city_id
                sqlCommand.Parameters.AddWithValue("@departure_city_id", departureCityId);
                sqlCommand.Parameters.AddWithValue("@destination_city_id", destinationCityId);

                databaseManager.OpenConnection();

                reader = sqlCommand.ExecuteReader();

                if (reader.Read())
                {
                    routeId = reader.GetInt32(0);
                    routeDays = reader.GetInt32(3);
                }
                else
                {
                    throw new Exception();
                }
            }
            catch
            {
                MessageBox.Show("Путь отсутствует!");
                routeId = 0;
                routeDays = 0;
                return false;
            }
            finally
            {
                databaseManager.CloseConnection();
            }
            return true;
        }

        private bool IsCargoParamsCorect()
        {
            return cargoTypeComboBox.SelectedItem != null && loadCityComboBox.SelectedItem != null && unloadCityComboBox.SelectedItem != null && cargoWeightNumericUpDown.Value >= 1 && loadCityComboBox.SelectedIndex != unloadCityComboBox.SelectedIndex;
        }

        private void truckDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (truckDataGridView.SelectedRows.Count == 1)
            {
                TruckRow row = truckRows[truckDataGridView.SelectedRows[0].Cells["id"].Value.ToString()];
                trunsParams.selectedTruckId = row.id;
                trunsParams.loadedTransCostPerDay = row.loadedTransCostPerDay;
                trunsParams.emptyTransCostPerDay = row.emptyTransCostPerDay;
                trunsParams.startCityId = row.cityId;
                FindRoute(trunsParams.startCityId, fixedCargoParams.loadCityId, out trunsParams.emptyTransRouteId, out trunsParams.emptyTransRouteDays);
                TrunsLabels_Update();
            }
        }

        private void TrunsLabels_Update()
        {
            cargoTransPriceLabel.Text = (fixedCargoParams.typeAndForm.transCost * fixedCargoParams.loadedTransRouteDays * fixedCargoParams.weight).ToString() + " руб";
            deliveryDateLabel.Text = Program.globals.cur_date.AddDays(fixedCargoParams.loadedTransRouteDays + trunsParams.emptyTransRouteDays).ToShortDateString();
            deliveryCostLabel.Text = (fixedCargoParams.loadedTransRouteDays * trunsParams.loadedTransCostPerDay + trunsParams.emptyTransRouteDays * trunsParams.emptyTransCostPerDay).ToString() + " руб";
            emptyDistPercentLabel.Text = ((double)trunsParams.emptyTransRouteDays / (trunsParams.emptyTransRouteDays + fixedCargoParams.loadedTransRouteDays)).ToString("%#0.00");
            incomeLabel.Text = ((fixedCargoParams.typeAndForm.transCost * fixedCargoParams.loadedTransRouteDays * fixedCargoParams.weight)-(fixedCargoParams.loadedTransRouteDays * trunsParams.loadedTransCostPerDay + trunsParams.emptyTransRouteDays * trunsParams.emptyTransCostPerDay)).ToString() + " руб";
        }

        private void TrunsLabels_Clear()
        {
            cargoTransPriceLabel.Text = "NONE";
            deliveryDateLabel.Text = "NONE";
            deliveryCostLabel.Text = "NONE";
            emptyDistPercentLabel.Text = "NONE";
            incomeLabel.Text = "NONE";
        }

        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (truckDataGridView.SelectedRows.Count == 1)
            {
                CreateOrder();
            }
            else
            {
                MessageBox.Show("Нет свободных подходящих машин!");
            }
        }

        private void CreateOrder()
        {
            UInt64 order_id;
            MySqlCommand insertOrder = new MySqlCommand(DatabaseCommandStringsMamager.insertOrder, databaseManager.connection);
            MySqlCommand insertOrderPayment = new MySqlCommand(DatabaseCommandStringsMamager.insertOrderMoneyTrans, databaseManager.connection);
            MySqlCommand insertOrderLoadedTransCosts = new MySqlCommand(DatabaseCommandStringsMamager.insertOrderMoneyTrans, databaseManager.connection);
            MySqlCommand insertOrderEmptyTransCosts = new MySqlCommand(DatabaseCommandStringsMamager.insertOrderMoneyTrans, databaseManager.connection);
            MySqlCommand updateBudget = new MySqlCommand(DatabaseCommandStringsMamager.updateGlobalBudget, databaseManager.connection);
            MySqlCommand updateTruckToExecutingOrder = new MySqlCommand(DatabaseCommandStringsMamager.updateTruckToExecutingOrder, databaseManager.connection);
            try
            {
                //@truck_id, @start_city_id, @load_city_id, @unload_city_id, @cargo_type_id, @cargo_weight, @order_date
                insertOrder.Parameters.AddWithValue("@truck_id", trunsParams.selectedTruckId);
                insertOrder.Parameters.AddWithValue("@start_city_id", trunsParams.startCityId);
                insertOrder.Parameters.AddWithValue("@load_city_id", fixedCargoParams.loadCityId);
                insertOrder.Parameters.AddWithValue("@unload_city_id", fixedCargoParams.unloadCityId);
                insertOrder.Parameters.AddWithValue("@cargo_type_id", fixedCargoParams.typeAndForm.cargoTypeId);
                insertOrder.Parameters.AddWithValue("@cargo_weight", fixedCargoParams.weight);
                insertOrder.Parameters.AddWithValue("@order_date", Program.globals.cur_date.Date);

                databaseManager.OpenConnection();
                order_id = (UInt64) insertOrder.ExecuteScalar();


                //@order_id, @value, @trans_date, @order_money_trans_type_id
                insertOrderPayment.Parameters.AddWithValue("@order_id", order_id);
                insertOrderPayment.Parameters.AddWithValue("@value", fixedCargoParams.weight * fixedCargoParams.typeAndForm.transCost * fixedCargoParams.loadedTransRouteDays);
                insertOrderPayment.Parameters.AddWithValue("@trans_date", Program.globals.cur_date.Date);
                insertOrderPayment.Parameters.AddWithValue("@order_money_trans_type_id", 3);

                //@order_id, @value, @trans_date, @order_money_trans_type_id
                insertOrderLoadedTransCosts.Parameters.AddWithValue("@order_id", order_id);
                insertOrderLoadedTransCosts.Parameters.AddWithValue("@value", fixedCargoParams.loadedTransRouteDays * trunsParams.loadedTransCostPerDay);
                insertOrderLoadedTransCosts.Parameters.AddWithValue("@trans_date", Program.globals.cur_date.Date);
                insertOrderLoadedTransCosts.Parameters.AddWithValue("@order_money_trans_type_id", 2);

                //@order_id, @value, @trans_date, @order_money_trans_type_id
                insertOrderEmptyTransCosts.Parameters.AddWithValue("@order_id", order_id);
                insertOrderEmptyTransCosts.Parameters.AddWithValue("@value", trunsParams.emptyTransRouteDays * trunsParams.emptyTransCostPerDay);
                insertOrderEmptyTransCosts.Parameters.AddWithValue("@trans_date", Program.globals.cur_date.Date);
                insertOrderEmptyTransCosts.Parameters.AddWithValue("@order_money_trans_type_id", 1);

                //@budget
                updateBudget.Parameters.AddWithValue("@budget", Program.globals.budget 
                    - fixedCargoParams.loadedTransRouteDays * trunsParams.loadedTransCostPerDay 
                    - trunsParams.emptyTransRouteDays * trunsParams.emptyTransCostPerDay 
                    + fixedCargoParams.weight * fixedCargoParams.typeAndForm.transCost * fixedCargoParams.loadedTransRouteDays);

                // @truck_id, @truck_status_id
                updateTruckToExecutingOrder.Parameters.AddWithValue("@truck_id", trunsParams.selectedTruckId);
                updateTruckToExecutingOrder.Parameters.AddWithValue("@truck_status_id", (trunsParams.emptyTransRouteDays > 0) ? 2 : 3);

                if (insertOrderPayment.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error1");
                }
                if (insertOrderLoadedTransCosts.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error2");
                }
                if (trunsParams.emptyTransRouteDays > 0)
                {
                    if (insertOrderEmptyTransCosts.ExecuteNonQuery() != 1)
                    {
                        MessageBox.Show("error3");
                    }
                }
                if (updateBudget.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error4");
                }
                if (updateTruckToExecutingOrder.ExecuteNonQuery() != 1)
                {
                    MessageBox.Show("error5");
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
            Close();
        }
    }
}

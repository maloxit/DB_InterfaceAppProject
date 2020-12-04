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
    public partial class TruckMarketAddForm : Form
    {
        private readonly DatabaseManager databaseManager;

        private readonly Dictionary<String, String> cargoFormsDict;

        private DialogResult result;

        public TruckMarketAddForm()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            cargoFormsDict = new Dictionary<string, string>();
            result = DialogResult.Cancel;
            CargoFormComboBox_Update();
        }

        private void CargoFormComboBox_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.selectCargoForms, databaseManager.connection);
            MySqlDataReader dataReader;
            cargoFormComboBox.Items.Clear();
            cargoFormsDict.Clear();
            try
            {
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    cargoFormsDict.Add(dataReader.GetValue(1).ToString(), dataReader.GetValue(0).ToString());
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
                cargoFormComboBox.Items.AddRange(cargoFormsDict.Keys.ToArray());
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.insertTruckOffer, databaseManager.connection);
            if (modelTextBox.Text != "" && cargoFormComboBox.SelectedItem != null && liftCapacityNumericUpDown.Value > 0 && priceNumericUpDown.Value > 0 
                && downtimeCostNumericUpDown.Value > 0 && transportationCostNumericUpDown.Value > 0 && emptyTranspCostNumericUpDown.Value > 0)
            {
                try
                {   
                    sqlCommand.Parameters.AddWithValue("@model", modelTextBox.Text);
                    sqlCommand.Parameters.AddWithValue("@cargo_form_id", cargoFormsDict[cargoFormComboBox.SelectedItem.ToString()]);
                    sqlCommand.Parameters.AddWithValue("@lift_capacity", liftCapacityNumericUpDown.Value);
                    sqlCommand.Parameters.AddWithValue("@price", priceNumericUpDown.Value);
                    sqlCommand.Parameters.AddWithValue("@downtime_cost_pr_d", downtimeCostNumericUpDown.Value);
                    sqlCommand.Parameters.AddWithValue("@transportation_cost_pr_d", transportationCostNumericUpDown.Value);
                    sqlCommand.Parameters.AddWithValue("@empty_transp_cost_pr_d", emptyTranspCostNumericUpDown.Value);
                    sqlCommand.Parameters.AddWithValue("@truck_status_id", 4);
                    databaseManager.OpenConnection();

                    if (sqlCommand.ExecuteNonQuery() != 1)
                    {
                        throw new Exception();
                    }
                    result = DialogResult.OK;
                }
                catch
                {
                    result = DialogResult.Abort;
                }
                finally
                {
                    databaseManager.CloseConnection();
                }
                
                Close();
            }
            else
            {
                MessageBox.Show("Введены некоректные данные!");
            }
            
        }

        private void TruckMarketAddForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}

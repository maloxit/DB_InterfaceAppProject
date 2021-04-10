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
    public partial class InformationTableForm : Form
    {
        private readonly InformationTableParametrs parametrs;
        private readonly DatabaseManager databaseManager;
        private DialogResult result;
        private int offset;
        private int rowsOnScreenCount;
        private string baseTitle;


        public InformationTableForm()
        {
            InitializeComponent();
        }

        public InformationTableForm(string title, InformationTableParametrs parametrs)
        {
            this.parametrs = parametrs;
            offset = 0;
            result = DialogResult.Cancel;
            rowsOnScreenCount = this.parametrs.defaultRowsOnScreenCount;
            databaseManager = new DatabaseManager();
            InitializeComponent();
            baseTitle = title;
            rowsOnScreenTextBox.Text = rowsOnScreenCount.ToString();
            InformationGridView_Initialize();
            if (this.parametrs.isPeriodActive)
            {
                periodDropListBox.SelectedIndex = 0;
            }
            else
            {
                periodDropListBox.Enabled = false;
                InformationGridView_Update();
                PageLabel_Update();
            }
        }

        private void InformationGridView_Initialize()
        {
            for (int i = 0; i < parametrs.colomns.Length; i++)
            {
                informationGridView.Columns.Add(parametrs.colomns[i].Item1, parametrs.colomns[i].Item2);
            }
        }

        private void InformationGridView_Update()
        {
            MySqlCommand sqlCommand = new MySqlCommand(parametrs.commandText + $" LIMIT { offset }, { rowsOnScreenCount }", databaseManager.connection);
            MySqlDataReader dataReader;
            informationGridView.Rows.Clear();
            try
            {
                if (parametrs.isPeriodActive)
                {


                    switch (periodDropListBox.SelectedIndex)
                    {
                        case 1:
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "YEAR(" + dfp.Item2 + ") = @year AND QUARTER(" + dfp.Item2 + ") = @quarter");
                            }
                            sqlCommand.Parameters.AddWithValue("@quarter", (Program.globals.cur_date.Month - 1) / 3 + 1);

                            Text = baseTitle + ". Период - " + ((Program.globals.cur_date.Month - 1) / 3 + 1).ToString() + " квартал " + Program.globals.cur_date.Year.ToString() + " года.";
                            break;
                        case 2:
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "YEAR(" + dfp.Item2 + ") = @year");
                            }
                            Text = baseTitle + ". Период - " + Program.globals.cur_date.Year.ToString() + " год.";
                            break;
                        case 0:
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "YEAR(" + dfp.Item2 + ") = @year AND MONTH(" + dfp.Item2 + ") = @month");
                            }
                            sqlCommand.Parameters.AddWithValue("@month", Program.globals.cur_date.Month);
                            Text = baseTitle + ". Период - " + Program.globals.cur_date.Month + "." + Program.globals.cur_date.Year.ToString() + " года.";
                            break;
                        case 3:
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "1");
                            }
                            Text = baseTitle + ". Период - за всё время.";
                            break;
                        default:
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "1");
                            }
                            Text = baseTitle;
                            MessageBox.Show("error");
                            break;
                    }
                    sqlCommand.Parameters.AddWithValue("@year", Program.globals.cur_date.Year);
                }
                else
                {
                    Text = baseTitle;
                }
                databaseManager.OpenConnection();
                dataReader = sqlCommand.ExecuteReader();
                object[] values = new object[parametrs.colomns.Length];
                while (dataReader.Read())
                {
                    dataReader.GetValues(values);
                    informationGridView.Rows.Add(values);
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

        private void InformationTableForm_Load(object sender, EventArgs e)
        {

        }

        private void PrevPageLabel_Click(object sender, EventArgs e)
        {
            offset -= rowsOnScreenCount;
            if (offset < 0)
            {
                offset = 0;
            }
            InformationGridView_Update();
            PageLabel_Update();
        }

        private void NextPageLabel_Click(object sender, EventArgs e)
        {
            offset += rowsOnScreenCount;
            if (offset < 0)
            {
                offset = 0;
            }
            InformationGridView_Update();
            PageLabel_Update();
        }

        private void PageLabel_Update()
        {
            pageLabelMenuItem.Text = "от " + offset.ToString() + " до " + (offset + rowsOnScreenCount).ToString();
        }

        private void InformationTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = result;
        }

        private void updateMenuItem_Click(object sender, EventArgs e)
        {
            InformationGridView_Update();
            PageLabel_Update();
        }

        private void RowsOnScreenTextBox_Leave(object sender, EventArgs e)
        {
            int tmp;
            if (int.TryParse(rowsOnScreenTextBox.Text, out tmp) && tmp <= 500 && tmp > 0 && tmp != rowsOnScreenCount)
            {
                rowsOnScreenCount = tmp;
                offset = 0;
                InformationGridView_Update();
                PageLabel_Update();
            }
            rowsOnScreenTextBox.Text = rowsOnScreenCount.ToString();
            
        }

        private void PeriodDropListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            InformationGridView_Update();
            PageLabel_Update();
        }

        private void pageLabelMenuItem_Click(object sender, EventArgs e)
        {
            offset = 0;
            InformationGridView_Update();
            PageLabel_Update();
        }
    }
}

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
    public partial class ProfitAndLossTableForm : Form
    {
        private readonly InformationTableParametrs parametrs;
        private readonly DatabaseManager databaseManager;
        private DialogResult result;
        private int offset;
        private int rowsOnScreenCount;
        private string baseTitle;


        public ProfitAndLossTableForm()
        {
            InitializeComponent();
        }

        public ProfitAndLossTableForm(string title, InformationTableParametrs parametrs)
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
                        case 0:
                            sqlCommand.CommandText = sqlCommand.CommandText.Replace("@dateFilterQuarter", "`months`.`quarter` = @quarter");
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "YEAR(" + dfp.Item2 + ") = @year AND QUARTER(" + dfp.Item2 + ") = @quarter");
                            }
                            sqlCommand.Parameters.AddWithValue("@quarter", (Program.globals.cur_date.Month - 1) / 3 + 1);

                            Text = baseTitle + ". Период - " + ((Program.globals.cur_date.Month - 1) / 3 + 1).ToString() + " квартал " + Program.globals.cur_date.Year.ToString() + " года.";
                            break;
                        case 1:
                            sqlCommand.CommandText = sqlCommand.CommandText.Replace("@dateFilterQuarter", "(1)");
                            foreach (var dfp in parametrs.dateFilterPairs)
                            {
                                sqlCommand.CommandText = sqlCommand.CommandText.Replace(dfp.Item1, "YEAR(" + dfp.Item2 + ") = @year");
                            }
                            Text = baseTitle + ". Период - " + Program.globals.cur_date.Year.ToString() + " год.";
                            break;
                        default:
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
                decimal incomeSumQ = 0;
                decimal outcomeSumQ = 0;
                decimal difSumQ = 0;
                decimal incomeSumY = 0;
                decimal outcomeSumY = 0;
                decimal difSumY = 0;
                for (int i = 0; i < 12 && dataReader.Read(); i++)
                {
                    dataReader.GetValues(values);
                    incomeSumQ += (decimal)values[2];
                    outcomeSumQ += (decimal)values[3];
                    difSumQ += (decimal)values[4];
                    informationGridView.Rows.Add(values);
                    if (i % 3 == 2)
                    {
                        informationGridView.Rows.Add("*", (i / 3 + 1).ToString() + " квартал", incomeSumQ, outcomeSumQ, difSumQ);
                        informationGridView.Rows.Add(1);
                        incomeSumY += incomeSumQ;
                        outcomeSumY += outcomeSumQ;
                        difSumY += difSumQ;
                        incomeSumQ = 0;
                        outcomeSumQ = 0;
                        difSumQ = 0;
                    }
                }
                if (periodDropListBox.SelectedIndex == 1)
                {
                    informationGridView.Rows.Add("#", "Итого", incomeSumY, outcomeSumY, difSumY);
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

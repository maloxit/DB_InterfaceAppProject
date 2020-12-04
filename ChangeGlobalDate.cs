using MySql.Data.MySqlClient;
using MySql.Data.Types;
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
    public partial class ChangeGlobalDate : Form
    {


        private readonly DatabaseManager databaseManager;

        private DialogResult result;

        public ChangeGlobalDate()
        {
            InitializeComponent();
            databaseManager = new DatabaseManager();
            newDateCalendar.TodayDate = Program.globals.cur_date;
            newDateCalendar.SetDate(Program.globals.cur_date);
            newDateCalendar.MinDate = Program.globals.cur_date;
            result = DialogResult.Cancel;

        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (newDateCalendar.TodayDate == newDateCalendar.SelectionStart)
            {
                MessageBox.Show("Выберете дату, отличную от текущей или нажмите Отмена");
            }
            else
            {
                if (!TryUpdateCurentDate())
                {
                    MessageBox.Show("er");
                }
                Program.ReloadDatabaseGlobals();
                result = DialogResult.OK;
                Program.ProcessDateUpdate();
                Close();
            }
        }

        bool TryUpdateCurentDate()
        {
            bool returnCode = true;
            MySqlCommand sqlCommand = new MySqlCommand(DatabaseCommandStringsMamager.updateGlobalCurDate, databaseManager.connection);
            try
            {
                //@cur_date
                sqlCommand.Parameters.AddWithValue("@cur_date", newDateCalendar.SelectionStart.Date);

                databaseManager.OpenConnection();

                if (sqlCommand.ExecuteNonQuery() != 1)
                {
                    throw new Exception();
                }
            }
            catch
            {
                returnCode = false;
            }
            finally
            {
                databaseManager.CloseConnection();
            }
            return returnCode;
        }

        private void CanselButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeGlobalDate_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = result;
        }
    }
}

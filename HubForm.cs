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
    public partial class HubForm : Form
    {
        public HubForm()
        {
            InitializeComponent();
        }

        private void TruckMarketButton_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult result = new TruckMarketForm().ShowDialog(this);
            Show();
            switch (result)
            {
                case DialogResult.OK:
                    GlobalsLabelText_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            Hide();
            DialogResult result = new OrderForm().ShowDialog(this);
            Show();
            switch (result)
            {
                case DialogResult.OK:
                    GlobalsLabelText_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }

        private void HubForm_Load(object sender, EventArgs e)
        {
            GlobalsLabelText_Update();
        }

        public void GlobalsLabelText_Update()
        {
            globalsLabel.Text = "Бюджет: " + Program.globals.budget.ToString() + " руб.; Текущая дата: " + Program.globals.cur_date.ToShortDateString() + ";";
        }

        private void GlobalsReloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.ReloadDatabaseGlobals();
            GlobalsLabelText_Update();
        }

        private void GlobalsChangeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new ChangeGlobalDate().ShowDialog(this);
            switch (result)
            {
                case DialogResult.OK:
                    GlobalsLabelText_Update();
                    break;
                case DialogResult.Cancel:
                    break;
                default:
                    MessageBox.Show("Ой");
                    break;
            }
        }
    }
}

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
    public partial class OrderForm : ChildForm
    {
        public OrderForm()
        {
            InitializeComponent();
        }
        protected void BackButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GoBack();
        }
    }
}

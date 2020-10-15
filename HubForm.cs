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
        private readonly Dictionary<string, ChildForm.ChildFormConstructor> buttonNameToFormDict = new Dictionary<string, ChildForm.ChildFormConstructor>(5);
        public HubForm()
        {
            InitializeComponent();
            buttonNameToFormDict.Add("truckMarketButton", () => new TruckMarketForm());
            buttonNameToFormDict.Add("orderButton", () => new OrderForm());
        }

        private void FormButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChildForm child = buttonNameToFormDict[(sender as Button).Name]();
            child.ChildFormGoBack += ChildFormGoBackHandler;
            child.Show();
        }

        public void ChildFormGoBackHandler(ChildForm obj)
        {
            obj.ChildFormGoBack -= ChildFormGoBackHandler;
            this.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GermanD
{
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard access = new Dashboard();
            access.Show();
        }

        private void buttonSSales_Click(object sender, EventArgs e)
        {
            Sales access = new Sales();
            access.Show();
        }

        private void buttonSProducts_Click(object sender, EventArgs e)
        {
            Products access = new Products();
            access.Show();
        }

        private void buttonSCustomers_Click(object sender, EventArgs e)
        {
            Customers access = new Customers();
            access.Show();
        }

        private void buttonSSalesReport_Click(object sender, EventArgs e)
        {
            SalesReport access = new SalesReport();
            access.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GermanD
{
    public partial class Products : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlDataAdapter adapter;

        public Products()
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

        private void buttonAddProducts_Click(object sender, EventArgs e)
        {
            AddProducts access = new AddProducts();
            access.Show();
        }

        public void ShowData()
        {
            String query = "SELECT Products_ID, Products_Name, Buying_Price, Sell_Price, Profit, Quantity AS Stock, Quantity_Sold, Category_ID, Suppliers_Name FROM products";
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void buttonAddProducts_Click_1(object sender, EventArgs e)
        {
            AddProducts access = new AddProducts();
            access.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete_Product acess = new Delete_Product();
            acess.Show();
        }

        private void buttonAddProducts_Click_2(object sender, EventArgs e)
        {
            AddProducts acess = new AddProducts();
            acess.Show();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            UpdateProduct acesss = new UpdateProduct();
            acesss.Show();
        }

        private void buttonDashboard_Click_1(object sender, EventArgs e)
        {
            Dashboard acess = new Dashboard();
            acess.Show();
        }

        private void buttonSSales_Click_1(object sender, EventArgs e)
        {
            Sales acess = new Sales();
            acess.Show();
        }

        private void buttonSProducts_Click_1(object sender, EventArgs e)
        {
            Products acess = new Products();
            acess.Show();
        }

        private void buttonSCustomers_Click_1(object sender, EventArgs e)
        {
            Customers acess = new Customers();
            acess.Show();
        }

        private void buttonSSalesReport_Click_1(object sender, EventArgs e)
        {
            SalesReport acess = new SalesReport();
            acess.Show();
        }
    }  
}

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
    public partial class UpdateProduct : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;
        public UpdateProduct()
        {
            InitializeComponent();
        }

        public void ShowData()
        {
            String query = "SELECT * FROM products";
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void ExecuteMyQuery(string query)
        {
            try
            {
                OpenConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Products Updated");
                }
                else
                {
                    MessageBox.Show("Products Not Updated");

                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void buttonUpdate_Click_1(object sender, EventArgs e)
        {
            string updatequery = "UPDATE products SET Category_ID = '" + comboBoxCategory.Text + "',Products_Name = '" + TextBoxProductName.Text + "',Buying_Price = '" + textBoxBPrice.Text + "',Sell_Price = '" + textBoxSPrice.Text + "', Quantity = '" + textBoxStock.Text + "',Suppliers_Name = '" + comboBoxSuppliers.Text + "' WHERE Products_ID = '" + TextBoxProductID.Text + "';";
            ExecuteMyQuery(updatequery);
            ShowData();
        }

        private void buttonForSearch_Click_1(object sender, EventArgs e)
        {
            string search = "SELECT * FROM products WHERE Products_ID = " + textBoxForSearch.Text;
            command = new MySqlCommand(search, connection);
            OpenConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                comboBoxCategory.Text = mdr.GetString("Category_ID").ToString();
                TextBoxProductID.Text = mdr.GetInt32("Products_ID").ToString();
                TextBoxProductName.Text = mdr.GetString("Products_Name");
                textBoxBPrice.Text = mdr.GetString("Buying_Price");
                textBoxSPrice.Text = mdr.GetString("Sell_Price");
                textBoxStock.Text = mdr.GetString("Quantity");
                comboBoxSuppliers.Text = mdr.GetString("Suppliers_Name").ToString();
            }
            else
            {
                MessageBox.Show("Products Not Found");
            }

            CloseConnection();
        }

        private void buttonSProducts_Click(object sender, EventArgs e)
        {
            Products access = new Products();
            access.ShowData();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard access = new Dashboard();
            access.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                comboBoxCategory.Text = row.Cells["Category_ID"].Value.ToString();
                TextBoxProductID.Text = row.Cells["Products_ID"].Value.ToString();
                TextBoxProductName.Text = row.Cells["Products_Name"].Value.ToString();
                textBoxBPrice.Text = row.Cells["Buying_Price"].Value.ToString();
                textBoxSPrice.Text = row.Cells["Sell_Price"].Value.ToString();
                textBoxStock.Text = row.Cells["quantity"].Value.ToString();
                comboBoxSuppliers.Text = row.Cells["Suppliers_Name"].Value.ToString();
            }
        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void buttonSProducts_Click_1(object sender, EventArgs e)
        {
            Products access = new Products();
            access.Show();
        }
    }
}

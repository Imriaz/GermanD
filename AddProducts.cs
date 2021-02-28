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
    public partial class AddProducts : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;

        public AddProducts()
        {
            InitializeComponent();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard access = new Dashboard();
            access.Show();
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
                    MessageBox.Show("Products Added");
                }
                else
                {
                    MessageBox.Show("Products Not Added");

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

        private void AddProducts_Load(object sender, EventArgs e)
        {
            ShowData();

            comboBoxCategory.Items.Clear();
            connection.Open();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Category_ID FROM category";
            command.ExecuteNonQuery();
            DataTable d1 = new DataTable();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter(command);
            adapter1.Fill(d1);
            foreach (DataRow dr in d1.Rows)
            {
                comboBoxCategory.Items.Add(dr["Category_ID"].ToString());
            }

            comboBoxSuppliers.Items.Clear();
            command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT Suppliers_Name FROM suppliers";
            command.ExecuteNonQuery();
            DataTable d2 = new DataTable();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(command);
            adapter2.Fill(d2);
            foreach (DataRow dr1 in d2.Rows)
            {
                comboBoxSuppliers.Items.Add(dr1["Suppliers_Name"].ToString());
            }
            connection.Close();
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

        private void buttonForSearch_Click(object sender, EventArgs e)
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string addquery = "INSERT INTO products(Category_ID,Products_ID,Products_Name,Buying_Price,Sell_Price,Quantity,Suppliers_Name,Arrival_Time) VALUES ('" + comboBoxCategory.Text + "', '" + TextBoxProductID.Text + "', '" + TextBoxProductName.Text + "', '" + textBoxBPrice.Text + "', '" + textBoxSPrice.Text + "', '" + textBoxStock.Text + "', '" + comboBoxSuppliers.Text + "', '"+dateTimePicker1.Text+"')";
            ExecuteMyQuery(addquery);
            ShowData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void buttonSProducts_Click_1(object sender, EventArgs e)
        {
            Products access = new Products();
            access.Show();
        }
    }
}
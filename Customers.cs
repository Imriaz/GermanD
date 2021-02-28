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
    public partial class Customers : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;

        public Customers()
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM germand.customer WHERE Customer_ID = '" + TextBoxCustomer_ID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Category ID not available!");

            }
            else
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=germand;";
                string iquery = "INSERT INTO customer(Customer_ID,Customer_Name,Customer_Email,Customer_Address,Customer_Mobile) VALUES ('" + TextBoxCustomer_ID.Text + "', '" + TextBoxCustomer_Name.Text + "', '" + TextBoxCustomer_Email.Text + "', '" + TextBoxCustomer_Address.Text + "', '" + TextBoxCustomer_Mobile.Text + "')";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                MySqlCommand commandDatabase = new MySqlCommand(iquery, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                try
                {
                    databaseConnection.Open();
                    MySqlDataReader myReader = commandDatabase.ExecuteReader();
                    databaseConnection.Close();
                }
                catch (Exception ex)
                {
                    // Show any error message.
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("Account Successfully Created!");
                ShowData();
            }

            connection.Close();

            if (string.IsNullOrEmpty(TextBoxCustomer_ID.Text) || string.IsNullOrEmpty(TextBoxCustomer_Name.Text))
            {
                MessageBox.Show("Please input Customer ID and Name", "Error");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = "SELECT * FROM customer WHERE Customer_ID = " + TextBoxForSearch.Text;
            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                TextBoxCustomer_ID.Text = mdr.GetInt32("Customer_ID").ToString();
                TextBoxCustomer_Name.Text = mdr.GetString("Customer_Name");
                TextBoxCustomer_Email.Text = mdr.GetString("Customer_Email");
                TextBoxCustomer_Address.Text = mdr.GetString("Customer_Address");
                TextBoxCustomer_Mobile.Text = mdr.GetString("Customer_Mobile");
            }
            else
            {
                MessageBox.Show("Customer Not Found");
            }

            connection.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TextBoxCustomer_ID.Text = row.Cells["Customer_ID"].Value.ToString();
                TextBoxCustomer_Name.Text = row.Cells["Customer_Name"].Value.ToString();
                TextBoxCustomer_Email.Text = row.Cells["Customer_Email"].Value.ToString();
                TextBoxCustomer_Address.Text = row.Cells["Customer_Address"].Value.ToString();
                TextBoxCustomer_Mobile.Text = row.Cells["Customer_Mobile"].Value.ToString();
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        public void ShowData()
        {
            String query = "SELECT * FROM customer";
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
        }
    }
}

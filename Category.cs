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
    public partial class Category : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;

        public Category()
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

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void buttonSLogout_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void buttonAdd_Category_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM germand.category WHERE Category_ID = '" + textBoxCategory_ID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Category ID not available!");

            }
            else
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=germand;";
                string iquery = "INSERT INTO category(Category_ID,Category_Name,Category_Details) VALUES ('" + textBoxCategory_ID.Text + "', '" + TextBoxCategory_Name.Text + "', '" + textBoxCategory_Details.Text + "')";

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
            }

            connection.Close();

            if (string.IsNullOrEmpty(textBoxCategory_ID.Text) || string.IsNullOrEmpty(TextBoxCategory_Name.Text))
            {
                MessageBox.Show("Please input Category ID and Name", "Error");
            }
        }

        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            string search = "SELECT * FROM category WHERE Category_ID = " + textBoxForSearch.Text;
            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBoxCategory_ID.Text = mdr.GetInt32("Category_ID").ToString();
                TextBoxCategory_Name.Text = mdr.GetString("Category_Name");
                textBoxCategory_Details.Text = mdr.GetString("Category_Details");
            }
            else
            {
                MessageBox.Show("Category Not Found");
            }

            connection.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxCategory_ID.Text = row.Cells["Category_ID"].Value.ToString();
                TextBoxCategory_Name.Text = row.Cells["Category_Name"].Value.ToString();
                textBoxCategory_Details.Text = row.Cells["Category_Details"].Value.ToString();
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM category";
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    }
}

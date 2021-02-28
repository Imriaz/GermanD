using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace GermanD
{
    public partial class Suppliers : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;
        DataTable table;

        public Suppliers()
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

        private void buttonAdd_Suppliers_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM germand.suppliers WHERE Suppliers_ID = '" + textBoxSuppliers_ID.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Suppliers ID not available!");

            }
            else
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=germand;";
                string iquery = "INSERT INTO suppliers(Suppliers_ID,Suppliers_Name,Suppliers_Mobile,Suppliers_Details) VALUES ('" + textBoxSuppliers_ID.Text + "', '" + TextBoxSuppliers_Name.Text + "', '" + textBoxSuppliers_Mobile.Text + "', '" + textBoxSuppliers_Details.Text + "')";

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

            if (string.IsNullOrEmpty(textBoxSuppliers_ID.Text) || string.IsNullOrEmpty(TextBoxSuppliers_Name.Text))
            {
                MessageBox.Show("Please input Suppliers ID and Name", "Error");
            }
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            String query = "SELECT * FROM suppliers";
            DataTable table = new DataTable();
            adapter =new MySqlDataAdapter(query,connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxSuppliers_ID.Text = row.Cells["Suppliers_ID"].Value.ToString();
                TextBoxSuppliers_Name.Text = row.Cells["Suppliers_Name"].Value.ToString();
                textBoxSuppliers_Mobile.Text = row.Cells["Suppliers_Mobile"].Value.ToString();
                textBoxSuppliers_Details.Text = row.Cells["Suppliers_Details"].Value.ToString();
            }
        }

        public void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
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

                if(command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Execute");
                }
                else
                {
                    MessageBox.Show("Query Not Execute");

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

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = "SELECT * FROM suppliers WHERE Suppliers_ID = " + textBoxForSearch.Text;
            command = new MySqlCommand(search, connection);
            OpenConnection();
            mdr = command.ExecuteReader();

            if(mdr.Read())
            {
                textBoxSuppliers_ID.Text = mdr.GetInt32("Suppliers_ID").ToString();
                TextBoxSuppliers_Name.Text = mdr.GetString("Suppliers_Name");
                textBoxSuppliers_Mobile.Text = mdr.GetString("Suppliers_Mobile");
                textBoxSuppliers_Details.Text = mdr.GetString("Suppliers_Details");
            }
            else
            {
                MessageBox.Show("Suppliers Not Found");
            }

            CloseConnection();
        }

        private void textBoxForSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

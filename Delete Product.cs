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
    public partial class Delete_Product : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;
        DataTable table;
        public Delete_Product()
        {
            InitializeComponent();
        }

        private void buttonSProducts_Click(object sender, EventArgs e)
        {
            Products acess = new Products();
            acess.Show();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard acess = new Dashboard();
            acess.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
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

        private void Delete_Product_Load(object sender, EventArgs e)
        {
            ShowData();
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
                    MessageBox.Show("Product Deleted");
                }
                else
                {
                    MessageBox.Show("Product Not Deleted");

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string deletequery = "DELETE FROM products WHERE Products_ID = '" + TextBoxProductID.Text + "';";
            ExecuteMyQuery(deletequery);
            ShowData();
        }

        private void buttonForSearch_Click(object sender, EventArgs e)
        {
            string search = "SELECT * FROM products WHERE Products_ID = " + textBoxForSearch.Text;
            command = new MySqlCommand(search, connection);
            OpenConnection();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                TextBoxProductID.Text = mdr.GetInt32("Products_ID").ToString();
            }
            else
            {
                MessageBox.Show("Products Not Found");
            }

            CloseConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                TextBoxProductID.Text = row.Cells["Products_ID"].Value.ToString();
            }
        }

        private void textBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            //MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT Products_ID, Products_Name, FROM products WHERE Products_Name LIKE '" + textBoxForSearch + "%'", connection);
            //DataTable table1 = new DataTable();
            //adapter1.Fill(table1);
            //dataGridView1.DataSource = table1;
            //DataView dv = new DataView(table);
            //dv.RowFilter = string.Format("Products_Name LIKE '%{0}%'", textBoxForSearch.Text);
            //dataGridView1.DataSource = dv;
        }

        //DataTable table1 = new DataTable("products");
        private void textBoxForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
           // if(e.KeyChar == (char)13)
            {
                //DataView Dv = table.DefaultView;
                //Dv.RowFilter = string.Format("Products_Name LIKE '%{0}%'", textBoxForSearch.Text);
                //dataGridView1.DataSource = Dv.ToTable();
            }
        }
    }
}

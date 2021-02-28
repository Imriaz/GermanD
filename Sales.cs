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
    public partial class Sales : Form
    {

        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;
        MySqlDataAdapter adapter;
        public Sales()
        {
            InitializeComponent();
        }
        string Payment_Method;

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Dashboard access = new Dashboard();
            access.Show();
        }

        private void buttonSCustomers_Click(object sender, EventArgs e)
        {
            Customers access = new Customers();
            access.Show();
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            this.Hide();
            access.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void ShowProductData()
        {
            String query = "SELECT Products_ID,Products_Name,Quantity AS Stock, Sell_Price AS Price FROM products";
            DataTable table = new DataTable();
            adapter = new MySqlDataAdapter(query, connection);
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
    private void Sales_Load(object sender, EventArgs e)
        {
            Invoice_Id();
            ShowProductData();
            Transaction_Id();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBoxProductID.Text = row.Cells["Products_ID"].Value.ToString();
                textBoxProductName.Text = row.Cells["Products_Name"].Value.ToString();
                textBoxUnitPrice.Text = row.Cells["Price"].Value.ToString();
                textBoxQTY.Text = "";
                textBoxLineTotal.Text = "";

            }
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string search = "SELECT Products_ID,Products_Name,Quantity AS Stock, Sell_Price AS Price FROM products WHERE Products_ID = " + textBoxForSearch.Text;
            command = new MySqlCommand(search, connection);
            connection.Open();
            mdr = command.ExecuteReader();

            if (mdr.Read())
            {
                textBoxProductID.Text = mdr.GetInt32("Products_ID").ToString();
                textBoxProductName.Text = mdr.GetString("Products_Name");
                textBoxUnitPrice.Text = mdr.GetString("Price");
            }
            else
            {
                MessageBox.Show("Products Not Found");
            }

            connection.Close();
        }

        private void textBoxQTY_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQTY.Text.Length > 0)
            {
                textBoxLineTotal.Text = (Convert.ToInt32(textBoxUnitPrice.Text) * Convert.ToInt32(textBoxQTY.Text)).ToString();
            }
        }
        private void textBoxForSearch_TextChanged(object sender, EventArgs e)
        {
            //MySqlDataAdapter adapter1 = new MySqlDataAdapter("SELECT Products_ID, Products_Name, FROM products WHERE Products_Name LIKE '" + textBoxForSearch.Text+"%'", connection);
            //DataTable table1 = new DataTable();
            //adapter1.Fill(table1);
            //dataGridView1.DataSource = table1;
        }

        private void buttonAddToCart_Click(object sender, EventArgs e)
        {
            string[] arr = new string[5];

            arr[0] = textBoxProductID.Text;
            arr[1] = textBoxProductName.Text;
            arr[2] = textBoxUnitPrice.Text;
            arr[3] = textBoxQTY.Text;
            arr[4] = textBoxLineTotal.Text;

            ListViewItem lvi = new ListViewItem(arr);
            listView1.Items.Add(lvi);

            textBoxTotal.Text = (Convert.ToInt32(textBoxTotal.Text) + Convert.ToInt32(textBoxLineTotal.Text)).ToString();
        }
       
        private void textBoxVat_Click(object sender, EventArgs e)
        {
            textBoxVat.Text = (Convert.ToInt32(textBoxTotal.Text) * 0.05).ToString();
            textBoxNetTotal.Text = (Convert.ToInt32(textBoxTotal.Text) + Convert.ToInt32(textBoxVat.Text)).ToString();
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDiscount.Text.Length > 0)
            {
                textBoxNetTotal.Text = (Convert.ToInt32(textBoxTotal.Text) + Convert.ToInt32(textBoxVat.Text) - Convert.ToInt32(textBoxDiscount.Text)).ToString();
            }
        }

        private void textBoxPayment_TextChanged(object sender, EventArgs e)
        {
            if (textBoxPayment.Text.Length > 0)
            {
                textBoxChangeAmount.Text = (Convert.ToInt32(textBoxPayment.Text) - Convert.ToInt32(textBoxNetTotal.Text)).ToString();
            }
        }

        private void buttonRemoveItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you Want to Remove this Item?","", MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                if (listView1.SelectedItems.Count > 0)
                {
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        if (listView1.Items[i].Selected)
                        {
                            textBoxTotal.Text = (Convert.ToInt32(textBoxTotal.Text) - Convert.ToInt32(listView1.Items[i].SubItems[4].Text)).ToString();
                            listView1.Items[i].Remove();
                        }
                    }
                }
            }

            else
            {

            }
        }

        private void radioButtonCash_CheckedChanged(object sender, EventArgs e)
        {
            Payment_Method = "Cash";
        }

        private void radioButtonCard_CheckedChanged(object sender, EventArgs e)
        {
            Payment_Method = "Card";
        }

        private void radioButtonbKash_CheckedChanged(object sender, EventArgs e)
        {
            Payment_Method = "bKash";
        }

        void clear()
        {
            textBoxInvoiceNO.Clear();
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxUnitPrice.Clear();
            textBoxQTY.Clear();
            textBoxLineTotal.Clear();
            textBoxTotal.Clear();
            textBoxTransactionID.Clear();
            textBoxVat.Clear();
            textBoxDiscount.Clear();
            textBoxNetTotal.Clear();
            textBoxPayment.Clear();
            textBoxChangeAmount.Clear();
            textBoxCustomerID.Clear();
            textBoxCustomerName.Clear();
            textBoxCustomerMobile.Clear();
            listView1.Clear();
            textBoxLineTotal.Text = "";
            textBoxTotal.Text = "";
            textBoxQTY.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void textBoxInvoiceNO_TextChanged(object sender, EventArgs e)
        {

        }
        public void Invoice_Id()
        {
            connection.Open();

            string query = "select max(Invoice_No) from sales";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string value = dr[0].ToString();
                if (value == "")
                {
                    textBoxInvoiceNO.Text = "900300100";
                }
                else
                {
                    int a;
                    a = int.Parse(dr[0].ToString());
                    a = a + 1;
                    textBoxInvoiceNO.Text = a.ToString();

                }
                connection.Close();
            }
        }

        public void Transaction_Id()
        {
            connection.Open();

            string query1 = "select max(Transaction_ID) from sales";
            MySqlCommand cmd1 = new MySqlCommand(query1, connection);
            MySqlDataReader dr1;
            dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                string value = dr1[0].ToString();
                if (value == "")
                {
                    textBoxTransactionID.Text = "212000100";
                }
                else
                {
                    int b;
                    b = int.Parse(dr1[0].ToString());
                    b = b + 1;
                    textBoxTransactionID.Text = b.ToString();

                }
                connection.Close();
            }
        }

        private void textBoxCustomerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                string search = "SELECT * FROM customer WHERE Customer_ID = " + textBoxCustomerID.Text;
                command = new MySqlCommand(search, connection);
                connection.Open();
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    textBoxCustomerID.Text = mdr.GetInt32("Customer_ID").ToString();
                    textBoxCustomerName.Text = mdr.GetString("Customer_Name").ToString();
                    textBoxCustomerMobile.Text = mdr.GetString("Customer_Mobile").ToString();
                }
                else
                {
                    MessageBox.Show("Customer Not Found");
                    textBoxCustomerID.Text = "";
                    textBoxCustomerName.Text = "";
                    textBoxCustomerMobile.Text = "";
                }

                connection.Close();
            }
        }

        private void textBoxForSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                string search = "SELECT Products_ID,Products_Name,Quantity AS Stock, Sell_Price AS Price FROM products WHERE Products_ID = " + textBoxForSearch.Text;
                command = new MySqlCommand(search, connection);
                connection.Open();
                mdr = command.ExecuteReader();

                if (mdr.Read())
                {
                    textBoxProductID.Text = mdr.GetInt32("Products_ID").ToString();
                    textBoxProductName.Text = mdr.GetString("Products_Name");
                    textBoxUnitPrice.Text = mdr.GetString("Price");
                }
                else
                {
                    MessageBox.Show("Products Not Found");
                }

                connection.Close();
            }
        }
    }
}

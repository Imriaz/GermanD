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
    public partial class LoginForm : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            CreateAdminAccount creatAdmin = new CreateAdminAccount();
            creatAdmin.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM germand.admin WHERE Admin_ID = '" + textBoxAdmin_ID.Text + "' AND Admin_Password = '" + textBoxAdmin_Password.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
                string Query = "update germand.admin set LastLogin='" + dateTimePicker1.Value + "' where Admin_ID='" + this.textBoxAdmin_ID.Text + "';";
                MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);

                MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
                MySqlDataReader MyReader2;
                MyConn2.Open();
                MyReader2 = MyCommand2.ExecuteReader();
                while (MyReader2.Read())
                {
                }
                MyConn2.Close();

                MessageBox.Show("Login Successful!");
                this.Hide();
                Dashboard access = new Dashboard();
                access.Show();
               

            }
            else
            {

                MessageBox.Show("Incorrect Login Information! Try again.");
            }

            connection.Close();

            if (string.IsNullOrEmpty(textBoxAdmin_ID.Text) || string.IsNullOrEmpty(textBoxAdmin_Password.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
            
        }
    }
}

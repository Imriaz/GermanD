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
    public partial class CreateAdminAccount : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = localhost; database=GermanD; username=root;password=;");
        MySqlCommand command;
        MySqlDataReader mdr;

        public CreateAdminAccount()
        {
            InitializeComponent();
        }
        string Gender;

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            connection.Open();
            string selectQuery = "SELECT * FROM germand.admin WHERE Admin_FirstName = '" + textBoxFName.Text + "';";
            command = new MySqlCommand(selectQuery, connection);
            mdr = command.ExecuteReader();
            if (mdr.Read())
            {
                MessageBox.Show("Username not available!");

            }
            else
            {
                string connectionString = "datasource=localhost;port=3306;username=root;password=;database=germand;";
                string iquery = "INSERT INTO admin(Admin_ID,Admin_FirstName,Admin_LastName,Admin_Email,Admin_Password,Admin_Phone,Branch_ID,Admin_Designation,Admin_Address,LastLogin,Admin_Age,Admin_Gender) VALUES ('NULL', '" + textBoxFName.Text + "', '" + textBoxLName.Text + "', '" + TextBoxEmail.Text + "', '" + textBoxPassword.Text + "', '" + textBoxPhone.Text + "', '" + textBoxBranch_ID.Text + "', '" + textBoxDesignation.Text + "', '" + textBoxAddress.Text + "', '" + dateTimePicker1.Value + "', '"+textBoxAge.Text+"', '"+Gender+"')";

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

            if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please input Username and Password", "Error");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            LoginForm access = new LoginForm();
            access.Show();
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "Female";
        }
    }
}

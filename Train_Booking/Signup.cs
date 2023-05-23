using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Train_Booking
{
    public partial class Signup : Form
    {
        public static string str = "Server=104.155.147.34; Initial Catalog=Train-Booking; User ID=sqlserver; Password=12345678;";
        public SqlConnection connection = new SqlConnection(str);
        public Signup()
        {
            InitializeComponent();
        }
        private void Signup_Load(object sender, EventArgs e)
        {
            textname.Focus();
        }
        private void loginsubmit_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textpassword.Text) || string.IsNullOrEmpty(textusername.Text) ||
                string.IsNullOrEmpty(textconfrimpssword.Text) || string.IsNullOrEmpty(textname.Text) ||
                string.IsNullOrEmpty(textemail.Text) || string.IsNullOrEmpty(textphone.Text) ||
                string.IsNullOrEmpty(textcity.Text) || string.IsNullOrEmpty(textcountry.Text) ||
                string.IsNullOrEmpty(textage.Text))
            {
                MessageBox.Show("Cannot leave fields empty", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textpassword.Text != textconfrimpssword.Text)
            {
                MessageBox.Show("Passwords do not match, please re-enter", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textpassword.Text = "";
                textconfrimpssword.Text = "";
                textpassword.Focus();
            }
            else if (!Regex.IsMatch(textusername.Text, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("Invalid username. Username can only contain alphanumeric characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textusername.Text = "";
                textusername.Focus();
            }
            else if (!Regex.IsMatch(textname.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid name. Name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textname.Text = "";
                textname.Focus();
            }
            else if (!Regex.IsMatch(textpassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                MessageBox.Show("Invalid password. Password must be at least 8 characters long and contain at least one letter and one digit", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textpassword.Text = "";
                textconfrimpssword.Text = "";
                textpassword.Focus();
            }
            else if (!Regex.IsMatch(textemail.Text, @"^\S+@\S+\.\S+$"))
            {
                MessageBox.Show("Invalid email address", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textemail.Text = "";
                textemail.Focus();
            }
            else if (!Regex.IsMatch(textphone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number. Phone number must be 10 digits long", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textphone.Text = "";
                textphone.Focus();
            }
            else if (!Regex.IsMatch(textcity.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid city name. City name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textcity.Text = "";
                textcity.Focus();
            }
            else if (!Regex.IsMatch(textage.Text, @"^\d+$") && Convert.ToInt32(textage.Text) > 18)
            {
                MessageBox.Show("Invalid age. Age must be a positive integer", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textage.Text = "";
                textage.Focus();
            }
            else if (!Regex.IsMatch(textcountry.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid country name. Country name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textcountry.Text = "";
                textcountry.Focus();
            }
            else
            {
                connection.Open();
                SqlCommand command;
                bool isReg = false;
                string query = $"SELECT COUNT(username) FROM customer WHERE username = '{textusername.Text}'";
                using (command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    int ch = reader.GetInt32(0);
                    if (ch >= 1)
                    {
                        isReg = true;
                    }
                }
                connection.Close();

                if (!isReg)
                {
                    connection.Open();
                    query = "INSERT INTO Customer (username, name, password, phone_number, email, city, age, country) " +
                        "VALUES (@username, @name, @password, @phone, @email, @city, @age, @country)";
                    using (command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", textusername.Text);
                        command.Parameters.AddWithValue("@name", textname.Text);
                        command.Parameters.AddWithValue("@password", textpassword.Text);
                        command.Parameters.AddWithValue("@phone", textphone.Text);
                        command.Parameters.AddWithValue("@email", textemail.Text);
                        command.Parameters.AddWithValue("@city", textcity.Text);
                        command.Parameters.AddWithValue("@age", int.Parse(textage.Text));
                        command.Parameters.AddWithValue("@country", textcountry.Text);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();

                    textpassword.Text = "";
                    textconfrimpssword.Text = "";
                    textemail.Text = "";
                    textusername.Text = "";
                    textname.Text = "";
                    textphone.Text = "";
                    textcity.Text = "";
                    textage.Text = "";
                    textcountry.Text = "";
                    MessageBox.Show("Your account has been successfully created", "Registration Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new StartPage().Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Username already taken, please re-enter", "Registration Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textusername.Text = "";
                    textusername.Focus();
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textpassword.Text = "";
            textconfrimpssword.Text = "";
            textemail.Text = "";
            textusername.Text = "";
            textname.Text = "";
            textphone.Text = "";
            textcity.Text = "";
            textage.Text = "";
            textcountry.Text = "";
            textname.Focus();
        }

        private void checkbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxPassword.Checked)
            {
                textpassword.PasswordChar = '\0';
                textconfrimpssword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '*';
                textconfrimpssword.PasswordChar = '*';
            }
        }
        private void backtologinlabel_Click(object sender, EventArgs e)
        {
            new Signin().Show();
            Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}

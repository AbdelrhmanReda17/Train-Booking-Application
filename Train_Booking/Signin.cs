using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train_Booking.Classes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Train_Booking
{
    public partial class Signin : Form
    {
        public static string str = "Server=ABDELRHMAN\\SQLEXPRESS; Initial Catalog=Train-Booking; Integrated Security=true;";
        public SqlConnection connection = new SqlConnection(str);

        public Signin()
        {
            InitializeComponent();
            textusername.Focus();
        }

        private void loginsubmit_btn_Click(object sender, EventArgs e)
        {
            bool isLogined = false;
            if (string.IsNullOrEmpty(textpassword.Text) && string.IsNullOrEmpty(textusername.Text))
            {
                MessageBox.Show("Cannot leave fields empty", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                connection.Open();
                SqlCommand command;
                if (ifAdmin.Checked)
                {
                    
                    Admin? admin = null;
                    try
                    {
                        string selectAdminQuery = $"Select * from Admin Where username = '{textusername.Text}'";
                        using (command = new SqlCommand(selectAdminQuery, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            reader.Read();
                            if (textusername.Text == reader["username"].ToString() && textpassword.Text == reader["password"].ToString())
                            {
                                admin = new Admin();
                                admin.id = reader.GetInt32(0);
                                admin.name = reader.GetString(1);
                                admin.username = reader.GetString(2);
                                admin.password = reader.GetString(3);
                                admin.phone = reader.GetString(4);
                                admin.email = reader.GetString(5);
                                admin.position = reader.GetString(6);
                                isLogined = true;
                            }
                        }
                    }catch{}
                   
                    if (isLogined)
                    {
                        MessageBox.Show("Successfully Logined", "Login Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new AdminInterface(admin).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account Details is wrong , please re-enter", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textpassword.Text = "";
                        textusername.Text = "";
                        textpassword.Focus();
                    }
                    connection.Close();

                    connection.Close();
                }
                else
                {
                    Customer? customer = null;
                    try
                    {
                        string selectCustomerQuery = $"Select * from Customer Where username = '{textusername.Text}'";
                        using (command = new SqlCommand(selectCustomerQuery, connection))
                        {
                            SqlDataReader reader = command.ExecuteReader();
                            reader.Read();
                            if (textusername.Text == reader["username"].ToString() && textpassword.Text == reader["password"].ToString())
                            {
                                customer = new Customer();
                                customer.id = reader.GetInt32(0);
                                customer.name = reader.GetString(1);
                                customer.username = reader.GetString(2);
                                customer.password = reader.GetString(3);
                                customer.phone = reader.GetString(4);
                                customer.email = reader.GetString(5);
                                customer.city = reader.GetString(6);
                                customer.age = reader.GetInt32(7);
                                customer.country = reader.GetString(8);
                                isLogined = true;
                            }
                        }
                    }catch{}
                    if (isLogined)
                    {
                        MessageBox.Show("Successfully Logined", "Login Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        new CustomerInterface(customer).Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account Details is wrong , please re-enter", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textpassword.Text = "";
                        textusername.Text = "";
                        textusername.Focus();
                    }
                    connection.Close();
                }
            }
        }

        private void checkbxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxPassword.Checked)
            {
                textpassword.PasswordChar = '\0';
            }
            else
            {
                textpassword.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            textpassword.Text = "";
            textusername.Text = "";
            textusername.Focus();
        }

    }
}

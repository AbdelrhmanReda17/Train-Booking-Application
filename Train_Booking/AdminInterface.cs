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
using System.Data.SqlClient;
using Bunifu.Framework.UI;
using Bunifu.UI.WinForms.BunifuButton;
using Bunifu.UI.WinForms.Helpers.Transitions;
using Microsoft.VisualBasic;
using TrainBooking.Classes;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Train_Booking
{
    public partial class AdminInterface : Form
    {
        public Admin? admin = null;
        public static string str = "Server=ABDELRHMAN\\SQLEXPRESS; Initial Catalog=Train-Booking; Integrated Security=true;";
        public SqlConnection connection = new SqlConnection(str);

        public AdminInterface(Admin? admin)
        {
            this.admin = admin;
            InitializeComponent();
        }
        private void AdminInterface_Load(object sender, EventArgs e)
        {
            addtrip_btn_Click(sender, e);
            label1.Text = $"Welcome, {admin.position}";
            label20.Text = $"{admin.name}";
            connection.Open();
            SqlCommand command;
            string query = "Select * from Train";
            using (command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int trainId = reader.GetInt32(0);
                    int totalSeats = reader.GetInt32(1);
                    Train train = new Train(totalSeats);
                    train.train_id = trainId;
                    txttrain_id.Items.Add(trainId);
                }
            }
            connection.Close();
        }
        private void buttoncoloring(BunifuThinButton2 btn1, BunifuThinButton2 btn2, BunifuThinButton2 btn3, BunifuThinButton2 btn4, BunifuThinButton2 btn5, BunifuThinButton2 btn6)
        {
            btn2.IdleForecolor = Color.White;
            btn2.IdleFillColor = Color.FromArgb(5, 42, 97);
            btn2.IdleLineColor = Color.FromArgb(5, 42, 97);
            btn2.ActiveForecolor = Color.FromArgb(5, 42, 97);
            btn2.ActiveFillColor = Color.White;
            btn2.ActiveLineColor = Color.FromArgb(5, 42, 97);


            btn1.IdleForecolor = Color.FromArgb(5, 42, 97);
            btn1.IdleFillColor = Color.White;
            btn1.IdleLineColor = Color.FromArgb(5, 42, 97);
            btn1.ActiveLineColor = Color.FromArgb(5, 42, 97);
            btn1.ActiveFillColor = Color.White;
            btn1.ActiveLineColor = Color.FromArgb(5, 42, 97);

            btn3.IdleForecolor = Color.White;
            btn3.IdleFillColor = Color.FromArgb(5, 42, 97);
            btn3.IdleLineColor = Color.FromArgb(5, 42, 97);
            btn3.ActiveForecolor = Color.FromArgb(5, 42, 97);
            btn3.ActiveFillColor = Color.White;
            btn3.ActiveLineColor = Color.FromArgb(5, 42, 97);

            btn4.IdleForecolor = Color.White;
            btn4.IdleFillColor = Color.FromArgb(5, 42, 97);
            btn4.IdleLineColor = Color.FromArgb(5, 42, 97);
            btn4.ActiveForecolor = Color.FromArgb(5, 42, 97);
            btn4.ActiveFillColor = Color.White;
            btn4.ActiveLineColor = Color.FromArgb(5, 42, 97);

            btn5.IdleForecolor = Color.White;
            btn5.IdleFillColor = Color.FromArgb(5, 42, 97);
            btn5.IdleLineColor = Color.FromArgb(5, 42, 97);
            btn5.ActiveForecolor = Color.FromArgb(5, 42, 97);
            btn5.ActiveFillColor = Color.White;
            btn5.ActiveLineColor = Color.FromArgb(5, 42, 97);

            btn6.IdleForecolor = Color.White;
            btn6.IdleFillColor = Color.FromArgb(5, 42, 97);
            btn6.IdleLineColor = Color.FromArgb(5, 42, 97);
            btn6.ActiveForecolor = Color.FromArgb(5, 42, 97);
            btn6.ActiveFillColor = Color.White;
            btn6.ActiveLineColor = Color.FromArgb(5, 42, 97);
        }
        private void Hide(Panel first, Panel second, Panel third, Panel Fourth, Panel fifth, Panel Sexth)
        {
            first.Visible = true;
            second.Visible = false;
            third.Visible = false;
            managepanel.Visible = false;
            Fourth.Visible = false;
            fifth.Visible = false;
            Sexth.Visible = false;
        }
        private void revatrip_btn_Click(object sender, EventArgs e)
        {
            Hide(revtrip_panel, addTripPanel, addtrain_panel, rmvtrain_panel, addadmin_panel, report_panel);
            buttoncoloring(revatrip_btn, addtrain_btn, rmvtrain_btn, addtrip_btn, bunifuThinButton26, report_btn);
            managepanel.Visible = false;
            // Enable full row selection
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0)
                {
                    dataGridView.Rows[args.RowIndex].Selected = true;
                }
            };
            connection.Open();
            SqlCommand command;
            string query = "SELECT trip_id as TripID, source as Source, destination as Destination, price as Price, train_id as TrainID FROM Trip";
            using (command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView.DataSource = dataTable;
                dataGridView.Columns["TripID"].Width = 50;
                dataGridView.Columns["TripID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Columns["Price"].Width = 50;
                dataGridView.Columns["Price"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Columns["Source"].Width = 90;
                dataGridView.Columns["Source"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Columns["Destination"].Width = 90;
                dataGridView.Columns["Destination"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.Columns["TrainID"].Width = 50;
                dataGridView.Columns["TrainID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            connection.Close();
        }
        private void addtrip_btn_Click(object sender, EventArgs e)
        {
            Hide(addTripPanel, revtrip_panel, addtrain_panel, rmvtrain_panel, addadmin_panel, report_panel);
            buttoncoloring(addtrip_btn, addtrain_btn, rmvtrain_btn, revatrip_btn, bunifuThinButton26, report_btn);
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtsource.Text) && string.IsNullOrEmpty(txtdestination.Text)
                                                     && string.IsNullOrEmpty(txtmonth.Text) && string.IsNullOrEmpty(txtprice.Text) &&
                                                     string.IsNullOrEmpty(txtday.Text) && string.IsNullOrEmpty(txttrain_id.Text))
            {
                MessageBox.Show("Cannot leave fields empty", "Add Trip Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtsource.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Source. Name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsource.Text = "";
                txtsource.Focus();
            }
            else if (!Regex.IsMatch(txtmonth.Text, @"^(1[0-2]|[1-9])$"))
            {
                MessageBox.Show("Invalid month. takes only from 1 to 12",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtmonth.Text = "";
                txtmonth.Focus();
            }
            else if (!Regex.IsMatch(txtday.Text, @"^(3[01]|[12][0-9]|[1-9])$"))
            {
                MessageBox.Show("Invalid day. takes only from 1 to 31",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtday.Text = "";
                txtday.Focus();
            }
            else if (!Regex.IsMatch(txtdestination.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Destination. Name can only contain alphabetic characters",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdestination.Text = "";
                txtdestination.Focus();
            }
            else if (!Regex.IsMatch(txtprice.Text, @"^\d+$"))
            {
                MessageBox.Show("Invalid Price . Price must be a positive integer", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtprice.Text = "";
                txtprice.Focus();
            }
            else
            {
                connection.Open();
                string query = "INSERT INTO Trip (source, destination, price, train_id , trip_date) VALUES (@source, @destination, @price, @train_id , @trip_date)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    string x = $"{DateTime.Now.Year}-{txtmonth.Text}-{txtday.Text}";
                    command.Parameters.AddWithValue("@source", txtsource.Text);
                    command.Parameters.AddWithValue("@destination", txtdestination.Text);
                    command.Parameters.AddWithValue("@price", double.Parse(txtprice.Text));
                    command.Parameters.AddWithValue("@train_id", int.Parse(txttrain_id.Text));
                    command.Parameters.AddWithValue("@trip_date", x);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Some thing went wrong while inserting trip", "Add Trip Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtdestination.Text = "";
                        txtprice.Text = "";
                        txtsource.Text = "";
                        txttrain_id.Text = "";
                        txtday.Text = "";
                        txtmonth.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Trip added successfully", "Add Trip Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connection.Close();
                connection.Open();
                int trainSeats;
                query = "SELECT total_seats FROM Train WHERE train_id = @traindd";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@traindd", txttrain_id.Text);
                    trainSeats = Convert.ToInt32(command.ExecuteScalar());
                }
                connection.Close();
                connection.Open();

                int trip_id;
                query = "SELECT MAX(trip_id) FROM Trip";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    trip_id = Convert.ToInt32(command.ExecuteScalar());
                }
                connection.Close();
                connection.Open();
                query = "INSERT INTO Seat (state, Train_train_id, trip_id) VALUES (@state, @trainID, @trip_id)";
                for (int i = 1; i <= trainSeats; i++)
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@state", 0);
                        command.Parameters.AddWithValue("@trainID", txttrain_id.Text);
                        command.Parameters.AddWithValue("@trip_id", trip_id);
                        int result = command.ExecuteNonQuery();
                        if (result < 0)
                        {
                            MessageBox.Show("ERROR WHILE INSERTING", "Failed ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                txtdestination.Text = "";
                txtprice.Text = "";
                txtsource.Text = "";
                txttrain_id.Text = "";
                txtday.Text = "";
                txtmonth.Text = "";
                MessageBox.Show("Seats added successfully", "Add Seats Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
        }
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            txtdestination.Text = "";
            txtprice.Text = "";
            txtsource.Text = "";
            txttrain_id.Text = "";
            txtsource.Focus();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            new StartPage().Show();
            Hide();
        }
        private void addtrain_btn_Click(object sender, EventArgs e)
        {
            Hide(addtrain_panel, addTripPanel, revtrip_panel, rmvtrain_panel, addadmin_panel, report_panel);
            buttoncoloring(addtrain_btn, revatrip_btn, rmvtrain_btn, addtrip_btn, bunifuThinButton26, report_btn);
        }
        private void rmvtrain_btn_Click(object sender, EventArgs e)
        {
            Hide(rmvtrain_panel, revtrip_panel, addTripPanel, addtrain_panel, addadmin_panel, report_panel);
            buttoncoloring(rmvtrain_btn, addtrain_btn, revatrip_btn, addtrip_btn, bunifuThinButton26, report_btn);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0)
                {
                    dataGridView1.Rows[args.RowIndex].Selected = true;
                }
            };
            connection.Open();
            SqlCommand command;
            string query = "SELECT train_id as TrainID, total_seats as TotalSeats FROM Train";
            using (command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView1.DataSource = dataTable;
                dataGridView1.Columns["TrainID"].Width = 160;
                dataGridView1.Columns["TrainID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.Columns["TotalSeats"].Width = 160;
                dataGridView1.Columns["TotalSeats"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            connection.Close();

        }

        private int selectedtrip;
        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int tripId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TripID"].Value);
                selectedtrip = tripId;
                revtrip_panel.Visible = false;
                managepanel.Visible = true;
                connection.Open();
                string query = $"Select * from Trip where trip_id = '{tripId}'";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    string x = reader.GetString(2);
                    string[] xParts = x.Split('-');
                    Mtxtday.Text = xParts[2];
                    Mtxtmonth.Text = xParts[1];
                    Mtxtsource.Text = reader.GetString(3);
                    Mtxtdestination.Text = reader.GetString(4);
                    Mtxtprice.Text = reader.GetDouble(1).ToString();
                }
                connection.Close();
            }
        }

        public void RemoveTrip(int tp)
        {
            CheckTrip(tp);
            connection.Open();
            string query = $"Delete from Trip where trip_id={tp}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void CheckTrip(int tp)
        {
            connection.Open();
            string query = $"DELETE FROM Seat WHERE trip_id = {tp}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }
            query = $"DELETE FROM Booking WHERE trip_id={tp}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void addtrain_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSeats.Text))
            {
                MessageBox.Show("Cannot leave fields empty", "Add Trip Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeats.Text = "";
                txtSeats.Focus();
            }
            else if (!Regex.IsMatch(txtSeats.Text, @"^\d+$"))
            {
                MessageBox.Show("Invalid Seats Number . Seats Number must be a positive integer", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSeats.Text = "";
                txtSeats.Focus();
            }
            else
            {
                connection.Open();
                string query = "insert into Train(total_seats) values (@total_seats)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@total_seats", txtSeats.Text);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Some thing went wrong while inserting Train", "Add Train Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Train added successfully", "Add Train Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                connection.Close();
            }
        }
        private void clearSeatsbtn_Click(object sender, EventArgs e)
        {
            txtSeats.Text = "";
            txtSeats.Focus();
        }

        private void addtrip_btn_Click_1(object sender, EventArgs e)
        {
            txttrain_id.Items.Clear();
            Hide(addTripPanel, addtrain_panel, revtrip_panel, rmvtrain_panel, addadmin_panel, report_panel);
            buttoncoloring(addtrip_btn, revatrip_btn, rmvtrain_btn, addtrain_btn, bunifuThinButton26, report_btn);
            connection.Open();
            SqlCommand command;
            string query = "Select * from Train";
            using (command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int trainId = reader.GetInt32(0);
                    int totalSeats = reader.GetInt32(1);
                    Train train = new Train(totalSeats);
                    train.train_id = trainId;
                    txttrain_id.Items.Add(trainId);
                }
            }
            connection.Close();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 1)
            {
                for (int i = 1; i < dataGridView.SelectedRows.Count; i++)
                {
                    dataGridView.SelectedRows[i].Selected = false;
                }
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 1)
            {
                for (int i = 1; i < dataGridView1.SelectedRows.Count; i++)
                {
                    dataGridView1.SelectedRows[i].Selected = false;
                }
            }
        }
        // TRAIN-CHANGE
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Mtxtsource.Text) && string.IsNullOrEmpty(Mtxtdestination.Text)
                                                      && string.IsNullOrEmpty(Mtxtprice.Text))
            {
                MessageBox.Show("Cannot leave fields empty", "Add Trip Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(Mtxtsource.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Source. Name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mtxtsource.Text = "";
                Mtxtsource.Focus();
            }
            else if (!Regex.IsMatch(Mtxtdestination.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Destination. Name can only contain alphabetic characters",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mtxtdestination.Text = "";
                Mtxtdestination.Focus();
            }
            else if (!Regex.IsMatch(Mtxtprice.Text, @"^\d+$"))
            {
                MessageBox.Show("Invalid Price . Price must be a positive integer", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mtxtprice.Text = "";
                Mtxtprice.Focus();
            }
            else if (!Regex.IsMatch(Mtxtmonth.Text, @"^(1[0-2]|[1-9])$"))
            {
                MessageBox.Show("Invalid month. takes only from 1 to 12",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mtxtmonth.Text = "";
                Mtxtmonth.Focus();
            }
            else if (!Regex.IsMatch(Mtxtday.Text, @"^(3[01]|[12][0-9]|[1-9])$"))
            {
                MessageBox.Show("Invalid day. takes only from 1 to 31",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Mtxtday.Text = "";
                Mtxtday.Focus();
            }
            else
            {
                connection.Open();

                string query = "UPDATE Trip SET source = @source, destination = @destination, price = @price, trip_date = @trip_date WHERE trip_id = @selectedtrip";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@source", Mtxtsource.Text);
                    command.Parameters.AddWithValue("@destination", Mtxtdestination.Text);
                    command.Parameters.AddWithValue("@price", Mtxtprice.Text);
                    string x = $"{DateTime.Now.Year}-{Mtxtmonth.Text}-{Mtxtday.Text}";
                    command.Parameters.AddWithValue("@trip_date", x);
                    command.Parameters.AddWithValue("@selectedtrip", selectedtrip);
                    int result = command.ExecuteNonQuery();
                    if (result < 0)
                    {
                        MessageBox.Show("Something went wrong while updating the trip", "Update Trip Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Trip updated successfully", "Update Trip Success", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                    Mtxtdestination.Text = "";
                    Mtxtprice.Text = "";
                    Mtxtsource.Text = "";
                    Mtxtday.Text = "";
                    Mtxtmonth.Text = "";
                    managepanel.Hide();
                    connection.Close();
                    revatrip_btn_Click(sender, e);
                }
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RemoveTrip(selectedtrip);
            managepanel.Hide();
            revatrip_btn_Click(sender, e);
        }
        public List<int> GetTripsRelatedToTrain(int train_id)
        {
            List<int> tripIDList = new List<int>();  // Instantiate the list
            connection.Open();
            string query = $"Select * from Trip Where train_id = {train_id}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int trip_id = reader.GetInt32(0);

                    tripIDList.Add(trip_id);
                }
                reader.Close();
            }
            connection.Close();
            return tripIDList;
        }
        public void RemoveSeats(int train_id)
        {
            connection.Open();
            string query = $"DELETE FROM Seat WHERE Train_train_id={train_id}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void RemoveTrain(int ts)
        {
            connection.Open();
            string query = $"Delete from Train where train_id={ts}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
                if (result < 0)
                {
                    MessageBox.Show("Some thing went wrong while deleting train", "train deletion Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            connection.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
                dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            int selectedRow = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["TrainID"].Value);
            if (selectedRowCount > 0)
            {
                List<int> tripIDList = GetTripsRelatedToTrain(selectedRow);
                foreach (int tripID in tripIDList)
                {
                    RemoveTrip(tripID);
                }
                RemoveSeats(selectedRow);
                RemoveTrain(selectedRow);
                MessageBox.Show("Train deleted successfully and  all Booking/Trips/Seats related to this train have been deleted successfully", "Train deleted Successfully",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            rmvtrain_btn_Click(sender, e);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.CancelEdit();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CancelEdit();
        }
        private void showpasswordcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showpasswordcheck.Checked)
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

        private void adminconfirm_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textpassword.Text) || string.IsNullOrEmpty(textusername.Text) ||
                string.IsNullOrEmpty(textconfrimpssword.Text) || string.IsNullOrEmpty(textname.Text) ||
                string.IsNullOrEmpty(textEmail.Text) || string.IsNullOrEmpty(textphone.Text) ||
                string.IsNullOrEmpty(textposition.Text))
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
                MessageBox.Show("Invalid username. Username can only contain alphanumeric characters",
                    "Registration Failed",
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
                MessageBox.Show(
                    "Invalid password. Password must be at least 8 characters long and contain at least one letter and one digit",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textpassword.Text = "";
                textconfrimpssword.Text = "";
                textpassword.Focus();
            }
            else if (!Regex.IsMatch(textEmail.Text, @"^\S+@\S+\.\S+$"))
            {
                MessageBox.Show("Invalid email address", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textEmail.Text = "";
                textEmail.Focus();
            }
            else if (!Regex.IsMatch(textphone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number. Phone number must be 10 digits long", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textphone.Text = "";
                textphone.Focus();
            }
            else if (!Regex.IsMatch(textposition.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid Position name. Country name can only contain alphabetic characters",
                    "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                textposition.Text = "";
                textposition.Focus();
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
                    query = "INSERT INTO Admin (username, name, password, phone_number, email,position ) " +
                            "VALUES (@username, @name, @password, @phone, @email,@position )";
                    using (command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", textusername.Text);
                        command.Parameters.AddWithValue("@name", textname.Text);
                        command.Parameters.AddWithValue("@password", textpassword.Text);
                        command.Parameters.AddWithValue("@phone", textphone.Text);
                        command.Parameters.AddWithValue("@email", textEmail.Text);
                        command.Parameters.AddWithValue("@position", textposition.Text);

                        command.ExecuteNonQuery();
                    }

                    connection.Close();
                    textpassword.Text = "";
                    textconfrimpssword.Text = "";
                    textusername.Text = "";
                    textname.Text = "";
                    textphone.Text = "";
                    textposition.Text = "";
                    textEmail.Text = "";
                    MessageBox.Show("Admin account has been successfully created", "Admin Registration Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Username already taken, please re-enter a unique one", "Admin Registration Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textusername.Text = "";
                    textusername.Focus();
                }
            }
            bunifuThinButton26_Click(sender, e);
        }
        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            Hide(addadmin_panel, revtrip_panel, addTripPanel, addtrain_panel, rmvtrain_panel, report_panel);
            buttoncoloring(bunifuThinButton26, revatrip_btn, addtrain_btn, rmvtrain_btn, addtrip_btn, report_btn);
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 1)
            {
                for (int i = 1; i < dataGridView2.SelectedRows.Count; i++)
                {
                    dataGridView2.SelectedRows[i].Selected = false;
                }
            }
        }
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Cancel the edit operation
            dataGridView2.CancelEdit();
        }

        private void clearadmin_btn_Click(object sender, EventArgs e)
        {
            textpassword.Text = "";
            textconfrimpssword.Text = "";
            textusername.Text = "";
            textname.Text = "";
            textphone.Text = "";
            textposition.Text = "";
            textEmail.Text = "";
        }
        private void report_btn_Click(object sender, EventArgs e)
        {
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0)
                {
                    dataGridView2.Rows[args.RowIndex].Selected = true;
                }
            };
            Hide(report_panel, addadmin_panel, revtrip_panel, addTripPanel, addtrain_panel, rmvtrain_panel);
            buttoncoloring(report_btn, bunifuThinButton26, revatrip_btn, addtrain_btn, rmvtrain_btn, addtrip_btn);
            connection.Open();
            string query = "SELECT Trip.trip_id AS TripID,  Trip.source AS Source,   Trip.destination AS Destination,  COUNT(DISTINCT Seat.seat_id) * Trip.price  AS Profit,  COUNT(DISTINCT Seat.seat_id) AS Seats FROM  Seat  INNER JOIN Booking ON Seat.Trip_id = Booking.trip_id  INNER JOIN Trip ON Booking.trip_id = Trip.trip_id AND Booking.train_id = Trip.train_id WHERE Seat.state = 1 GROUP BY   Trip.trip_id,   Trip.source,  Trip.destination,  Trip.price ORDER BY Profit DESC , Seats Asc , TripID  ASC";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                dataGridView2.DataSource = dataTable;
                dataGridView2.Columns["TripID"].Width = 40;
                dataGridView2.Columns["TripID"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView2.Columns["Source"].Width = 80;
                dataGridView2.Columns["Source"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView2.Columns["Destination"].Width = 80;
                dataGridView2.Columns["Destination"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView2.Columns["Profit"].Width = 60;
                dataGridView2.Columns["Profit"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView2.Columns["Seats"].Width = 60;
                dataGridView2.Columns["Seats"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            connection.Close();
        }
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                // Append column headers
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sb.Append(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.Columns.Count - 1)
                        sb.Append(",");
                }

                sb.AppendLine();
                // Append data rows
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    for (int i = 0; i < row.Cells.Count; i++)
                    {
                        sb.Append(row.Cells[i].Value.ToString());
                        if (i < row.Cells.Count - 1)
                            sb.Append(",");
                    }

                    sb.AppendLine();
                }
                sb.AppendLine();
                sb.AppendLine();
                sb.Append("Best Trip : , Trip Id , Source , Destination , Profit");
                sb.AppendLine();
                sb.Append("," + dataGridView.Rows[0].Cells[0].Value.ToString() +
                          "," + dataGridView.Rows[0].Cells[1].Value.ToString() +
                          "," + dataGridView.Rows[0].Cells[2].Value.ToString() +
                          "," + dataGridView.Rows[0].Cells[3].Value.ToString());
                File.WriteAllText(filePath, sb.ToString());
                MessageBox.Show($"Your Report is ready to use now ,\ncheck you path {filePath}", "Report Generate Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cannot access the file File is already opened", "Report Generate Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Generate_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog folderBrowserDialog = new OpenFileDialog())
            {
                folderBrowserDialog.ValidateNames = false;
                folderBrowserDialog.CheckFileExists = false;
                folderBrowserDialog.CheckPathExists = true;
                folderBrowserDialog.FileName = "Select Folder";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowserDialog.FileName);

                    // Export the DataGridView to the selected folder
                    string filePath = Path.Combine(folderPath, "TrainBookerReport.csv");
                    ExportToCSV(dataGridView2, filePath);
                }
            }
        }
    }
}

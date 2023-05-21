using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography;
using System.ServiceModel.Channels;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Train_Booking.Classes;

namespace Train_Booking
{
    public partial class CustomerInterface : Form
    {
        public Customer? customer = null;
        public Trip? trip = new Trip();
        public static string str = "Server=ABDELRHMAN\\SQLEXPRESS; Initial Catalog=Train-Booking; Integrated Security=true;";
        public SqlConnection connection = new SqlConnection(str);
        private void buttoncoloring(BunifuThinButton2 btn1, BunifuThinButton2 btn2, BunifuThinButton2 btn3)
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
        }
        private void Hide(Panel first, Panel second, Panel third)
        {
            first.Visible = true;
            second.Visible = false;
            third.Visible = false;
        }
        public CustomerInterface(Customer? customer)
        {
            this.customer = customer;
            InitializeComponent();

        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome"; label13.Text = $"{customer.name}";
            show_Click(sender, e);
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
            if (ViewBookingGrid.SelectedRows.Count > 1)
            {
                for (int i = 1; i < ViewBookingGrid.SelectedRows.Count; i++)
                {
                    ViewBookingGrid.SelectedRows[i].Selected = false;
                }
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.CancelEdit();
            ViewBookingGrid.CancelEdit();
        }
        private void show_Click(object sender, EventArgs e)
        {
            Hide(booktrip_panel, editprofile_panel, ViewBooking_panel);
            select_panel.Visible = false;
            buttoncoloring(booktrip_Btn, editprofile_btn, viewbooking_btn);
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0)
                {
                    dataGridView.Rows[args.RowIndex].Selected = true;
                }
            };
            try
            {
                connection.Open();
                SqlCommand command;
                string query = @"SELECT
                    Trip.trip_id AS TripID,
                    Trip.source AS Source,
                    Trip.destination AS Destination,
                    Trip.price AS Price,
                    Trip.trip_date AS TripDate,
                    CASE
                        WHEN (SELECT COUNT(*) FROM Seat WHERE Seat.Trip_id = Trip.trip_id AND (Seat.State = 0 OR Seat.State IS NULL)) = 0 THEN 'NO SEATS'
                        ELSE CAST((SELECT COUNT(*) FROM Seat WHERE Seat.Trip_id = Trip.trip_id AND (Seat.State = 0 OR Seat.State IS NULL)) AS NVARCHAR(10))
                    END AS FreeSeats
                FROM
                    Trip
                    LEFT JOIN Seat ON Trip.train_id = Seat.Train_train_id AND Trip.trip_id = Seat.Trip_id
                WHERE
                    Cast(Trip.trip_date AS date) >= @date
                GROUP BY
                    Trip.trip_id,
                    Trip.source,
                    Trip.destination,
                    Trip.price,
                    Trip.trip_date;";
                using (command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    SqlDataReader reader = command.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataGridView.DataSource = dataTable;
                    dataGridView.Columns["TripID"].Visible = false;
                    dataGridView.Columns["Price"].Width = 43;
                    dataGridView.Columns["Price"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView.Columns["Source"].Width = 72;
                    dataGridView.Columns["Source"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView.Columns["Destination"].Width = 72;
                    dataGridView.Columns["Destination"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView.Columns["TripDate"].Width = 72;
                    dataGridView.Columns["TripDate"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView.Columns["FreeSeats"].Width = 65;
                    dataGridView.Columns["FreeSeats"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                connection.Close();
                SeatsCheckBox1.Items.Clear();
                SeatsCheckBox2.Items.Clear();

            }
            catch { }
        }
        private int LeastId = 0;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            List<int> lst = new List<int>();
            trip.trip_id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["TripID"].Value);
            trip.tripDate = Convert.ToString(dataGridView.SelectedRows[0].Cells["TripDate"].Value);
            trip.source = Convert.ToString(dataGridView.SelectedRows[0].Cells["Source"].Value);
            trip.destination = Convert.ToString(dataGridView.SelectedRows[0].Cells["Destination"].Value);
            trip.price = Convert.ToDouble(dataGridView.SelectedRows[0].Cells["Price"].Value);
            string SeatCount = Convert.ToString(dataGridView.SelectedRows[0].Cells["FreeSeats"].Value);
            if (SeatCount == "NO SEATS")
            {
                MessageBox.Show("NO Seats Available.",
                    "Booking",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                show_Click(sender, e);
            }
            else
            {
                select_panel.Visible = true;
                connection.Open();
                string query = $"SELECT Min(Seat_id) from Seat where Trip_id = {trip.trip_id}";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    reader.Read();
                    LeastId = reader.GetInt32(0);
                    reader.Close();
                }
                query = $"SELECT * from Seat where Trip_id = {trip.trip_id} and state = 0";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                        lst.Add(reader.GetInt32(0));
                    reader.Close();
                }
                connection.Close();
                for (int i = 0; i < lst.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        SeatsCheckBox1.Items.Add(lst[i] - LeastId + 1);
                    }
                    else
                    {
                        SeatsCheckBox2.Items.Add(lst[i] - LeastId + 1);
                    }
                }
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            var selectedItems1 = SeatsCheckBox1.CheckedItems;
            var selectedItems2 = SeatsCheckBox2.CheckedItems;

            List<int> selectedItemList = new List<int>();

            foreach (var item in selectedItems1)
            {
                int index = (int)item + LeastId - 1;
                selectedItemList.Add(index);
            }
            foreach (var item in selectedItems2)
            {
                int index = (int)item + LeastId - 1;
                selectedItemList.Add(index);
            }
            ConfirmBooking(selectedItemList);
            MessageBox.Show("Booking Success.",
                "Booking",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            show_Click(sender, e);
        }
        public void ConfirmBooking(List<int> seatList)
        {
            connection.Open();
            string query = $"select train_id from trip where trip_id = {trip.trip_id}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                trip.train_id = reader.GetInt32(0);
                reader.Close();
            }
            query = "insert into Booking(price, booking_time, trip_date, customer_id, trip_id, train_id) values (@price , @booking_time, @trip_date, @customer_id, @trip_id, @train_id)";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@price", seatList.Count * trip.price);
                command.Parameters.AddWithValue("@booking_time", DateTime.UtcNow.ToLocalTime().ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@trip_date", trip.tripDate);
                command.Parameters.AddWithValue("@customer_id", customer.id);
                command.Parameters.AddWithValue("@trip_id", trip.trip_id);
                command.Parameters.AddWithValue("@train_id", trip.train_id);
                int result = command.ExecuteNonQuery();
            }
            foreach (int seat in seatList)
            {
                query = $"UPDATE Seat SET state = 1,booking_id = (SELECT max(booking_id) from Booking) WHERE seat_id={seat}";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }

        private void editprofile_btn_Click(object sender, EventArgs e)
        {
            Hide(editprofile_panel, booktrip_panel, ViewBooking_panel);
            select_panel.Visible = false;
            buttoncoloring(editprofile_btn, booktrip_Btn, viewbooking_btn);
            txtage.Text = customer.age.ToString();
            txtcity.Text = customer.city.ToString();
            txtcountry.Text = customer.country.ToString();
            txtemail.Text = customer.email.ToString();
            txtpassword.Text = customer.password.ToString();
            txtname.Text = customer.name.ToString();
            txtphone.Text = customer.phone.ToString();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtpassword.Text) || string.IsNullOrEmpty(txtname.Text) ||
                string.IsNullOrEmpty(txtemail.Text) || string.IsNullOrEmpty(txtphone.Text) ||
                string.IsNullOrEmpty(txtcity.Text) || string.IsNullOrEmpty(txtcountry.Text) ||
                string.IsNullOrEmpty(txtage.Text))
            {
                MessageBox.Show("Cannot leave fields empty", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!Regex.IsMatch(txtname.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid name. Name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Text = "";
                txtname.Focus();
            }
            else if (!Regex.IsMatch(txtpassword.Text, @"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"))
            {
                MessageBox.Show("Invalid password. Password must be at least 8 characters long and contain at least one letter and one digit", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtpassword.Focus();
            }
            else if (!Regex.IsMatch(txtemail.Text, @"^\S+@\S+\.\S+$"))
            {
                MessageBox.Show("Invalid email address", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemail.Text = "";
                txtemail.Focus();
            }
            else if (!Regex.IsMatch(txtphone.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid phone number. Phone number must be 10 digits long", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphone.Text = "";
                txtphone.Focus();
            }
            else if (!Regex.IsMatch(txtcity.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid city name. City name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcity.Text = "";
                txtcity.Focus();
            }
            else if (!Regex.IsMatch(txtage.Text, @"^\d+$") && Convert.ToInt32(txtage.Text) > 18)
            {
                MessageBox.Show("Invalid age. Age must be a positive integer", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtage.Text = "";
                txtage.Focus();
            }
            else if (!Regex.IsMatch(txtcountry.Text, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Invalid country name. Country name can only contain alphabetic characters", "Registration Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcountry.Text = "";
                txtcountry.Focus();
            }
            else
            {
                connection.Open();
                string query = "UPDATE Customer SET name = @name, password = @password, phone_number = @phone, email = @email, "
                               + "city = @city, age = @age, country = @country WHERE username = @username";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", txtname.Text);
                    command.Parameters.AddWithValue("@password", txtpassword.Text);
                    command.Parameters.AddWithValue("@phone", txtphone.Text);
                    command.Parameters.AddWithValue("@email", txtemail.Text);
                    command.Parameters.AddWithValue("@city", txtcity.Text);
                    command.Parameters.AddWithValue("@age", int.Parse(txtage.Text));
                    command.Parameters.AddWithValue("@country", txtcountry.Text);
                    command.Parameters.AddWithValue("@username", customer.username);
                    customer.age = int.Parse(txtage.Text);
                    customer.city = txtcity.Text;
                    customer.country = txtcountry.Text;
                    customer.email = txtemail.Text;
                    customer.password = txtpassword.Text;
                    customer.name = txtname.Text;
                    customer.phone = txtphone.Text;
                    label1.Text = $"Welcome + ";
                    label13.Text = "{customer.name}";
                    command.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Changes Saved Successfully",
                    "Update Profile",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            editprofile_btn_Click(sender, e);
            MessageBox.Show("Changes UnSaved",
                "Update Profile",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void viewbooking_btn_Click(object sender, EventArgs e)
        {
            Hide(ViewBooking_panel, editprofile_panel, booktrip_panel);
            select_panel.Visible = false;
            buttoncoloring(viewbooking_btn, editprofile_btn, booktrip_Btn);
            ViewBookingGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ViewBookingGrid.CellClick += (s, args) =>
            {
                if (args.RowIndex >= 0)
                {
                    ViewBookingGrid.Rows[args.RowIndex].Selected = true;
                }
            };
            connection.Open();
            SqlCommand command;
            string query = "SELECT Booking.Trip_id as Trip_id,Booking.Booking_id AS ID, CAST((Booking.price / Trip.price) AS INT) AS Seats, Trip.trip_date AS TripDate, Trip.source AS Source, Trip.destination AS Destination " +
                           "FROM Booking " +
                           $"JOIN Trip ON Booking.trip_id = Trip.trip_id and Booking.customer_id = {customer.id}";
            using (command = new SqlCommand(query, connection))
            {
                SqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);
                ViewBookingGrid.DataSource = dataTable;
                ViewBookingGrid.Columns["Trip_id"].Visible = false;
                ViewBookingGrid.Columns["ID"].Visible = false;
                ViewBookingGrid.Columns["Seats"].Width = 35;
                ViewBookingGrid.Columns["Seats"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                ViewBookingGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                reader.Close();
            }
            connection.Close();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(ViewBookingGrid.SelectedRows[0].Cells["ID"].Value);
            int trip_id = Convert.ToInt32(ViewBookingGrid.SelectedRows[0].Cells["Trip_id"].Value);
            connection.Open();
            string query = $"update seat set state = 0 , booking_id = null where booking_id = {ID} and trip_id = {trip_id}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }
            query = $"Delete from booking where trip_id = {trip_id} and customer_id = {customer.id} and booking_id = {ID}";
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                int result = command.ExecuteNonQuery();
            }
            connection.Close();
            MessageBox.Show("Deleted Successfully",
                "Delete Booking",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            viewbooking_btn_Click(sender, e);
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            new StartPage().Show();
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Train_Booking.Classes;

namespace Train_Booking
{
    public partial class CustomerInterface : Form
    {
        public Customer? customer = null;
        public CustomerInterface(Customer? customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void CustomerInterface_Load(object sender, EventArgs e)
        {
            label1.Text = $"Welcome, {customer.name}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            new StartPage().Show();
            Hide();
        }
    }
}

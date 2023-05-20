using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_Booking
{
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void Signin_btn_Click(object sender, EventArgs e)
        {
            new Signin().Show();
            this.Hide();
        }

        private void Signup_btn_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }
    }
}

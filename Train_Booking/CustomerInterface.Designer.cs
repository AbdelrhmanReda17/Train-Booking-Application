using System.Windows.Forms;

namespace Train_Booking
{
    partial class CustomerInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerInterface));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            editprofile_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            booktrip_Btn = new Bunifu.Framework.UI.BunifuThinButton2();
            logout_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            booktrip_panel = new Panel();
            bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            dataGridView = new DataGridView();
            label2 = new Label();
            select_panel = new Panel();
            SeatsCheckBox2 = new CheckedListBox();
            label3 = new Label();
            bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            SeatsCheckBox1 = new CheckedListBox();
            editprofile_panel = new Panel();
            checkBox1 = new CheckBox();
            txtage = new TextBox();
            label11 = new Label();
            txtcountry = new TextBox();
            label10 = new Label();
            txtcity = new TextBox();
            label9 = new Label();
            txtphone = new TextBox();
            label8 = new Label();
            txtpassword = new TextBox();
            label7 = new Label();
            txtemail = new TextBox();
            label6 = new Label();
            txtname = new TextBox();
            label5 = new Label();
            bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            label4 = new Label();
            bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            ViewBooking_panel = new Panel();
            bunifuThinButton25 = new Bunifu.Framework.UI.BunifuThinButton2();
            ViewBookingGrid = new DataGridView();
            label12 = new Label();
            viewbooking_btn = new Bunifu.Framework.UI.BunifuThinButton2();
            ApplicationPanel = new Panel();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            booktrip_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            select_panel.SuspendLayout();
            editprofile_panel.SuspendLayout();
            ViewBooking_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ViewBookingGrid).BeginInit();
            ApplicationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(5, 42, 97);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 82);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Welcome";
            // 
            // editprofile_btn
            // 
            editprofile_btn.ActiveBorderThickness = 1;
            editprofile_btn.ActiveCornerRadius = 1;
            editprofile_btn.ActiveFillColor = Color.FromArgb(5, 42, 97);
            editprofile_btn.ActiveForecolor = Color.White;
            editprofile_btn.ActiveLineColor = Color.FromArgb(5, 42, 97);
            editprofile_btn.BackColor = Color.FromArgb(5, 42, 97);
            editprofile_btn.BackgroundImage = (Image)resources.GetObject("editprofile_btn.BackgroundImage");
            editprofile_btn.ButtonText = "Edit Profile";
            editprofile_btn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editprofile_btn.ForeColor = Color.SeaGreen;
            editprofile_btn.IdleBorderThickness = 1;
            editprofile_btn.IdleCornerRadius = 1;
            editprofile_btn.IdleFillColor = Color.White;
            editprofile_btn.IdleForecolor = Color.FromArgb(5, 42, 97);
            editprofile_btn.IdleLineColor = Color.FromArgb(5, 42, 97);
            editprofile_btn.Location = new Point(-2, 265);
            editprofile_btn.Margin = new Padding(4);
            editprofile_btn.Name = "editprofile_btn";
            editprofile_btn.Size = new Size(130, 62);
            editprofile_btn.TabIndex = 15;
            editprofile_btn.TextAlign = ContentAlignment.MiddleCenter;
            editprofile_btn.Click += editprofile_btn_Click;
            // 
            // booktrip_Btn
            // 
            booktrip_Btn.ActiveBorderThickness = 1;
            booktrip_Btn.ActiveCornerRadius = 1;
            booktrip_Btn.ActiveFillColor = Color.FromArgb(5, 42, 97);
            booktrip_Btn.ActiveForecolor = Color.White;
            booktrip_Btn.ActiveLineColor = Color.FromArgb(5, 42, 97);
            booktrip_Btn.BackColor = Color.FromArgb(5, 42, 97);
            booktrip_Btn.BackgroundImage = (Image)resources.GetObject("booktrip_Btn.BackgroundImage");
            booktrip_Btn.ButtonText = "Book a Trip";
            booktrip_Btn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            booktrip_Btn.ForeColor = Color.SeaGreen;
            booktrip_Btn.IdleBorderThickness = 1;
            booktrip_Btn.IdleCornerRadius = 1;
            booktrip_Btn.IdleFillColor = Color.White;
            booktrip_Btn.IdleForecolor = Color.FromArgb(5, 42, 97);
            booktrip_Btn.IdleLineColor = Color.FromArgb(5, 42, 97);
            booktrip_Btn.Location = new Point(-2, 132);
            booktrip_Btn.Margin = new Padding(4);
            booktrip_Btn.Name = "booktrip_Btn";
            booktrip_Btn.Size = new Size(130, 55);
            booktrip_Btn.TabIndex = 14;
            booktrip_Btn.TextAlign = ContentAlignment.MiddleCenter;
            booktrip_Btn.Click += show_Click;
            // 
            // logout_btn
            // 
            logout_btn.ActiveBorderThickness = 1;
            logout_btn.ActiveCornerRadius = 1;
            logout_btn.ActiveFillColor = Color.White;
            logout_btn.ActiveForecolor = Color.FromArgb(5, 42, 97);
            logout_btn.ActiveLineColor = Color.FromArgb(5, 42, 97);
            logout_btn.BackColor = Color.FromArgb(5, 42, 97);
            logout_btn.BackgroundImage = (Image)resources.GetObject("logout_btn.BackgroundImage");
            logout_btn.ButtonText = "Log Out";
            logout_btn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            logout_btn.ForeColor = Color.SeaGreen;
            logout_btn.IdleBorderThickness = 1;
            logout_btn.IdleCornerRadius = 1;
            logout_btn.IdleFillColor = Color.FromArgb(5, 42, 97);
            logout_btn.IdleForecolor = Color.White;
            logout_btn.IdleLineColor = Color.FromArgb(5, 42, 97);
            logout_btn.Location = new Point(-2, 406);
            logout_btn.Margin = new Padding(4);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(130, 41);
            logout_btn.TabIndex = 16;
            logout_btn.TextAlign = ContentAlignment.MiddleCenter;
            logout_btn.Click += logout_btn_Click;
            // 
            // booktrip_panel
            // 
            booktrip_panel.Controls.Add(bunifuThinButton21);
            booktrip_panel.Controls.Add(dataGridView);
            booktrip_panel.Controls.Add(label2);
            booktrip_panel.Location = new Point(130, 0);
            booktrip_panel.Name = "booktrip_panel";
            booktrip_panel.Size = new Size(398, 450);
            booktrip_panel.TabIndex = 17;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.ActiveForecolor = Color.White;
            bunifuThinButton21.ActiveLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.BackColor = Color.White;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "Confirm";
            bunifuThinButton21.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaGreen;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.White;
            bunifuThinButton21.IdleForecolor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.IdleLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.Location = new Point(52, 398);
            bunifuThinButton21.Margin = new Padding(4);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(273, 42);
            bunifuThinButton21.TabIndex = 18;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += bunifuThinButton21_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView.Location = new Point(3, 30);
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(379, 361);
            dataGridView.TabIndex = 18;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(5, 42, 97);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 0;
            label2.Text = "Select Trip ";
            // 
            // select_panel
            // 
            select_panel.Controls.Add(SeatsCheckBox2);
            select_panel.Controls.Add(label3);
            select_panel.Controls.Add(bunifuThinButton22);
            select_panel.Controls.Add(SeatsCheckBox1);
            select_panel.Location = new Point(130, 0);
            select_panel.Name = "select_panel";
            select_panel.Size = new Size(385, 450);
            select_panel.TabIndex = 19;
            // 
            // SeatsCheckBox2
            // 
            SeatsCheckBox2.BorderStyle = BorderStyle.None;
            SeatsCheckBox2.ColumnWidth = 368;
            SeatsCheckBox2.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SeatsCheckBox2.ForeColor = Color.FromArgb(5, 42, 97);
            SeatsCheckBox2.FormattingEnabled = true;
            SeatsCheckBox2.Location = new Point(192, 39);
            SeatsCheckBox2.Name = "SeatsCheckBox2";
            SeatsCheckBox2.Size = new Size(136, 330);
            SeatsCheckBox2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(5, 42, 97);
            label3.Location = new Point(3, 3);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 19;
            label3.Text = "Select Seats";
            // 
            // bunifuThinButton22
            // 
            bunifuThinButton22.ActiveBorderThickness = 1;
            bunifuThinButton22.ActiveCornerRadius = 20;
            bunifuThinButton22.ActiveFillColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton22.ActiveForecolor = Color.White;
            bunifuThinButton22.ActiveLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton22.BackColor = Color.White;
            bunifuThinButton22.BackgroundImage = (Image)resources.GetObject("bunifuThinButton22.BackgroundImage");
            bunifuThinButton22.ButtonText = "Confirm Booking";
            bunifuThinButton22.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuThinButton22.ForeColor = Color.SeaGreen;
            bunifuThinButton22.IdleBorderThickness = 1;
            bunifuThinButton22.IdleCornerRadius = 20;
            bunifuThinButton22.IdleFillColor = Color.White;
            bunifuThinButton22.IdleForecolor = Color.FromArgb(5, 42, 97);
            bunifuThinButton22.IdleLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton22.Location = new Point(52, 408);
            bunifuThinButton22.Margin = new Padding(4);
            bunifuThinButton22.Name = "bunifuThinButton22";
            bunifuThinButton22.Size = new Size(273, 42);
            bunifuThinButton22.TabIndex = 16;
            bunifuThinButton22.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton22.Click += bunifuThinButton22_Click;
            // 
            // SeatsCheckBox1
            // 
            SeatsCheckBox1.BorderStyle = BorderStyle.None;
            SeatsCheckBox1.ColumnWidth = 368;
            SeatsCheckBox1.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            SeatsCheckBox1.ForeColor = Color.FromArgb(5, 42, 97);
            SeatsCheckBox1.FormattingEnabled = true;
            SeatsCheckBox1.Location = new Point(39, 39);
            SeatsCheckBox1.Name = "SeatsCheckBox1";
            SeatsCheckBox1.Size = new Size(136, 330);
            SeatsCheckBox1.TabIndex = 1;
            // 
            // editprofile_panel
            // 
            editprofile_panel.Controls.Add(checkBox1);
            editprofile_panel.Controls.Add(txtage);
            editprofile_panel.Controls.Add(label11);
            editprofile_panel.Controls.Add(txtcountry);
            editprofile_panel.Controls.Add(label10);
            editprofile_panel.Controls.Add(txtcity);
            editprofile_panel.Controls.Add(label9);
            editprofile_panel.Controls.Add(txtphone);
            editprofile_panel.Controls.Add(label8);
            editprofile_panel.Controls.Add(txtpassword);
            editprofile_panel.Controls.Add(label7);
            editprofile_panel.Controls.Add(txtemail);
            editprofile_panel.Controls.Add(label6);
            editprofile_panel.Controls.Add(txtname);
            editprofile_panel.Controls.Add(label5);
            editprofile_panel.Controls.Add(bunifuThinButton24);
            editprofile_panel.Controls.Add(label4);
            editprofile_panel.Controls.Add(bunifuThinButton23);
            editprofile_panel.Location = new Point(130, 0);
            editprofile_panel.Name = "editprofile_panel";
            editprofile_panel.Size = new Size(385, 450);
            editprofile_panel.TabIndex = 20;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.FromArgb(5, 42, 97);
            checkBox1.Location = new Point(216, 156);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(112, 19);
            checkBox1.TabIndex = 35;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // txtage
            // 
            txtage.BorderStyle = BorderStyle.FixedSingle;
            txtage.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtage.ForeColor = Color.FromArgb(5, 42, 97);
            txtage.Location = new Point(235, 249);
            txtage.Name = "txtage";
            txtage.Size = new Size(78, 27);
            txtage.TabIndex = 34;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.FromArgb(5, 42, 97);
            label11.Location = new Point(235, 227);
            label11.Name = "label11";
            label11.Size = new Size(36, 19);
            label11.TabIndex = 33;
            label11.Text = "Age";
            // 
            // txtcountry
            // 
            txtcountry.BorderStyle = BorderStyle.FixedSingle;
            txtcountry.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtcountry.ForeColor = Color.FromArgb(5, 42, 97);
            txtcountry.Location = new Point(195, 312);
            txtcountry.Name = "txtcountry";
            txtcountry.Size = new Size(133, 27);
            txtcountry.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.FromArgb(5, 42, 97);
            label10.Location = new Point(195, 290);
            label10.Name = "label10";
            label10.Size = new Size(63, 19);
            label10.TabIndex = 31;
            label10.Text = "Country";
            // 
            // txtcity
            // 
            txtcity.BorderStyle = BorderStyle.FixedSingle;
            txtcity.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtcity.ForeColor = Color.FromArgb(5, 42, 97);
            txtcity.Location = new Point(28, 312);
            txtcity.Name = "txtcity";
            txtcity.Size = new Size(117, 27);
            txtcity.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.FromArgb(5, 42, 97);
            label9.Location = new Point(28, 290);
            label9.Name = "label9";
            label9.Size = new Size(35, 19);
            label9.TabIndex = 29;
            label9.Text = "City";
            // 
            // txtphone
            // 
            txtphone.BorderStyle = BorderStyle.FixedSingle;
            txtphone.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtphone.ForeColor = Color.FromArgb(5, 42, 97);
            txtphone.Location = new Point(27, 249);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(148, 27);
            txtphone.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.FromArgb(5, 42, 97);
            label8.Location = new Point(27, 227);
            label8.Name = "label8";
            label8.Size = new Size(110, 19);
            label8.TabIndex = 27;
            label8.Text = "Phone Number";
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.FixedSingle;
            txtpassword.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(5, 42, 97);
            txtpassword.Location = new Point(27, 123);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.Size = new Size(228, 27);
            txtpassword.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.FromArgb(5, 42, 97);
            label7.Location = new Point(28, 101);
            label7.Name = "label7";
            label7.Size = new Size(73, 19);
            label7.TabIndex = 25;
            label7.Text = "Password";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Nirmala UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtemail.ForeColor = Color.FromArgb(5, 42, 97);
            txtemail.Location = new Point(27, 185);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(231, 27);
            txtemail.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(5, 42, 97);
            label6.Location = new Point(27, 163);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 23;
            label6.Text = "Email";
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            txtname.ForeColor = Color.FromArgb(5, 42, 97);
            txtname.Location = new Point(27, 61);
            txtname.Name = "txtname";
            txtname.Size = new Size(228, 29);
            txtname.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(5, 42, 97);
            label5.Location = new Point(28, 39);
            label5.Name = "label5";
            label5.Size = new Size(49, 19);
            label5.TabIndex = 21;
            label5.Text = "Name";
            // 
            // bunifuThinButton24
            // 
            bunifuThinButton24.ActiveBorderThickness = 1;
            bunifuThinButton24.ActiveCornerRadius = 20;
            bunifuThinButton24.ActiveFillColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton24.ActiveForecolor = Color.White;
            bunifuThinButton24.ActiveLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton24.BackColor = Color.White;
            bunifuThinButton24.BackgroundImage = (Image)resources.GetObject("bunifuThinButton24.BackgroundImage");
            bunifuThinButton24.ButtonText = "Cancel";
            bunifuThinButton24.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuThinButton24.ForeColor = Color.SeaGreen;
            bunifuThinButton24.IdleBorderThickness = 1;
            bunifuThinButton24.IdleCornerRadius = 20;
            bunifuThinButton24.IdleFillColor = Color.White;
            bunifuThinButton24.IdleForecolor = Color.FromArgb(5, 42, 97);
            bunifuThinButton24.IdleLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton24.Location = new Point(201, 368);
            bunifuThinButton24.Margin = new Padding(4);
            bunifuThinButton24.Name = "bunifuThinButton24";
            bunifuThinButton24.Size = new Size(137, 42);
            bunifuThinButton24.TabIndex = 20;
            bunifuThinButton24.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton24.Click += bunifuThinButton24_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.Popup;
            label4.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(5, 42, 97);
            label4.Location = new Point(3, 3);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 19;
            label4.Text = "Edit Profile";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // bunifuThinButton23
            // 
            bunifuThinButton23.ActiveBorderThickness = 1;
            bunifuThinButton23.ActiveCornerRadius = 20;
            bunifuThinButton23.ActiveFillColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton23.ActiveForecolor = Color.White;
            bunifuThinButton23.ActiveLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton23.BackColor = Color.White;
            bunifuThinButton23.BackgroundImage = (Image)resources.GetObject("bunifuThinButton23.BackgroundImage");
            bunifuThinButton23.ButtonText = "Confirm";
            bunifuThinButton23.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuThinButton23.ForeColor = Color.SeaGreen;
            bunifuThinButton23.IdleBorderThickness = 1;
            bunifuThinButton23.IdleCornerRadius = 20;
            bunifuThinButton23.IdleFillColor = Color.White;
            bunifuThinButton23.IdleForecolor = Color.FromArgb(5, 42, 97);
            bunifuThinButton23.IdleLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton23.Location = new Point(27, 368);
            bunifuThinButton23.Margin = new Padding(4);
            bunifuThinButton23.Name = "bunifuThinButton23";
            bunifuThinButton23.Size = new Size(137, 42);
            bunifuThinButton23.TabIndex = 16;
            bunifuThinButton23.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton23.Click += bunifuThinButton23_Click;
            // 
            // ViewBooking_panel
            // 
            ViewBooking_panel.Controls.Add(bunifuThinButton25);
            ViewBooking_panel.Controls.Add(ViewBookingGrid);
            ViewBooking_panel.Controls.Add(label12);
            ViewBooking_panel.Location = new Point(130, 0);
            ViewBooking_panel.Name = "ViewBooking_panel";
            ViewBooking_panel.Size = new Size(389, 444);
            ViewBooking_panel.TabIndex = 22;
            // 
            // bunifuThinButton25
            // 
            bunifuThinButton25.ActiveBorderThickness = 1;
            bunifuThinButton25.ActiveCornerRadius = 20;
            bunifuThinButton25.ActiveFillColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton25.ActiveForecolor = Color.White;
            bunifuThinButton25.ActiveLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton25.BackColor = Color.White;
            bunifuThinButton25.BackgroundImage = (Image)resources.GetObject("bunifuThinButton25.BackgroundImage");
            bunifuThinButton25.ButtonText = "Delete booking ";
            bunifuThinButton25.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuThinButton25.ForeColor = Color.SeaGreen;
            bunifuThinButton25.IdleBorderThickness = 1;
            bunifuThinButton25.IdleCornerRadius = 20;
            bunifuThinButton25.IdleFillColor = Color.White;
            bunifuThinButton25.IdleForecolor = Color.FromArgb(5, 42, 97);
            bunifuThinButton25.IdleLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton25.Location = new Point(52, 398);
            bunifuThinButton25.Margin = new Padding(4);
            bunifuThinButton25.Name = "bunifuThinButton25";
            bunifuThinButton25.Size = new Size(273, 42);
            bunifuThinButton25.TabIndex = 23;
            bunifuThinButton25.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton25.Click += bunifuThinButton25_Click;
            // 
            // ViewBookingGrid
            // 
            ViewBookingGrid.AllowUserToAddRows = false;
            ViewBookingGrid.AllowUserToDeleteRows = false;
            ViewBookingGrid.AllowUserToResizeColumns = false;
            ViewBookingGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            ViewBookingGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            ViewBookingGrid.BackgroundColor = Color.White;
            ViewBookingGrid.BorderStyle = BorderStyle.None;
            ViewBookingGrid.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle7.ForeColor = Color.White;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle7.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            ViewBookingGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            ViewBookingGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            ViewBookingGrid.DefaultCellStyle = dataGridViewCellStyle8;
            ViewBookingGrid.Location = new Point(5, 30);
            ViewBookingGrid.Name = "ViewBookingGrid";
            ViewBookingGrid.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle9.ForeColor = Color.White;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            ViewBookingGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(5, 42, 97);
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            ViewBookingGrid.RowsDefaultCellStyle = dataGridViewCellStyle10;
            ViewBookingGrid.RowTemplate.Height = 25;
            ViewBookingGrid.Size = new Size(379, 361);
            ViewBookingGrid.TabIndex = 18;
            ViewBookingGrid.CellDoubleClick += dataGridView_CellDoubleClick;
            ViewBookingGrid.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label12.ForeColor = Color.FromArgb(5, 42, 97);
            label12.Location = new Point(3, 3);
            label12.Name = "label12";
            label12.Size = new Size(187, 25);
            label12.TabIndex = 19;
            label12.Text = "Your Trip's Booking";
            // 
            // viewbooking_btn
            // 
            viewbooking_btn.ActiveBorderThickness = 1;
            viewbooking_btn.ActiveCornerRadius = 1;
            viewbooking_btn.ActiveFillColor = Color.FromArgb(5, 42, 97);
            viewbooking_btn.ActiveForecolor = Color.White;
            viewbooking_btn.ActiveLineColor = Color.FromArgb(5, 42, 97);
            viewbooking_btn.BackColor = Color.FromArgb(5, 42, 97);
            viewbooking_btn.BackgroundImage = (Image)resources.GetObject("viewbooking_btn.BackgroundImage");
            viewbooking_btn.ButtonText = "View Bookings";
            viewbooking_btn.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            viewbooking_btn.ForeColor = Color.SeaGreen;
            viewbooking_btn.IdleBorderThickness = 1;
            viewbooking_btn.IdleCornerRadius = 1;
            viewbooking_btn.IdleFillColor = Color.White;
            viewbooking_btn.IdleForecolor = Color.FromArgb(5, 42, 97);
            viewbooking_btn.IdleLineColor = Color.FromArgb(5, 42, 97);
            viewbooking_btn.Location = new Point(-2, 195);
            viewbooking_btn.Margin = new Padding(4);
            viewbooking_btn.Name = "viewbooking_btn";
            viewbooking_btn.Size = new Size(130, 55);
            viewbooking_btn.TabIndex = 21;
            viewbooking_btn.TextAlign = ContentAlignment.MiddleCenter;
            viewbooking_btn.Click += viewbooking_btn_Click;
            // 
            // ApplicationPanel
            // 
            ApplicationPanel.BackColor = Color.FromArgb(5, 42, 97);
            ApplicationPanel.BorderStyle = BorderStyle.Fixed3D;
            ApplicationPanel.Controls.Add(label13);
            ApplicationPanel.Controls.Add(pictureBox1);
            ApplicationPanel.Controls.Add(label1);
            ApplicationPanel.Controls.Add(booktrip_Btn);
            ApplicationPanel.Controls.Add(logout_btn);
            ApplicationPanel.Controls.Add(viewbooking_btn);
            ApplicationPanel.Controls.Add(editprofile_btn);
            ApplicationPanel.ForeColor = Color.FromArgb(5, 42, 97);
            ApplicationPanel.Location = new Point(0, 0);
            ApplicationPanel.Name = "ApplicationPanel";
            ApplicationPanel.Size = new Size(130, 450);
            ApplicationPanel.TabIndex = 23;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.White;
            label13.Location = new Point(25, 102);
            label13.Name = "label13";
            label13.Size = new Size(75, 15);
            label13.TabIndex = 22;
            label13.Text = "Abdelrhman";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CustomerInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(516, 450);
            Controls.Add(booktrip_panel);
            Controls.Add(select_panel);
            Controls.Add(editprofile_panel);
            Controls.Add(ViewBooking_panel);
            Controls.Add(ApplicationPanel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "CustomerInterface";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerInterface";
            Load += CustomerInterface_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            booktrip_panel.ResumeLayout(false);
            booktrip_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            select_panel.ResumeLayout(false);
            select_panel.PerformLayout();
            editprofile_panel.ResumeLayout(false);
            editprofile_panel.PerformLayout();
            ViewBooking_panel.ResumeLayout(false);
            ViewBooking_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ViewBookingGrid).EndInit();
            ApplicationPanel.ResumeLayout(false);
            ApplicationPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 editprofile_btn;
        private Bunifu.Framework.UI.BunifuThinButton2 booktrip_Btn;
        private Bunifu.Framework.UI.BunifuThinButton2 logout_btn;
        private Panel booktrip_panel;
        private Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private DataGridView dataGridView;
        private Panel select_panel;
        private CheckedListBox SeatsCheckBox1;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Panel editprofile_panel;
        private TextBox txtname;
        private Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private Label label4;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private TextBox txtage;
        private Label label11;
        private TextBox txtcountry;
        private Label label10;
        private TextBox txtcity;
        private Label label9;
        private TextBox txtphone;
        private Label label8;
        private TextBox txtpassword;
        private Label label7;
        private TextBox txtemail;
        private Label label6;
        private CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 viewbooking_btn;
        private Panel ViewBooking_panel;
        private DataGridView ViewBookingGrid;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton25;
        private Panel ApplicationPanel;
        private CheckedListBox SeatsCheckBox2;
        private Label label12;
        private Label label13;
    }
}
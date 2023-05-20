using Bunifu.Framework.UI;

namespace Train_Booking
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            label1 = new Label();
            label2 = new Label();
            loginsubmit_btn = new BunifuThinButton2();
            bunifuThinButton21 = new BunifuThinButton2();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Sylfaen", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(5, 42, 97);
            label1.Location = new Point(827, 58);
            label1.Name = "label1";
            label1.Size = new Size(305, 88);
            label1.TabIndex = 15;
            label1.Text = "Train Booker";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoEllipsis = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Sylfaen", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(0, -2);
            label2.Name = "label2";
            label2.Size = new Size(1146, 384);
            label2.TabIndex = 16;
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginsubmit_btn
            // 
            loginsubmit_btn.ActiveBorderThickness = 1;
            loginsubmit_btn.ActiveCornerRadius = 20;
            loginsubmit_btn.ActiveFillColor = Color.White;
            loginsubmit_btn.ActiveForecolor = Color.FromArgb(5, 42, 97);
            loginsubmit_btn.ActiveLineColor = Color.FromArgb(5, 42, 97);
            loginsubmit_btn.BackColor = Color.White;
            loginsubmit_btn.BackgroundImage = (Image)resources.GetObject("loginsubmit_btn.BackgroundImage");
            loginsubmit_btn.ButtonText = "SIGN IN";
            loginsubmit_btn.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginsubmit_btn.ForeColor = Color.SeaShell;
            loginsubmit_btn.IdleBorderThickness = 1;
            loginsubmit_btn.IdleCornerRadius = 20;
            loginsubmit_btn.IdleFillColor = Color.FromArgb(5, 42, 97);
            loginsubmit_btn.IdleForecolor = Color.White;
            loginsubmit_btn.IdleLineColor = Color.FromArgb(5, 42, 97);
            loginsubmit_btn.Location = new Point(846, 162);
            loginsubmit_btn.Margin = new Padding(5);
            loginsubmit_btn.Name = "loginsubmit_btn";
            loginsubmit_btn.Size = new Size(263, 50);
            loginsubmit_btn.TabIndex = 19;
            loginsubmit_btn.TextAlign = ContentAlignment.MiddleCenter;
            loginsubmit_btn.Click += Signin_btn_Click;
            // 
            // bunifuThinButton21
            // 
            bunifuThinButton21.ActiveBorderThickness = 1;
            bunifuThinButton21.ActiveCornerRadius = 20;
            bunifuThinButton21.ActiveFillColor = Color.White;
            bunifuThinButton21.ActiveForecolor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.ActiveLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.BackColor = Color.White;
            bunifuThinButton21.BackgroundImage = (Image)resources.GetObject("bunifuThinButton21.BackgroundImage");
            bunifuThinButton21.ButtonText = "SIGN UP";
            bunifuThinButton21.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bunifuThinButton21.ForeColor = Color.SeaShell;
            bunifuThinButton21.IdleBorderThickness = 1;
            bunifuThinButton21.IdleCornerRadius = 20;
            bunifuThinButton21.IdleFillColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.IdleForecolor = Color.White;
            bunifuThinButton21.IdleLineColor = Color.FromArgb(5, 42, 97);
            bunifuThinButton21.Location = new Point(846, 233);
            bunifuThinButton21.Margin = new Padding(5);
            bunifuThinButton21.Name = "bunifuThinButton21";
            bunifuThinButton21.Size = new Size(263, 50);
            bunifuThinButton21.TabIndex = 20;
            bunifuThinButton21.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton21.Click += Signup_btn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(807, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(339, 384);
            panel1.TabIndex = 21;
            // 
            // StartPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.White;
            ClientSize = new Size(1144, 376);
            Controls.Add(bunifuThinButton21);
            Controls.Add(loginsubmit_btn);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Train Booker";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private BunifuThinButton2 loginsubmit_btn;
        private BunifuThinButton2 bunifuThinButton21;
        private Panel panel1;
    }
}
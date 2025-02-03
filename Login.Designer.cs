namespace HotelReservationSystem3
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.close_click1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.login_username1 = new System.Windows.Forms.TextBox();
            this.login_password1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.login_showPassword1 = new System.Windows.Forms.CheckBox();
            this.login_loginBtn1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // close_click1
            // 
            this.close_click1.AutoSize = true;
            this.close_click1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_click1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_click1.Location = new System.Drawing.Point(991, -1);
            this.close_click1.Name = "close_click1";
            this.close_click1.Size = new System.Drawing.Size(19, 20);
            this.close_click1.TabIndex = 11;
            this.close_click1.Text = "X";
            this.close_click1.Click += new System.EventHandler(this.close_click1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Location = new System.Drawing.Point(2, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 564);
            this.panel3.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(95, 364);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(312, 31);
            this.label15.TabIndex = 14;
            this.label15.Text = "Hotel Reservation System";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(555, 78);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(273, 31);
            this.label12.TabIndex = 13;
            this.label12.Text = "Welcome Back, User !!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(557, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 23);
            this.label13.TabIndex = 14;
            this.label13.Text = "Username :";
            // 
            // login_username1
            // 
            this.login_username1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_username1.Location = new System.Drawing.Point(561, 195);
            this.login_username1.Name = "login_username1";
            this.login_username1.Size = new System.Drawing.Size(394, 28);
            this.login_username1.TabIndex = 15;
            this.login_username1.TextChanged += new System.EventHandler(this.login_username1_TextChanged);
            // 
            // login_password1
            // 
            this.login_password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_password1.Location = new System.Drawing.Point(561, 294);
            this.login_password1.Name = "login_password1";
            this.login_password1.PasswordChar = '*';
            this.login_password1.Size = new System.Drawing.Size(394, 28);
            this.login_password1.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(557, 253);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Password :";
            // 
            // login_showPassword1
            // 
            this.login_showPassword1.AutoSize = true;
            this.login_showPassword1.Location = new System.Drawing.Point(563, 328);
            this.login_showPassword1.Name = "login_showPassword1";
            this.login_showPassword1.Size = new System.Drawing.Size(125, 20);
            this.login_showPassword1.TabIndex = 18;
            this.login_showPassword1.Text = "Show Password";
            this.login_showPassword1.UseVisualStyleBackColor = true;
            this.login_showPassword1.CheckedChanged += new System.EventHandler(this.login_showPassword1_CheckedChanged);
            // 
            // login_loginBtn1
            // 
            this.login_loginBtn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(14)))), ((int)(((byte)(28)))));
            this.login_loginBtn1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_loginBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_loginBtn1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.login_loginBtn1.Location = new System.Drawing.Point(647, 377);
            this.login_loginBtn1.Name = "login_loginBtn1";
            this.login_loginBtn1.Size = new System.Drawing.Size(194, 41);
            this.login_loginBtn1.TabIndex = 19;
            this.login_loginBtn1.Text = "Login";
            this.login_loginBtn1.UseVisualStyleBackColor = false;
            this.login_loginBtn1.Click += new System.EventHandler(this.login_loginBtn1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(133, 79);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(227, 222);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1011, 563);
            this.Controls.Add(this.login_loginBtn1);
            this.Controls.Add(this.login_showPassword1);
            this.Controls.Add(this.login_password1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.login_username1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.close_click1);
            this.Name = "Login";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox login_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox login_password;
        private System.Windows.Forms.Button login_loginBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button login_registerBtn;
        private System.Windows.Forms.CheckBox login_showPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label close_click;
        private System.Windows.Forms.Label close_click1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox login_username1;
        private System.Windows.Forms.TextBox login_password1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox login_showPassword1;
        private System.Windows.Forms.Button login_loginBtn1;
        private System.Windows.Forms.Label label15;
    }
}


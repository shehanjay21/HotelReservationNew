namespace HotelReservationSystem3
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_slide = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.roomsBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_main = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.roomsBtn);
            this.panel1.Controls.Add(this.customerBtn);
            this.panel1.Controls.Add(this.reservationBtn);
            this.panel1.Controls.Add(this.dashboardBtn);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 694);
            this.panel1.TabIndex = 0;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.pictureBox2);
            this.panel_cover.Controls.Add(this.panel_slide);
            this.panel_cover.Controls.Add(this.label2);
            this.panel_cover.Controls.Add(this.label1);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_cover.Location = new System.Drawing.Point(0, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(940, 700);
            this.panel_cover.TabIndex = 1;
            this.panel_cover.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_cover_Paint);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hotel Reservation System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(918, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(200, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(11, 82);
            this.panel2.TabIndex = 3;
            // 
            // panel_slide
            // 
            this.panel_slide.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel_slide.Location = new System.Drawing.Point(0, 125);
            this.panel_slide.Name = "panel_slide";
            this.panel_slide.Size = new System.Drawing.Size(11, 82);
            this.panel_slide.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HotelReservationSystem3.Properties.Resources.modern_luxury_bedroom_suite_and_bathroom_with_working_table_scaled;
            this.pictureBox2.Location = new System.Drawing.Point(68, 86);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(772, 465);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutBtn.Image = global::HotelReservationSystem3.Properties.Resources.icons8_logout_50;
            this.logoutBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.logoutBtn.Location = new System.Drawing.Point(0, 569);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(200, 82);
            this.logoutBtn.TabIndex = 5;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logoutBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // roomsBtn
            // 
            this.roomsBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.roomsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.roomsBtn.Image = global::HotelReservationSystem3.Properties.Resources.icons8_room_50;
            this.roomsBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.roomsBtn.Location = new System.Drawing.Point(0, 456);
            this.roomsBtn.Name = "roomsBtn";
            this.roomsBtn.Size = new System.Drawing.Size(200, 82);
            this.roomsBtn.TabIndex = 4;
            this.roomsBtn.Text = "Rooms";
            this.roomsBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.roomsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.roomsBtn.UseVisualStyleBackColor = false;
            this.roomsBtn.Click += new System.EventHandler(this.roomsBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Image = global::HotelReservationSystem3.Properties.Resources.icons8_customer_50;
            this.customerBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.customerBtn.Location = new System.Drawing.Point(-3, 233);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(200, 82);
            this.customerBtn.TabIndex = 3;
            this.customerBtn.Text = "Customer";
            this.customerBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customerBtn.UseVisualStyleBackColor = false;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // reservationBtn
            // 
            this.reservationBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.reservationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservationBtn.Image = global::HotelReservationSystem3.Properties.Resources.icons8_reservation_50;
            this.reservationBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reservationBtn.Location = new System.Drawing.Point(0, 342);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(200, 82);
            this.reservationBtn.TabIndex = 2;
            this.reservationBtn.Text = "Reservation";
            this.reservationBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.reservationBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.reservationBtn.UseVisualStyleBackColor = false;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashboardBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.dashboardBtn.Image = global::HotelReservationSystem3.Properties.Resources.icons8_home_50;
            this.dashboardBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.dashboardBtn.Location = new System.Drawing.Point(-3, 125);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(200, 82);
            this.dashboardBtn.TabIndex = 1;
            this.dashboardBtn.Text = "DashBoard";
            this.dashboardBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.dashboardBtn.UseVisualStyleBackColor = false;
            this.dashboardBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::HotelReservationSystem3.Properties.Resources.Hotel;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.panel_cover);
            this.panel_main.Location = new System.Drawing.Point(217, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(940, 700);
            this.panel_main.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1165, 694);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.panel_cover.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_cover;
        private System.Windows.Forms.Button dashboardBtn;
        private System.Windows.Forms.Button roomsBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_slide;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Panel panel_main;
    }
}
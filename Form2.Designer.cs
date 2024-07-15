namespace ISDS_454_Final_Project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuLbl = new System.Windows.Forms.Label();
            this.reservationBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.reservationMsgLbl = new System.Windows.Forms.Label();
            this.toolTipLbl = new System.Windows.Forms.Label();
            this.roomNumTipLbl = new System.Windows.Forms.Label();
            this.testStartLbl = new System.Windows.Forms.Label();
            this.testEndLbl = new System.Windows.Forms.Label();
            this.roomNumbersCB = new System.Windows.Forms.ComboBox();
            this.roomNumLbl = new System.Windows.Forms.Label();
            this.roomLbl = new System.Windows.Forms.Label();
            this.testEpochStartLbl = new System.Windows.Forms.Label();
            this.testEpochEndLbl = new System.Windows.Forms.Label();
            this.testStartDateLbl = new System.Windows.Forms.Label();
            this.testEndDateLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameResMsgLbl = new System.Windows.Forms.Label();
            this.firstNameMsgLbl = new System.Windows.Forms.Label();
            this.firstNameTxtBox = new System.Windows.Forms.TextBox();
            this.lastNameMsgLbl = new System.Windows.Forms.Label();
            this.lastNameTxtBox = new System.Windows.Forms.TextBox();
            this.testBookingIDLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.hotelNameLbl = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(290, 48);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(237, 31);
            this.menuLbl.TabIndex = 0;
            this.menuLbl.Text = "New Reservation";
            // 
            // reservationBtn
            // 
            this.reservationBtn.Location = new System.Drawing.Point(75, 334);
            this.reservationBtn.Name = "reservationBtn";
            this.reservationBtn.Size = new System.Drawing.Size(132, 47);
            this.reservationBtn.TabIndex = 1;
            this.reservationBtn.Text = "Make Reservation";
            this.reservationBtn.UseVisualStyleBackColor = true;
            this.reservationBtn.Click += new System.EventHandler(this.reservationBtn_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(34, 147);
            this.monthCalendar1.MaxDate = new System.DateTime(2200, 12, 31, 0, 0, 0, 0);
            this.monthCalendar1.MaxSelectionCount = 14;
            this.monthCalendar1.MinDate = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // reservationMsgLbl
            // 
            this.reservationMsgLbl.AutoSize = true;
            this.reservationMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservationMsgLbl.Location = new System.Drawing.Point(54, 125);
            this.reservationMsgLbl.Name = "reservationMsgLbl";
            this.reservationMsgLbl.Size = new System.Drawing.Size(190, 13);
            this.reservationMsgLbl.TabIndex = 3;
            this.reservationMsgLbl.Text = "Please Select Your Desired Visit";
            // 
            // toolTipLbl
            // 
            this.toolTipLbl.AutoSize = true;
            this.toolTipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolTipLbl.Location = new System.Drawing.Point(59, 308);
            this.toolTipLbl.Name = "toolTipLbl";
            this.toolTipLbl.Size = new System.Drawing.Size(175, 13);
            this.toolTipLbl.TabIndex = 4;
            this.toolTipLbl.Text = "(Click and drag to your desired date)";
            // 
            // roomNumTipLbl
            // 
            this.roomNumTipLbl.AutoSize = true;
            this.roomNumTipLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomNumTipLbl.Location = new System.Drawing.Point(307, 124);
            this.roomNumTipLbl.Name = "roomNumTipLbl";
            this.roomNumTipLbl.Size = new System.Drawing.Size(198, 13);
            this.roomNumTipLbl.TabIndex = 5;
            this.roomNumTipLbl.Text = "Please Select Your Desired Room";
            // 
            // testStartLbl
            // 
            this.testStartLbl.AutoSize = true;
            this.testStartLbl.Location = new System.Drawing.Point(357, 282);
            this.testStartLbl.Name = "testStartLbl";
            this.testStartLbl.Size = new System.Drawing.Size(55, 13);
            this.testStartLbl.TabIndex = 7;
            this.testStartLbl.Text = "Start Date";
            // 
            // testEndLbl
            // 
            this.testEndLbl.AutoSize = true;
            this.testEndLbl.Location = new System.Drawing.Point(357, 320);
            this.testEndLbl.Name = "testEndLbl";
            this.testEndLbl.Size = new System.Drawing.Size(52, 13);
            this.testEndLbl.TabIndex = 8;
            this.testEndLbl.Text = "End Date";
            // 
            // roomNumbersCB
            // 
            this.roomNumbersCB.FormattingEnabled = true;
            this.roomNumbersCB.Location = new System.Drawing.Point(348, 147);
            this.roomNumbersCB.Name = "roomNumbersCB";
            this.roomNumbersCB.Size = new System.Drawing.Size(121, 21);
            this.roomNumbersCB.TabIndex = 9;
            this.roomNumbersCB.SelectedIndexChanged += new System.EventHandler(this.roomNumbersCB_SelectedIndexChanged);
            // 
            // roomNumLbl
            // 
            this.roomNumLbl.AutoSize = true;
            this.roomNumLbl.Location = new System.Drawing.Point(545, 282);
            this.roomNumLbl.Name = "roomNumLbl";
            this.roomNumLbl.Size = new System.Drawing.Size(14, 13);
            this.roomNumLbl.TabIndex = 10;
            this.roomNumLbl.Text = "#";
            // 
            // roomLbl
            // 
            this.roomLbl.AutoSize = true;
            this.roomLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLbl.Location = new System.Drawing.Point(484, 282);
            this.roomLbl.Name = "roomLbl";
            this.roomLbl.Size = new System.Drawing.Size(55, 13);
            this.roomLbl.TabIndex = 11;
            this.roomLbl.Text = "Room #:";
            // 
            // testEpochStartLbl
            // 
            this.testEpochStartLbl.AutoSize = true;
            this.testEpochStartLbl.Location = new System.Drawing.Point(555, 386);
            this.testEpochStartLbl.Name = "testEpochStartLbl";
            this.testEpochStartLbl.Size = new System.Drawing.Size(35, 13);
            this.testEpochStartLbl.TabIndex = 12;
            this.testEpochStartLbl.Text = "label1";
            this.testEpochStartLbl.Visible = false;
            // 
            // testEpochEndLbl
            // 
            this.testEpochEndLbl.AutoSize = true;
            this.testEpochEndLbl.Location = new System.Drawing.Point(552, 434);
            this.testEpochEndLbl.Name = "testEpochEndLbl";
            this.testEpochEndLbl.Size = new System.Drawing.Size(35, 13);
            this.testEpochEndLbl.TabIndex = 13;
            this.testEpochEndLbl.Text = "label2";
            this.testEpochEndLbl.Visible = false;
            // 
            // testStartDateLbl
            // 
            this.testStartDateLbl.AutoSize = true;
            this.testStartDateLbl.Location = new System.Drawing.Point(710, 386);
            this.testStartDateLbl.Name = "testStartDateLbl";
            this.testStartDateLbl.Size = new System.Drawing.Size(35, 13);
            this.testStartDateLbl.TabIndex = 14;
            this.testStartDateLbl.Text = "label1";
            this.testStartDateLbl.Visible = false;
            // 
            // testEndDateLbl
            // 
            this.testEndDateLbl.AutoSize = true;
            this.testEndDateLbl.Location = new System.Drawing.Point(710, 434);
            this.testEndDateLbl.Name = "testEndDateLbl";
            this.testEndDateLbl.Size = new System.Drawing.Size(35, 13);
            this.testEndDateLbl.TabIndex = 15;
            this.testEndDateLbl.Text = "label2";
            this.testEndDateLbl.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(521, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Start Date in Epoch";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(521, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "End Date in Epoch";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(677, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Epoch to Start Date";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(680, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Epoch to End Date";
            this.label4.Visible = false;
            // 
            // nameResMsgLbl
            // 
            this.nameResMsgLbl.AutoSize = true;
            this.nameResMsgLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameResMsgLbl.Location = new System.Drawing.Point(549, 124);
            this.nameResMsgLbl.Name = "nameResMsgLbl";
            this.nameResMsgLbl.Size = new System.Drawing.Size(239, 13);
            this.nameResMsgLbl.TabIndex = 20;
            this.nameResMsgLbl.Text = "Please Enter a Name for the Reservation";
            // 
            // firstNameMsgLbl
            // 
            this.firstNameMsgLbl.AutoSize = true;
            this.firstNameMsgLbl.Location = new System.Drawing.Point(549, 150);
            this.firstNameMsgLbl.Name = "firstNameMsgLbl";
            this.firstNameMsgLbl.Size = new System.Drawing.Size(60, 13);
            this.firstNameMsgLbl.TabIndex = 21;
            this.firstNameMsgLbl.Text = "First Name:";
            // 
            // firstNameTxtBox
            // 
            this.firstNameTxtBox.Location = new System.Drawing.Point(616, 147);
            this.firstNameTxtBox.Name = "firstNameTxtBox";
            this.firstNameTxtBox.Size = new System.Drawing.Size(154, 20);
            this.firstNameTxtBox.TabIndex = 22;
            // 
            // lastNameMsgLbl
            // 
            this.lastNameMsgLbl.AutoSize = true;
            this.lastNameMsgLbl.Location = new System.Drawing.Point(548, 189);
            this.lastNameMsgLbl.Name = "lastNameMsgLbl";
            this.lastNameMsgLbl.Size = new System.Drawing.Size(61, 13);
            this.lastNameMsgLbl.TabIndex = 23;
            this.lastNameMsgLbl.Text = "Last Name:";
            // 
            // lastNameTxtBox
            // 
            this.lastNameTxtBox.Location = new System.Drawing.Point(616, 186);
            this.lastNameTxtBox.Name = "lastNameTxtBox";
            this.lastNameTxtBox.Size = new System.Drawing.Size(154, 20);
            this.lastNameTxtBox.TabIndex = 24;
            // 
            // testBookingIDLbl
            // 
            this.testBookingIDLbl.AutoSize = true;
            this.testBookingIDLbl.Location = new System.Drawing.Point(102, 403);
            this.testBookingIDLbl.Name = "testBookingIDLbl";
            this.testBookingIDLbl.Size = new System.Drawing.Size(63, 13);
            this.testBookingIDLbl.TabIndex = 25;
            this.testBookingIDLbl.Text = "Booking_ID";
            this.testBookingIDLbl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(76)))), ((int)(((byte)(49)))));
            this.panel1.Controls.Add(this.minimizeBtn);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.hotelNameLbl);
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 32);
            this.panel1.TabIndex = 26;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(12, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 26);
            this.panel4.TabIndex = 10;
            // 
            // hotelNameLbl
            // 
            this.hotelNameLbl.AutoSize = true;
            this.hotelNameLbl.ForeColor = System.Drawing.Color.White;
            this.hotelNameLbl.Location = new System.Drawing.Point(48, 9);
            this.hotelNameLbl.Name = "hotelNameLbl";
            this.hotelNameLbl.Size = new System.Drawing.Size(96, 13);
            this.hotelNameLbl.TabIndex = 2;
            this.hotelNameLbl.Text = "Royal Luxury Hotel";
            // 
            // exitBtn
            // 
            this.exitBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exitBtn.BackgroundImage")));
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Location = new System.Drawing.Point(773, 3);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(24, 24);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(6, 38);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(33, 22);
            this.backBtn.TabIndex = 27;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Reservation Check Out";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Check In:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(285, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Check Out:";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBtn.BackgroundImage")));
            this.minimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Location = new System.Drawing.Point(735, 4);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 24);
            this.minimizeBtn.TabIndex = 12;
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.testBookingIDLbl);
            this.Controls.Add(this.lastNameTxtBox);
            this.Controls.Add(this.lastNameMsgLbl);
            this.Controls.Add(this.firstNameTxtBox);
            this.Controls.Add(this.firstNameMsgLbl);
            this.Controls.Add(this.nameResMsgLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.testEndDateLbl);
            this.Controls.Add(this.testStartDateLbl);
            this.Controls.Add(this.testEpochEndLbl);
            this.Controls.Add(this.testEpochStartLbl);
            this.Controls.Add(this.roomLbl);
            this.Controls.Add(this.roomNumLbl);
            this.Controls.Add(this.roomNumbersCB);
            this.Controls.Add(this.testEndLbl);
            this.Controls.Add(this.testStartLbl);
            this.Controls.Add(this.roomNumTipLbl);
            this.Controls.Add(this.toolTipLbl);
            this.Controls.Add(this.reservationMsgLbl);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.reservationBtn);
            this.Controls.Add(this.menuLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Royal Luxury Hotel";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.Button reservationBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label reservationMsgLbl;
        private System.Windows.Forms.Label toolTipLbl;
        private System.Windows.Forms.Label roomNumTipLbl;
        private System.Windows.Forms.Label testStartLbl;
        private System.Windows.Forms.Label testEndLbl;
        private System.Windows.Forms.ComboBox roomNumbersCB;
        private System.Windows.Forms.Label roomNumLbl;
        private System.Windows.Forms.Label roomLbl;
        private System.Windows.Forms.Label testEpochStartLbl;
        private System.Windows.Forms.Label testEpochEndLbl;
        private System.Windows.Forms.Label testStartDateLbl;
        private System.Windows.Forms.Label testEndDateLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label nameResMsgLbl;
        private System.Windows.Forms.Label firstNameMsgLbl;
        private System.Windows.Forms.TextBox firstNameTxtBox;
        private System.Windows.Forms.Label lastNameMsgLbl;
        private System.Windows.Forms.TextBox lastNameTxtBox;
        private System.Windows.Forms.Label testBookingIDLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label hotelNameLbl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button minimizeBtn;
    }
}
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

namespace ISDS_454_Final_Project
{
    public partial class Form2 : Form
    {
        // - VARS -
        bool mouseDown;
        const int START_DATE_ADD_SECONDS = 54000;
        const int END_DATE_ADD_SECONDS = -43199;
        const long EPOCH_DIV = 10000000;
        int[] roomNumbers = { 100, 101, 102, 103, 104, 105, 200, 201, 202, 203, 204, 205 };
        int selectedRoomNum;

        DateTime startDate = new DateTime();
        DateTime endDate = new DateTime();

        long startDateinEpoch;
        long endDateinEpoch;

        static string constr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=hotel;Data Source=desktop-19jhtlb\sqlexpress01";
        static SqlConnection con = new SqlConnection(constr);
        int reservationID;

        // - FORM 2 INITIALIZATION -
        public Form2()
        {
            InitializeComponent();
        }

        // - CALANDER DATE CHANGE -
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // - Getting Calender Selection & Setting to DateTime's -
            startDate = monthCalendar1.SelectionStart;
            endDate = monthCalendar1.SelectionEnd;

            // - Adding DateTime Values & Passing to DateTime Labels -
            testStartLbl.Text = startDate.AddSeconds(START_DATE_ADD_SECONDS).ToString();
            testEndLbl.Text = endDate.AddSeconds(END_DATE_ADD_SECONDS).ToString();

            // - Converting Calender Selection to Epoch -
            startDateinEpoch = ((startDate.Ticks - new DateTime(1970, 1, 1, 0, 0, 0, 0).Ticks) + START_DATE_ADD_SECONDS) / EPOCH_DIV;
            endDateinEpoch = ((endDate.Ticks - new DateTime(1970, 1, 1, 0, 0, 0, 0).Ticks) + END_DATE_ADD_SECONDS) / EPOCH_DIV;


            // - Passing Epoch Vars into Epoch Labels -
            testEpochStartLbl.Text = Convert.ToString(startDateinEpoch + START_DATE_ADD_SECONDS);
            testEpochEndLbl.Text = Convert.ToString((endDateinEpoch + END_DATE_ADD_SECONDS) + 1);




            // - Converting Epoch back to DateTime
            DateTime startDateFromEpoch = new DateTime((startDateinEpoch + START_DATE_ADD_SECONDS) * EPOCH_DIV);
            DateTime endDateFromEpoch = new DateTime((endDateinEpoch + END_DATE_ADD_SECONDS) * EPOCH_DIV);
            
            testStartDateLbl.Text = startDateFromEpoch.ToString();
            testEndDateLbl.Text = endDateFromEpoch.ToString();

        } // - PUSH startDate & endDate in EPOCH form to DB on button click -

        // - POPULATE COMBOBOX -
        private void Form2_Load(object sender, EventArgs e)
        {
            roomNumbersCB.Items.Clear();
            for (int i = 0; i < roomNumbers.Length; i++)
            {
                roomNumbersCB.Items.Add(roomNumbers[i]);
            }
        }

        // - SELECT COMBO BOX INDEX -
        private void roomNumbersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedRoomNum = roomNumbersCB.SelectedIndex;
            roomNumLbl.Text = roomNumbersCB.Text;
        } // - PUSH selectedRoomNum to DB on button click -

        private void reservationBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            // - Checking the last ID -
            string query = "SELECT MAX(Booking_ID) FROM bookings";
            SqlCommand cmd_r = new SqlCommand(query, con);
            SqlDataReader sdr = cmd_r.ExecuteReader();

            if (sdr.HasRows)
            {
                sdr.Read();
                reservationID = sdr.GetInt32(0);
            }
            else
            {
                MessageBox.Show("Error Reading", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            testBookingIDLbl.Text = reservationID.ToString();

            
            // - Writing info to DB -
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT into bookings VALUES (@Booking_ID, @LastName, @FirstName, @Booking_ArrivalDate, @Booking_DepartureDate, @Room_Number)", con);
            cmd.Parameters.AddWithValue("@Booking_ID", reservationID + 1);
            cmd.Parameters.AddWithValue("@LastName", lastNameTxtBox.Text);
            cmd.Parameters.AddWithValue("@FirstName", firstNameTxtBox.Text);
            cmd.Parameters.AddWithValue("@Booking_ArrivalDate", startDateinEpoch + START_DATE_ADD_SECONDS);
            cmd.Parameters.AddWithValue("@Booking_DepartureDate", endDateinEpoch + END_DATE_ADD_SECONDS + 1);
            cmd.Parameters.AddWithValue("@Room_Number", int.Parse(roomNumLbl.Text));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            con.Close();
        }

        // - EXIT BUTTON -
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // - TO HANDLE CUSTOM MOVING FORM BAR -
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // - BACK BUTTON -
        private void backBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}

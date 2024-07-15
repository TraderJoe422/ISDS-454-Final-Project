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
    public partial class ViewRes : Form
    {
        bool mouseDown;
        int[] roomNumbers = { 100, 101, 102, 103, 104, 105, 200, 201, 202, 203, 204, 205 };
        int selectedRoomNum;

        long recordStartDate;
        long recordEndDate;

        long startDateInEpoch;
        long endDateInEpoch;
        const int START_DATE_ADD_SECONDS = 54000;
        const int END_DATE_ADD_SECONDS = -43199;

        static string constr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=hotel;Data Source=desktop-19jhtlb\sqlexpress01";
        static SqlConnection con = new SqlConnection(constr);

        public ViewRes()
        {
            InitializeComponent();
        }

        // - POPULATE COMBOBOX -
        private void ViewRes_Load(object sender, EventArgs e)
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
        }


        private void searchRecordBtn_Click(object sender, EventArgs e)
        {
            if (firstNameTxtBox.Text == "" || lastNameTxtBox.Text == "" || roomNumLbl.Text == "#")
            {
                MessageBox.Show("You Must Enter Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                // - SEARCHING THE DB FOR CORRECT RECORD -
                string querySearch = "SELECT * FROM bookings WHERE LastName = '" + lastNameTxtBox.Text + "'" + " AND FirstName = '" + firstNameTxtBox.Text + "'" + " AND Room_Number = " + int.Parse(roomNumLbl.Text);

                SqlCommand cmd_r = new SqlCommand(querySearch, con);
                SqlDataReader sdr = cmd_r.ExecuteReader();

                while (sdr.Read())
                {
                    recordOne.Text = sdr.GetValue(0).ToString();
                    recordTwo.Text = sdr.GetValue(1).ToString();
                    recordThree.Text = sdr.GetValue(2).ToString();

                    recordStartDate = (long)sdr.GetValue(3);
                    recordEndDate = (long)sdr.GetValue(4);
                    DateTimeOffset startDateFromEpoch = DateTimeOffset.FromUnixTimeSeconds(recordStartDate);
                    DateTimeOffset endDateFromEpoch = DateTimeOffset.FromUnixTimeSeconds(recordEndDate);
                    recordFour.Text = startDateFromEpoch.ToString().Remove(20);
                    recordFive.Text = endDateFromEpoch.ToString().Remove(21);
                    //recordFour.Text = sdr.GetValue(3).ToString();
                    //recordFive.Text = sdr.GetValue(4).ToString();
                    recordSix.Text = sdr.GetValue(5).ToString();
                }

                // - DISPLAYING RECORDS -
                if (recordOne.Text == "")
                {
                    MessageBox.Show("Error Searching Records", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    recordOne.Show();
                    recordTwo.Show();
                    recordThree.Show();
                    recordFour.Show();
                    recordFive.Show();
                    recordSix.Show();
                    MessageBox.Show("Record Found", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                con.Close();
            }
        
        }

        // - EXIT BUTTON -
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // - BACK BUTTON -
        private void backBtn_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
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

        // - MINIMIZE BUTTON -
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // - CLEAR BUTTON -
        private void clearBtn_Click(object sender, EventArgs e)
        {
            firstNameTxtBox.Clear();
            lastNameTxtBox.Clear();
            recordOne.Hide();
            recordTwo.Hide();
            recordThree.Hide();
            recordFour.Hide();
            recordFive.Hide();
            recordSix.Hide();

            recordOne.Text = "";
            recordTwo.Text = "";
            recordThree.Text = "";
            recordFour.Text = "";
            recordFive.Text = "";
            recordSix.Text = "";
        }
    }
}

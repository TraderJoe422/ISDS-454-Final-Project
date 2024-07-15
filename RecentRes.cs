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
    public partial class RecentRes : Form
    {

        static string constr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=hotel;Data Source=desktop-19jhtlb\sqlexpress01";
        bool mouseDown;

        public RecentRes()
        {
            InitializeComponent();
        }

        // - POPULATING DATAGRID -
        private void RecentRes_Load(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM bookings ORDER BY Booking_ID DESC", con);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);

                dataGridView1.DataSource = dt;
            }

        }

        // - EXIT BUTTON -
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // - MINIMIZE BUTTON -
        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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
    }
}

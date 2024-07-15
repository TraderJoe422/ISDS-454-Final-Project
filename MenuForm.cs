using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISDS_454_Final_Project
{
    public partial class MenuForm : Form
    {

        bool mouseDown;

        public MenuForm()
        {
            InitializeComponent();
        }

        // - USER CLICKS NEW RESERVATION -
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        
        // - USER CLICKS CANCEL RESERVATION -
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            CancelRes cancelRes = new CancelRes();
            cancelRes.Show();
            this.Hide();
        }


        // - TO HANDLE CUSTOM MOVING FORM BAR -
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                int mousex = MousePosition.X - 400;
                int mousey = MousePosition.Y - 20;
                this.SetDesktopLocation(mousex, mousey);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        // - EXIT BUTTON -
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // - USER CLICKS VIEW RESERVATION -
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ViewRes viewRes = new ViewRes();
            viewRes.Show();
            this.Hide();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // - USER CLICKS RECENT RESERVATIONS -
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            RecentRes recentRes = new RecentRes();
            recentRes.Show();
            this.Hide();
        }
    }
}

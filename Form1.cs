using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ISDS_454_Final_Project
{
    public partial class Form1 : Form
    {
        bool mouseDown;

        public Form1()
        {
            InitializeComponent();

        }

        static string constr = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=hotel;Data Source=desktop-19jhtlb\sqlexpress01";
        static SqlConnection con = new SqlConnection(constr);
        //SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-19JHTLB\SQLEXPRESS01;Initial Catalog=hotel;Integrated Security=True;Pooling=False");

        private void logBtn_Click(object sender, EventArgs e)
        {

            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string query = "SELECT username, password FROM login WHERE username = '" + userTxtBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();

                if (sdr.HasRows)
                {
                    sdr.Read();

                    if (sdr["password"].Equals(passTxtBox.Text))
                    {
                        MessageBox.Show("Login Successful..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MenuForm menuForm = new MenuForm();
                        menuForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Username is incorrect..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch
            {
                con.Close();
                MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // - BUTTON TO CLOSE FORM -
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
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

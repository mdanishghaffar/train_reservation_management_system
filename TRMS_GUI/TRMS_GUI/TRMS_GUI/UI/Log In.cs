using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRMS.BL;
using TRMS.DL;
using TRMS_GUI.UI;

namespace TRMS_GUI
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
            UserDL.loadUser();
            TrainDL.loadTrain();
            TicketDL.loadCancelledTickets();
            TicketDL.loadTickets();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdLogIn_Click(object sender, EventArgs e)
        {
            UserDL.addAdmin();
            string username = Username.Text;
            string password = Password.Text;
            string role = UserDL.isValidUser(username, password);
            if (role == "Admin")
            {
                Admin_Menu admin_Menu = new Admin_Menu();
                this.Hide();
                admin_Menu.Show();
            }
            else if (role == "Employee")
            {
                Employee_Menu employee_Menu = new Employee_Menu();
                this.Hide();
                employee_Menu.Show();
            }
            else {
                MessageBox.Show("ERROR");
            }
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }
    }
}

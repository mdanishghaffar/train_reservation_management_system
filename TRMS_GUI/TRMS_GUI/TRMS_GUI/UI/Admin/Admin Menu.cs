using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRMS_GUI.UI;
using TRMS.BL;
using TRMS.DL;
using TRMS_GUI.UI.Admin;

namespace TRMS_GUI.UI
{
    public partial class Admin_Menu : Form
    {
        public Admin_Menu()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Employee delete_Employee = new Delete_Employee();
            delete_Employee.Show();
            
        }

        private void viewBookedTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Booked_Tickets view_Booked_Tickets = new View_Booked_Tickets(); 
            view_Booked_Tickets.Show();
        }

        private void addTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Train add_Train = new Add_Train();
            add_Train.Show();
        }

        private void deleteEmployeeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Trains t = new Delete_Trains();
            t.Show();
        }

        private void cmdLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully Logged Out!");
            Log_In logIn = new Log_In();
            logIn.Show();
        }

        private void cancelledTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancelled_Tickets cancelled = new Cancelled_Tickets();
            cancelled.Show();
        }

        private void addTrainToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Menu_Load(object sender, EventArgs e)
        {

        }

        private void earningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Earnings earnings = new Earnings();
            this.Hide();
            earnings.Show();
        }
    }
}

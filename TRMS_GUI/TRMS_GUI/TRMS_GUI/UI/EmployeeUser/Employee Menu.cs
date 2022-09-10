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
using TRMS_GUI.Properties;
using TRMS_GUI.UI.EmployeeUser;

namespace TRMS_GUI
{
    public partial class Employee_Menu : Form
    {
        public Employee_Menu()
        {
            InitializeComponent();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Book_Ticket book_Ticket = new Book_Ticket();
            book_Ticket.Show();
        }
        private void cancelTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete_Tickets delete_Tickets = new Delete_Tickets();
            this.Hide();
            delete_Tickets.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            TicketDL.emergency();
            MessageBox.Show("All tickets have been cancelled and trains are cancelled!");
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Log_In logIn = new Log_In();
            this.Hide();
            MessageBox.Show("Successfully Logged Out!");
            logIn.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            View_Available_Seats view_Available_Seats = new View_Available_Seats();
            this.Hide();
            view_Available_Seats.Show();
        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}

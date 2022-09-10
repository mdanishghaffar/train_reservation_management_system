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
using TRMS_GUI.UI.Admin;

namespace TRMS_GUI.UI
{
    public partial class Cancelled_Tickets : Form
    {
        public Cancelled_Tickets()
        {
            InitializeComponent();
        }

        private void Cancelled_Tickets_Load(object sender, EventArgs e)
        {
            dataGridCancelled.DataSource = TicketDL.getCancelledTicketsList();
        }

        private void dataGridCancelled_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Employee add_Employee = new Add_Employee();
            add_Employee.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Employee delete_Employee = new Delete_Employee();
            delete_Employee.Show();
        }

        private void addTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Train add_Train = new Add_Train();
            add_Train.Show();
        }

        private void deleteTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Delete_Trains t = new Delete_Trains();
            t.Show();
        }

        private void viewBookedTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Booked_Tickets view_Booked_Tickets = new View_Booked_Tickets();
            view_Booked_Tickets.Show();
        }

        private void cancelledTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cancelled_Tickets cancelled = new Cancelled_Tickets();
            cancelled.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Successfully Logged Out!");
            Log_In logIn = new Log_In();
            logIn.Show();
        }
    }
}

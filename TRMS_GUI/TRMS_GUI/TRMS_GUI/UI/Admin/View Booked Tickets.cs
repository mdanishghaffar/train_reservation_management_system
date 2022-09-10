using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRMS.DL;
using TRMS.BL;
using TRMS_GUI.UI.Admin;

namespace TRMS_GUI.UI
{
    public partial class View_Booked_Tickets : Form
    {
        public View_Booked_Tickets()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void DataBind()
        {
            
            dgBookedTickets.Refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketBL ticket = (TicketBL)dgBookedTickets.CurrentRow.DataBoundItem;
            if (dgBookedTickets.Columns[0].Index == e.ColumnIndex)
            {
                dgBookedTickets.DataSource = null;
                TicketDL.deleteTicket(ticket.Name);
                dgBookedTickets.DataSource = TicketDL.getTicketsList();
                
                TicketDL.storeTickets();
            }
            DataBind();
            //TicketDL.store();
           

        }

        private void View_Booked_Tickets_Load(object sender, EventArgs e)
        {
            dgBookedTickets.DataSource = TicketDL.getTicketsList();
        }

        private void viewBookedTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            View_Booked_Tickets view_Booked_Tickets = new View_Booked_Tickets();
            view_Booked_Tickets.Show();
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

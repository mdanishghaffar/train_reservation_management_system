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

namespace TRMS_GUI.UI.EmployeeUser
{
    public partial class Delete_Tickets : Form
    {
        public Delete_Tickets()
        {
            InitializeComponent();
        }

        private void DataBind()
        {
            dgTickets.DataSource = null;
            dgTickets.DataSource = TicketDL.getTicketsList();
            dgTickets.Refresh();
        }
        private void dgDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TicketBL ticket = (TicketBL)dgTickets.CurrentRow.DataBoundItem;
            if (dgTickets.Columns[0].Index == e.ColumnIndex)
            {
                dgTickets.DataSource = null;
                TicketDL.deleteTicket(ticket.Name);
                dgTickets.DataSource = TicketDL.getTicketsList();
                TicketDL.storeTickets();
            }
            DataBind();
        }

        private void Tickets_Load(object sender, EventArgs e)
        {
            dgTickets.DataSource = TicketDL.getTicketsList();
        }

        private void cmdBookTicket_Click(object sender, EventArgs e)
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

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            View_Available_Seats view_Available_Seats = new View_Available_Seats();
            this.Hide();
            view_Available_Seats.Show();
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
    }
}

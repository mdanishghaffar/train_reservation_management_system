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
using TRMS_GUI.UI.EmployeeUser;

namespace TRMS_GUI.UI
{
    public partial class View_Available_Seats : Form
    {
        public View_Available_Seats()
        {
            InitializeComponent();
        }

        private void View_Available_Seats_Load(object sender, EventArgs e)
        {
            MessageBox.Show(TrainDL.getTrainList()[0].PriceMed.ToString()); // sirf test karn ka liya
            dataGridASeats.DataSource = TrainDL.getTrainList();
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

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
    public partial class Book_Ticket : Form
    {
        public Book_Ticket()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Book_Ticket_Load(object sender, EventArgs e)
        {
            lbTrainFrom.DataSource = TrainDL.getTrainList();
            lbTrainFrom.DisplayMember = "StartingPos";
        }

        private void lbTrainFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Train> trainsList = new List<Train>();
            foreach(Train t in TrainDL.getTrainList()) {
            if(t.StartingPos == lbTrainFrom.Text)
                {
                    trainsList.Add(t);
                    TrainDL.storeTrain();
                }
            }
            lbTrainTo.DataSource = trainsList;
            lbTrainTo.DisplayMember = "EndingPos";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string train_from = lbTrainFrom.Text;
            string train_to = lbTrainTo.Text;
            string lux = lbClass.Text;
            string name = txtName.Text;
            uint age = (uint)nuAge.Value;
            string gender = lbGender.Text;

            Train t = (Train)lbTrainTo.SelectedItem;

            if(lux == "Economy")
            {
                t.CapEco = t.CapEco - 1;
                Economy economy = new Economy(train_from,train_to,lux,name,age,gender,1);
                TicketDL.addTicketIntoList(economy);
                MessageBox.Show("Ticket Booked Succesfully!");
                TicketDL.calculateTotal(t.PriceEco);
                //TicketDL.storeTickets();

            }
            else if(lux == "Medium")
            {
                t.CapMed = t.CapMed - 1;
                Medium medium = new Medium(train_from, train_to, lux, name, age, gender,2);
                TicketDL.addTicketIntoList(medium);
                MessageBox.Show("Ticket Booked Succesfully!");
                TicketDL.calculateTotal(t.PriceMed);
             //   TicketDL.storeTickets();
            }
            else if(lux == "Business")
            {
                t.CapBus = t.CapBus - 1;
                Business business = new Business(train_from, train_to, lux, name, age, gender, 3,true,"Biryani",true,true);
                TicketDL.addTicketIntoList(business);
                MessageBox.Show("Ticket Booked Succesfully!");
                TicketDL.calculateTotal(t.PriceBus);
               // TicketDL.storeTickets();
            }
            TicketDL.storeTickets();

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

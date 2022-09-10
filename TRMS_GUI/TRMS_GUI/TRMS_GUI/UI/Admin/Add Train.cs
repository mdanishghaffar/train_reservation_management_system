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
    public partial class Add_Train : Form
    {
        public Add_Train()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string train_name = t_name.Text;
            string train_start = t_start.Text;
            string train_end = t_end.Text;
            int capEco = (int)t_ecoCap.Value;
            int capMed = (int)t_medCap.Value;
            int capBus = (int)t_busCap.Value;
            int priceEco = (int)t_ecoPrice.Value;
            int priceMed = (int)t_medPrice.Value;
            int priceBus = (int)t_busPrice.Value;

            Train newTrain = new Train(train_name, train_start, train_end, capEco, capMed, capBus, priceEco, priceMed, priceBus);
            TrainDL.addTrainIntoList(newTrain);
            MessageBox.Show("Train has been succcessfully added!");
            TrainDL.storeTrain();
            Admin_Menu admin_Menu = new Admin_Menu();
            this.Hide();
            admin_Menu.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
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

        private void Add_Train_Load(object sender, EventArgs e)
        {

        }
    }
}

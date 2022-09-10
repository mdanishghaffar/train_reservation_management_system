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
    public partial class Delete_Trains : Form
    {
        public Delete_Trains()
        {
            InitializeComponent();
        }

        private void Trains_Load(object sender, EventArgs e)
        {
            dgTrains.DataSource = TrainDL.getTrainList();
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
        private void DataBind()
        {
            
            
        }
        private void dgTrains_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Train t = (Train)dgTrains.CurrentRow.DataBoundItem;
            if (dgTrains.Columns[0].Index == e.ColumnIndex)
            {
                dgTrains.DataSource = null;
                TrainDL.getTrainList().Remove(t);
                dgTrains.DataSource = TrainDL.getTrainList();
            }
            if (dgTrains.Columns[1].Index == e.ColumnIndex)
            {
                dgTrains.DataSource = null;
                new Edit_Train(t).ShowDialog();
                TrainDL.getTrainList().Remove(t);
                dgTrains.DataSource = TrainDL.getTrainList();
            }
            TrainDL.storeTrain();
            MessageBox.Show("Success!");
        }
    }
}

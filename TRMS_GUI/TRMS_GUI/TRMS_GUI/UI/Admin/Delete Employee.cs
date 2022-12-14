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

namespace TRMS_GUI.UI.Admin
{
    public partial class Delete_Employee : Form
    {
        public Delete_Employee()
        {
            InitializeComponent();
            UserDL.loadUser();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            MessageBox.Show(UserDL.getUsersList().Count.ToString());
            dgDelEmployee.DataSource = UserDL.getUsersList();
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
            dgDelEmployee.DataSource = null;
            dgDelEmployee.DataSource = UserDL.getUsersList();
            dgDelEmployee.Refresh();
        }

        private void dgDelEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            User user = (User)dgDelEmployee.CurrentRow.DataBoundItem;
            if (dgDelEmployee.Columns[e.ColumnIndex].Name=="Delete")
            {
                dgDelEmployee.DataSource = null;
                UserDL.deleteUser(user);
                
                dgDelEmployee.DataSource = UserDL.getUsersList();
            }
            UserDL.storeUser();
            //DataBind();
            MessageBox.Show("Employee Deleted Succesfully");
        }
    }
}

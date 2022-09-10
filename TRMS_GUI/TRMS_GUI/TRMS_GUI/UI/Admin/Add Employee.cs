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
    public partial class Add_Employee : Form
    {
        public Add_Employee()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = EmpUsername.Text;
            string gmail = empMail.Text;
            string phoneNo = empNo.Text;
            string address = empAddress.Text;
            string city = empCity.Text;
            string category = empCat.Text;
            string password = empPassword.Text;
            bool emailValid = UserDL.isValidEMAIL(gmail);
            if (emailValid)
            {
                Employee newEmployee = new Employee(username, password, category, gmail, phoneNo, address, city);
                UserDL.addNewUser(newEmployee);
                MessageBox.Show("Employee has been successfully added!");
              //  Employee_Menu employee_Menu = new Employee_Menu();
                UserDL.storeUser();
                //this.Hide();
                //employee_Menu.Show();
            }
            else {
                MessageBox.Show("Enter information in correct format");
            }
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

        private void empMail_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}

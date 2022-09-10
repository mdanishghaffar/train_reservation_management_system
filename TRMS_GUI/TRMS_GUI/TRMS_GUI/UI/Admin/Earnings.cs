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
    public partial class Earnings : Form
    {
        public Earnings()
        {
            InitializeComponent();
        }

        private void Earnings_Load(object sender, EventArgs e)
        {
            dvEarnings.DataSource = TicketDL.getTicketsList();
            lbTotal.Text = (TicketDL.getTotal()).ToString();
        }
        private void DataBind()
        {
            dvEarnings.DataSource = null;
            dvEarnings.DataSource = TicketDL.getTicketsList(); 
            dvEarnings.Refresh();
        }
    }
}

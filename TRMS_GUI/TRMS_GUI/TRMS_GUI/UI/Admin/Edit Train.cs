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

namespace TRMS_GUI.UI.Admin
{
    partial class Edit_Train : Form
    {
        Train t;
        public Edit_Train(Train t)
        {
            this.t = t;
            InitializeComponent();
        }

        private void Edit_Train_Load(object sender, EventArgs e)
        {
            t_nameEdit.Text = t.Train_name;
            t_startEdit.Text = t.StartingPos;
            t_endEdit.Text = t.EndingPos;
            t_ecoCapEdit.Value = t.CapEco;
            t_medCapEdit.Value = t.CapMed;
            t_busCapEdit.Value = t.CapBus;
            t_ecoPriceEdit.Value = t.PriceEco;
            t_medPriceEdit.Value = t.PriceMed;
            t_busPriceEdit.Value = t.PriceBus;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Train updated = new Train(t_nameEdit.Text, t_startEdit.Text, t_endEdit.Text, (int)t_ecoCapEdit.Value, (int)t_medCapEdit.Value, (int)t_busCapEdit.Value, (int)t_ecoPriceEdit.Value, (int)t_medPriceEdit.Value, (int)t_busPriceEdit.Value);
            TrainDL.addTrainIntoList(updated);
            this.Close();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TRMS.DL;

namespace TRMS_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TicketDL.loadTickets();
            TicketDL.loadCancelledTickets();
            TrainDL.loadTrain();
            UserDL.loadUser();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Log_In());
        }
    }
}

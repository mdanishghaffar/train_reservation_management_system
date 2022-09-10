using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMS.BL;
using System.IO;
    
namespace TRMS.DL
{
    class TicketDL
    {
        static int total=0;
        static int ecoTotal = 0;
        static int medTotal = 0;
        static int busTotal = 0;


        private static List<TicketBL> ticketsList = new List<TicketBL>();
        private static List <TicketBL> cancelledTicketsList = new List<TicketBL>();

        public static List<TicketBL> getTicketsList() => ticketsList;
        public static List<TicketBL> getCancelledTicketsList() => cancelledTicketsList;

        public static void addTicketIntoList(TicketBL ticket)
        {
            ticketsList.Add(ticket);
        }
        public static void calculateTotal(int price)
        {
            total = total + price;
            
        }
        public static int getTotal()
        {
            return total;
        }
        public static void addCancelledTicketIntoList(TicketBL ticket)
        {
            ticketsList.Add(ticket);
        }

        public static void deleteTicket(string name)
        {
            addCancelledTicketIntoList(findTicket(name));
            ticketsList.Remove(findTicket(name));
        }
        public static void emergency()
        {
            foreach(TicketBL ticket in ticketsList)
            {
                ticketsList.Remove(ticket);
            }
        }
        public static TicketBL findTicket(string name)
        {
            foreach (TicketBL t in ticketsList)
            {
                if (name == t.Name)
                {
                    return t;
                }
            }
            return null;
        }

        //  F I L E     H A N D L I N G
        //  S T O R E
        public static void storeTickets()
        {
            StreamWriter file = new StreamWriter("Tickets.txt");
            foreach (TicketBL v in ticketsList)
            {
                file.WriteLine(v.TrainFrom + "," + v.TrainTo + "," + v.getTrainClass() + "," +v.Name + "," +v.Age + "," +v.Gender);
            }
            file.Flush();
            file.Close();
        }
        public static void storeCancelledTickets()
        {
            StreamWriter file = new StreamWriter("CancelledTickets.txt");
            foreach (TicketBL v in cancelledTicketsList)
            {
                file.WriteLine(v.TrainFrom + "," + v.TrainTo + "," + v.getTrainClass() + "," + v.Name + "," + v.Age + "," + v.Gender);
            }
            file.Flush();
            file.Close();
        }
        //L O A D
        public static void loadTickets()
        {
            ticketsList = new List<TicketBL>();
            StreamReader file = new StreamReader("Tickets.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                TicketBL temp = new TicketBL(record[0], record[1], record[2],record[3],uint.Parse(record[4]),record[5]);
                ticketsList.Add(temp);
            }
            file.Close();
        }
        public static void loadCancelledTickets()
        {
            cancelledTicketsList = new List<TicketBL>();
            StreamReader file = new StreamReader("CancelledTickets.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                TicketBL temp = new TicketBL(record[0], record[1], record[2], record[3], uint.Parse(record[4]), record[5]);
                cancelledTicketsList.Add(temp);
            }
            file.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class Train
    {
        private string train_name;
        private string startingPos;
        private string endingPos;
        private int capEco;
        private int capMed;
        private int capBus;
        private int priceEco;
        private int priceMed;
        private int priceBus;
        private DateTime departure;
        private DateTime arrival;

        // G E T T E R    S E T T E R
        public string Train_name { get => train_name; set => train_name = value; }
        public string StartingPos { get => startingPos; set => startingPos = value; }
        public string EndingPos { get => endingPos; set => endingPos = value; }
        public int CapEco { get => capEco; set => capEco = value; }
        public int CapMed { get => capMed; set => capMed = value; }
        public int CapBus { get => capBus; set => capBus = value; }
        public int PriceEco { get => priceEco; set => priceEco = value; }
        public int PriceMed { get => priceMed; set => priceMed = value; }
        public int PriceBus { get => priceBus; set => priceBus = value; }
        public DateTime Departure { get => departure; set => departure = value; }
        public DateTime Arrival { get => arrival; set => arrival = value; }

        // C O N S T R U C T O R
        public Train(string train_name, string startingPos, string endingPos, int capEco, int capMed, int capBus, int priceEco, int priceMed, int priceBus)
        {
            this.train_name = train_name;
            this.startingPos = startingPos;
            this.endingPos = endingPos;
            this.capEco = capEco;
            this.capMed = capMed;
            this.capBus = capBus;
            this.priceEco = priceEco;
            this.priceMed = priceMed;
            this.priceBus = priceBus;
        }
    }
}

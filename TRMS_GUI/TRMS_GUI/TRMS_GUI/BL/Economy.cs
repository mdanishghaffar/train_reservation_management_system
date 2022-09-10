using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class Economy : TicketBL
    {
        public Economy(string trainFrom, string trainTo, string trainClass, string name, uint age, string gender, int comfort) : base(trainFrom, trainTo, trainClass, name, age, gender)
        {
            this.comfort = comfort;
        }
        public override string getTrainClass()
        {
            return "Economy";
        }
        public override void setTrainClass(string trainClass)
        {
            this.trainClass = trainClass;
        }
        public override void setComfort(int comfort)
        {
            this.comfort = 1;
        }
        public override int getComfort()
        {
            return this.comfort;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class Medium : TicketBL
    {
        public Medium(string trainFrom, string trainTo, string trainClass, string name, uint age, string gender, int comfort) : base(trainFrom, trainTo, trainClass, name, age, gender)
        {
            this.comfort = comfort;
        }
        public override string getTrainClass()
        {
            return "Medium";
        }
        public override void setTrainClass(string trainClass)
        {
            this.trainClass = trainClass;
        }
        public override void setComfort(int comfort)
        {
            this.comfort = 2;
        }
        public override int getComfort()
        {
            return this.comfort;
        }
    }
}

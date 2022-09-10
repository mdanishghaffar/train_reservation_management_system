using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class Business : TicketBL
    {
        protected bool isACavailable;
        protected string meal;
        protected bool berth;
        protected bool isTVavailable;

        public bool IsACavailable { get => isACavailable; set => isACavailable = value; }
        public string Meal { get => meal; set => meal = value; }
        public bool Berth { get => berth; set => berth = value; }
        public bool IsTVavailable { get => isTVavailable; set => isTVavailable = value; }

        public Business(string trainFrom, string trainTo, string trainClass, string name, uint age, string gender, int comfort, bool isACavailable, string meal, bool berth, bool isTVavailable) : base(trainFrom, trainTo, trainClass, name, age, gender)
        {
            this.isACavailable = isACavailable;
            this.meal = meal;
            this.berth = berth;
            this.isTVavailable = isTVavailable;
            this.comfort = comfort;
        }

        public override string getTrainClass()
        {
            return "Business";
        }
        public override void setTrainClass(string trainClass)
        {
            this.trainClass = trainClass;
        }
        public override void setComfort(int comfort)
        {
            this.comfort = 3;
        }
        public override int getComfort()
        {
            return this.comfort;
        }
    }
}

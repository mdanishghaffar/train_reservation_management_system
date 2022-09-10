using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRMS.BL
{
    class TicketBL
    {
        protected string trainFrom;
        protected string trainTo;
        protected string trainClass;
        protected string name;
        protected uint age;
        protected string gender;
        protected int comfort;

        // G E T T E R   S E T T E R
        public string TrainTo { get => trainTo; set => trainTo = value; }
        public string TrainFrom { get => trainFrom; set => trainFrom = value; }
        public string Name { get => name; set => name = value; }
        public uint Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }

        public virtual void setTrainClass(string trainClass) { this.trainClass = trainClass; }
        public virtual string getTrainClass() { return trainClass; }
        public virtual void setComfort(int comfort) { this.comfort = comfort; }
        public virtual int getComfort() { return comfort; }


        // C O N S T R U C T O R
        public TicketBL() { }
        public TicketBL(string trainFrom, string trainTo, string trainClass, string name, uint age, string gender)
        {
            this.trainFrom = trainFrom;
            this.trainTo = trainTo;
            this.trainClass = trainClass;
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
    }
}

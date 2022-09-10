using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRMS;
using TRMS.BL;
using System.IO;

namespace TRMS.DL
{
    class TrainDL
    {
        private static List<Train> trainsList = new List<Train>();

        public static List<Train> getTrainList() => trainsList;

        public static void addTrainIntoList(Train train)
        {
            trainsList.Add(train);
        }

        public static void deleteTrain(string t_name)
        {
            trainsList.Remove(findTrain(t_name));
        }
        public static Train findTrain(string t_name)
        {
            foreach (Train t in trainsList)
            {
                if (t_name == t.Train_name)
                {
                    return t;
                }
            }
            return null;
        }

        //     F I L E   H A N D L I N G 
        public static void storeTrain()
        {
            StreamWriter file = new StreamWriter("Trains.txt");
            foreach (Train v in trainsList)
            {
                file.WriteLine(v.Train_name +"," + v.StartingPos + "," + v.EndingPos + "," + v.CapEco + "," +v.CapMed + "," +v.CapBus + "," +v.PriceEco + "," +v.PriceMed + "," +v.PriceBus);
            }
            file.Flush();
            file.Close();
        }
        public static void loadTrain()
        {
            trainsList = new List<Train>();
            StreamReader file = new StreamReader("Trains.txt");
            String line;
            while ((line = file.ReadLine()) != null)
            {
                string[] record = line.Split(',');
                Train temp = new Train(record[0], record[1], record[2],int.Parse(record[3]), int.Parse(record[4]), int.Parse(record[5]), int.Parse(record[6]), int.Parse(record[7]), int.Parse(record[8]));
                trainsList.Add(temp);
            }
            file.Close();
        }

    }
}

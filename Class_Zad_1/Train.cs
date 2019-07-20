using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_1
{
    class Train
    {
        ShedulerOfTrain[] trains = new ShedulerOfTrain[4];

        int counter = 0;

        public int TrainLength
        {
            get
            {
                return counter;
            }
        }

        public ShedulerOfTrain this[int index]
        {
            get
            {
                return trains[index];
            }
        }

        public void AddTrain(ShedulerOfTrain instance)
        {
            if (counter < trains.Length)
            {
                trains[counter] = instance;
                counter++;
            }
            else
            {
                Resize(trains.Length * 2);
                AddTrain(instance);
            }
        }

        private void Resize(int newLength)
        {
            ShedulerOfTrain[] newTrains = new ShedulerOfTrain[newLength];
            for (int i = 0; i < trains.Length; i++)
            {
                newTrains[i] = trains[i];
            }
            trains = newTrains;
        }

        private int IndexOf(string name)
        {
            for (int i = 0; i < TrainLength; i++)
            {
                if (trains[i].Name == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public ShedulerOfTrain GetTrain(string name)
        {
            //if (IndexOf(name) == -1)
            //{
            //    return new ShedulerOfTrain();
            //}
            return trains[IndexOf(name)];
        }
    }
}

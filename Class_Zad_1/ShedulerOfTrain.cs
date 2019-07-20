using System;

namespace Class_Zad_1
{
    struct ShedulerOfTrain
    {
        string name;
        string RailType;
        DateTime DepartureTime;
        DateTime ArrivalTime;
        string departurePoint;
        string ArrivalPoint;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public string DepaeparturePoint
        {
            get
            {
                return departurePoint;
            }
        }

        public ShedulerOfTrain(string name, string railType, DateTime departureTime, DateTime arrivalTime, string departurePoint, string arrivalPoint)
        {
            this.name = name;
            RailType = railType;
            DepartureTime = departureTime;
            ArrivalTime = arrivalTime;
            this.departurePoint = departurePoint;
            ArrivalPoint = arrivalPoint;
        }

        public override string ToString()
        {
            return $"Name: {name} \n RailType: {RailType} \n DepartureTime: {DepartureTime} " +
                $"\n ArrivalTime: {ArrivalTime} \n DeparturePoint: {departurePoint} " +
                $"\n ArrivalPoin: {ArrivalPoint}";
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Zad_1
{
    class RailStation
    {
        private static RailStation railStation = null;
        private static Train trains = new Train();

        protected RailStation()
        {
            trains.AddTrain(new ShedulerOfTrain("711", "Высокоскоростной", DateTime.Now, DateTime.Now, "Киев", "Константиновка"));
            trains.AddTrain(new ShedulerOfTrain("714", "Высокоскоростной", DateTime.Now, DateTime.Now, "Константиновка", "Киев"));
        }

        public static RailStation Instance()
        {
            if (railStation == null)
            {
                railStation = new RailStation();
            }

            return railStation;
        }
        public void SendTrain(Train train)
        {
            Console.WriteLine($"Поезда отправляются: ");
            for (int i = 0; i < train.TrainLength; i++)
            {
                Console.WriteLine($"Поезд {train[i].Name} отправляется в {train[i].DepaeparturePoint}");
            }
        }

        public void ShowTrainInformations()
        {
            for (int i = 0; i < trains.TrainLength; i++)
            {
                Console.WriteLine(trains[i]);
            }
        }

        private ShedulerOfTrain GetTrain(string name)
        {
            return trains.GetTrain(name);
        }

        public void ShowInformationOfTrain()
        {
            Console.Write("Введите название поезда: ");
            Console.WriteLine(GetTrain(Console.ReadLine()));
        }

        public void AddTrain()
        {
            Console.Write("Введите название поезда: ");
            string name = Console.ReadLine();
            Console.Write("Введите тип поезда: ");
            string railType = Console.ReadLine();
            Console.WriteLine("Введите дату отправления: ");
            DateTime departmentDate;
            while (true)
            {
                if (setDate(out departmentDate))
                {
                    break;
                }
                Console.WriteLine("Вы ввели некорректную дату, попробуйте снова.");
            }
            Console.WriteLine("Введите дату прибытия: ");
            DateTime arrivalDate;
            while (true)
            {
                if (setDate(out arrivalDate))
                {
                    break;
                }
                Console.WriteLine("Вы ввели некорректную дату, попробуйте снова.");
            }
            Console.Write("Введите место отправления: ");
            string departmentPoint = Console.ReadLine();
            Console.Write("Введите мето прибытия: ");
            string arrivelPoint = Console.ReadLine();

            trains.AddTrain(new ShedulerOfTrain(name, railType, departmentDate, arrivalDate, departmentPoint, arrivelPoint));
        }

        private bool setDate(out DateTime departmentTime)
        {
            Console.Write("Введиет год: ");
            string sYear = Console.ReadLine();
            Console.Write("Введиет месяц: ");
            string sMonth = Console.ReadLine();
            Console.Write("Введиет день: ");
            string sDay = Console.ReadLine();

            departmentTime = new DateTime();

            if (!Int32.TryParse(sYear, out int year))
            {
                return false;
            }
            if (!Int32.TryParse(sMonth, out int month))
            {
                return false;
            }
            if (!Int32.TryParse(sDay, out int day))
            {
                return false;
            }

            departmentTime = new DateTime(year, month, day);

            return true;

        }
    }
}

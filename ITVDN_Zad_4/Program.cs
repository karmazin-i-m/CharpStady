using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITVDN_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Date date = new Date(60);

            Date datetest = new Date(1, 1, 0);

            Console.WriteLine(date+datetest);
            Console.ReadKey();
        }
    }

    class Date
    {
        private int day, year;
        private Month month;

        public Date(int day, int month, int year)
        {
            if (year >= 0 && year < 9999)
            {
                this.year = year;
                if (month > 0 && month < 13)
                {
                    ArgumentOutOfRangeException e = new ArgumentOutOfRangeException("Слишком большое или маленькое значение day");
                    this.month = (Month)month;
                    switch (this.month)
                    {
                        case Month.Juanuary:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                        case Month.February:
                            if (year % 4 == 0)
                                this.day = day <= 29 && day > 0 ? day : throw e;
                            else
                                this.day = day <= 28 && day > 0 ? day : throw e;
                            break;
                        case Month.March:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                        case Month.April:
                            this.day = day <= 30 && day > 0 ? day : throw e;
                            break;
                        case Month.May:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                        case Month.June:
                            this.day = day <= 30 && day > 0 ? day : throw e;
                            break;
                        case Month.Jule:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                        case Month.August:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                        case Month.September:
                            this.day = day <= 30 && day > 0 ? day : throw e;
                            break;
                        case Month.October:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                        case Month.November:
                            this.day = day <= 30 && day > 0 ? day : throw e;
                            break;
                        case Month.December:
                            this.day = day <= 31 && day > 0 ? day : throw e;
                            break;
                    }
                }
                else
                    throw new ArgumentOutOfRangeException("Недопустимое значение для month");
            }
            else
                throw new ArgumentOutOfRangeException("Недопустимое значение для year");
        }

        public Date(long day)
        {
            int year = 0, days = 0;
            Month month = Month.Juanuary;

            while (day >= 366)
            {
                if (year == 0)
                {
                    day -= 365;
                    year++;
                }
                else
                {
                    if (year % 4 == 0)
                    {
                        day -= 366;
                        year++;
                    }
                    else
                    {
                        day -= 365;
                        year++;
                    }
                }
            }

            while (day >= 31)
            {
                switch (month)
                {
                    case Month.Juanuary:
                        day -= 31;
                        month = Month.February;
                        break;
                    case Month.February:
                        if (year != 0)
                            day -= year % 4 == 0 ? 29 : 28;
                        else
                            day -= 28;
                        month = Month.March;
                        break;
                    case Month.March:
                        day -= 31;
                        month = Month.April;
                        break;
                    case Month.April:
                        day -= 30;
                        month = Month.May;
                        break;
                    case Month.May:
                        day -= 31;
                        month = Month.June;
                        break;
                    case Month.June:
                        day -= 30;
                        month = Month.Jule;
                        break;
                    case Month.Jule:
                        day -= 31;
                        month = Month.August;
                        break;
                    case Month.August:
                        day -= 31;
                        month = Month.September;
                        break;
                    case Month.September:
                        day -= 30;
                        month = Month.October;
                        break;
                    case Month.October:
                        day -= 31;
                        month = Month.November;
                        break;
                    case Month.November:
                        day -= 30;
                        month = Month.December;
                        break;
                    case Month.December:
                        day -= 31;
                        month = Month.Juanuary;
                        break;
                }
            }

            days = (int)day;

            this.year = year;
            if (month == Month.February && days == 29)
            {
                days -= 28;
                month = Month.March;
            }
            this.month = month;
            this.day = days;

        }

        public int Year => year;
        public int Day => day;
        public Month Month => month;

        private long YearToDays(int year)
        {
            if (year < 0 && year > 9999) throw new ArgumentOutOfRangeException();

            int days = 0;
            for (int i = 0; i < year; i++)
            {
                days = i % 4 == 0 ? days + 366 : days + 365;
            }
            return days;
        }

        private int MonthToDays(Month month, bool isLeap)
        {
            int days = 0;
            for (int i = 1; i < (int)month; i++)
            {
                switch ((Month)i)
                {
                    case Month.Juanuary:
                        days += 31;
                        break;
                    case Month.February:
                        days += isLeap ? 29 : 28;
                        break;
                    case Month.March:
                        days += 31;
                        break;
                    case Month.April:
                        days += 30;
                        break;
                    case Month.May:
                        days += 31;
                        break;
                    case Month.June:
                        days += 30;
                        break;
                    case Month.Jule:
                        days += 31;
                        break;
                    case Month.August:
                        days += 31;
                        break;
                    case Month.September:
                        days += 30;
                        break;
                    case Month.October:
                        days += 31;
                        break;
                    case Month.November:
                        days += 30;
                        break;
                    case Month.December:
                        days += 31;
                        break;
                }
            }
            return days;
        }

        public static Date operator +(Date date1, Date date2)
        {
            bool isLeap1, isLeap2;

            if (date1.year != 0)
                isLeap1 = date1.Year % 4 == 0 ? true : false;
            else
                isLeap1 = false;

            if (date2.year != 0)
                isLeap2 = date2.Year % 4 == 0 ? true : false;
            else
                isLeap2 = false;

            long days1 = date1.Day + date1.MonthToDays(date1.month, isLeap1) + date1.YearToDays(date1.Year);
            long days2 = date2.Day + date2.MonthToDays(date2.month, isLeap2) + date2.YearToDays(date2.Year);

            return new Date(days1 + days2);
        }
        public override string ToString()
        {
            return $"{this.Day}.{this.Month}.{this.Year}";
        }
    }


}
enum Month
{
    Juanuary = 1,
    February,
    March,
    April,
    May,
    June,
    Jule,
    August,
    September,
    October,
    November,
    December,
}


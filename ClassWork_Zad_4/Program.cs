using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_4
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday;

            Console.Write("Введите дату рождения: ");
            birthday = DateTime.Parse(Console.ReadLine());
            TimeSpan timeSpan = new TimeSpan(birthday.Day, 0, 0, 0);

            Zodiak znak = Zodiak.Default;
            for (Zodiak zodiak = Zodiak.Aquarius; zodiak <= Zodiak.Capricorn; zodiak++)
            {
                switch (zodiak)
                {
                    case Zodiak.Aries:
                        znak = Zodiak.Aries;
                        break;
                    case Zodiak.Taurus:
                        znak = Zodiak.Taurus;
                        break;
                    case Zodiak.Gemini:
                        znak = Zodiak.Gemini;
                        break;
                    case Zodiak.Cancer:
                        znak = Zodiak.Cancer;
                        break;
                    case Zodiak.Leo:
                        znak = Zodiak.Leo;
                        break;
                    case Zodiak.Virgo:
                        znak = Zodiak.Virgo;
                        break;
                    case Zodiak.Libra:
                        znak = Zodiak.Libra;
                        break;
                    case Zodiak.Scorpio:
                        znak = Zodiak.Scorpio;
                        break;
                    case Zodiak.Sagittarius:
                        znak = Zodiak.Sagittarius;
                        break;
                    case Zodiak.Capricorn:
                        znak = Zodiak.Capricorn;
                        break;
                    case Zodiak.Aquarius:
                        znak = Zodiak.Aquarius;
                        break;
                    case Zodiak.Pisces:
                        znak = Zodiak.Pisces;
                        break;
                }

                if (birthday.DayOfYear == (int)zodiak)
                {
                    Console.WriteLine($"Ваш знак зодиака {znak}");
                }
            }
            Console.ReadKey();
        }
    }
    enum Zodiak
    {
        Default,
        Aries = 80,          //80
        Taurus = 111,         //111
        Gemini = 142,         //142
        Cancer = 173,         //173
        Leo = 204,            //204
        Virgo = 234,          //234
        Libra = 267,          //267
        Scorpio = 297,        //297
        Sagittarius = 327,    //327
        Capricorn = 357,      //357
        Aquarius = 21,       //21
        Pisces = 51,         //51
    }

}

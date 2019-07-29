namespace Class_Zad_2
{
    interface IInt
    {
        void ShowCurentData();
    }
    interface IInt<Y>
    {
        Y PropertyA { get; set; }
        Y PropertyB { get; set; }

        void SetPropsData(Y a, Y b);
    }
    interface IInt3<DateTime>
    {
        DateTime dateTime { get; set; }

        void SetCurentDateTime();
    }
}

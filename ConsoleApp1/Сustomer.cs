using System.Collections.Generic;

namespace ITVDN_Zad_2
{
    class Сustomer
    {
        List<Car> cars = new List<Car>();
        string name;
        int phonenumber;

        public Сustomer(Car car, string name, int phonenumber)
        {
            this.cars.Add(car);
            this.name = name;
            this.phonenumber = phonenumber;
        }

        public List<Car> Cars => cars;
        public string Name => name;
        public int PhoneNumber => phonenumber;

        public override bool Equals(object obj)
        {
            return obj is Сustomer сustomer &&
                   EqualityComparer<List<Car>>.Default.Equals(cars, сustomer.cars) &&
                   name == сustomer.name &&
                   phonenumber == сustomer.phonenumber &&
                   EqualityComparer<List<Car>>.Default.Equals(Cars, сustomer.Cars) &&
                   Name == сustomer.Name &&
                   PhoneNumber == сustomer.PhoneNumber;
        }

        public override int GetHashCode()
        {
            var hashCode = 60883748;
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Car>>.Default.GetHashCode(cars);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + phonenumber.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<List<Car>>.Default.GetHashCode(Cars);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + PhoneNumber.GetHashCode();
            return hashCode;
        }
    }
}

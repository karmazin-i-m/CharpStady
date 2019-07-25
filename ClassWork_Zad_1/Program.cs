

namespace ClassWork_Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListCollection<string> listCollection = new ListCollection<string>();

            listCollection.Add("One");
            listCollection.Add("One1");
            listCollection.Add("One2");
            listCollection.Add("One3");
            listCollection.Add("One4");
            listCollection.Add("One5");

            System.Console.Write(listCollection);
            System.Console.WriteLine(new string('-', 80));
            listCollection.Clear();


            System.Console.Write(listCollection);
            System.Console.WriteLine(new string('-', 80));

            listCollection.Add("One");
            listCollection.Add("One1");
            listCollection.Add("One2");
            listCollection.Add("One3");
            listCollection.Add("One4");
            listCollection.Add("One5");

            listCollection.RemoveAt(4);
            listCollection.Remove("One2");

            System.Console.Write(listCollection);
            System.Console.WriteLine(new string('-', 80));

            System.Console.WriteLine(listCollection.Contains("One3"));
            System.Console.WriteLine(listCollection.Contains("One2"));

            System.Console.WriteLine(new string('-', 80));

            string[] array = listCollection.ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                System.Console.WriteLine(array[i]);
            }

            System.Console.ReadKey();
        }
    }

}

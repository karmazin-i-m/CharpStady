namespace Class_Zad_2
{
    interface IList<T>
    {
        int Capacity { get; }
        int Count { get; }

        void Add(T item);
        bool Remove(T item);
        bool RemoveAt(int index);
        int IndexOf(T item);
        void Resize(int newLength);

    }
}

namespace ClassWork_Zad_1
{
    interface IList<T>
    {
        void Add(T item);
        void Clear();
        void Resize(int capacity);
        T[] ToArray();
        bool Remove(T item);
        int IndexOf(T item);

        int Count { get; }
        int Capacity { get; }
        T this[int index]
        {
            get;
            set;
        }
    }

}

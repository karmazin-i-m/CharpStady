namespace ITVDN_Zad_3
{
    struct MyKeyValuePair<TKey, TValue>
    {
        public MyKeyValuePair(TKey key, TValue value)
        {
            this.Key = key;
            this.Value = value;
        }

        public TKey Key { get; private set; }
        public TValue Value { get; private set; }
    }
}

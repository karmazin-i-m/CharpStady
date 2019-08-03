namespace HomeWork_Zad_1
{
    class MyDictionary<TKey, TValue1, TValue2>
    {
        private const int defaultSize = 4;
        TKey[] keys = new TKey[defaultSize];
        TValue1[] values1 = new TValue1[defaultSize];
        TValue2[] values2 = new TValue2[defaultSize];

        private int count = 0;
        private int capacity = defaultSize;

        public int Count { get => count; }

        public object this[TKey key, int index]
        {
            get
            {
                switch (index)
                {
                    case 1:
                        if (IndexOfKey(key) != -1)
                            return values1[IndexOfKey(key)];
                        else throw new System.ArgumentException(nameof(key));
                    case 2:
                        if (IndexOfKey(key) != -1)
                            return values2[IndexOfKey(key)];
                        else throw new System.ArgumentException(nameof(key));
                    default:
                        throw new System.ArgumentOutOfRangeException(nameof(index));
                }
                
            }

        }

        public TValue1 this[int key]
        {
            get
            {
                if (key >= 0 && key < count)
                    return values1[key];
                else return default;
            }

        }

        private int IndexOfKey<T>(T value)
        {
            if (value is TKey)
            {
                for (int i = 0; i < keys.Length; i++)
                {
                    if (keys[i].Equals(value))
                    {
                        return i;
                    }
                }
                return -1;
            }
            else
            {
                for (int i = 0; i < values1.Length; i++)
                {
                    if (keys[i].Equals(value))
                    {
                        return i;
                    }
                }
                return -1;
            }
        }

        public void Add(TKey key, TValue1 value1, TValue2 value2)
        {
            if (count < capacity)
            {
                keys[count] = key;
                values1[count] = value1;
                count++;
            }
            else
            {
                Resize(count * 2);
                Add(key, value1, value2);
            }
        }

        private void Resize(int newLength)
        {
            TKey[] newKeys = new TKey[newLength];
            TValue1[] newValues1 = new TValue1[newLength];
            TValue2[] newValues2 = new TValue2[newLength];

            for (int i = 0; i < count; i++)
            {
                newKeys[i] = keys[i];
                newValues1[i] = values1[i];
                newValues2[i] = values2[i];
            }
            keys = newKeys;
            values1 = newValues1;
            values2 = newValues2;
            capacity = newLength;
        }

        public override string ToString()
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine($"key: {keys[i]} = {values1[i]} :value1 value2: {values2[i]}");
            }
            return "";
        }
    }
}

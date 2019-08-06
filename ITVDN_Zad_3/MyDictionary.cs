namespace ITVDN_Zad_3
{
    partial class Program
    {
        class MyDictionary<TKey, TValue>
        {
            private const int defaultSize = 4;
            TKey[] keys = new TKey[defaultSize];
            TValue[] values = new TValue[defaultSize];

            private int count = 0;
            private int capacity = defaultSize;

            public int Count { get => count; }

            public TValue this[TKey key]
            {
                get
                {
                    if (IndexOfKey(key) != -1)
                        return values[IndexOfKey(key)];
                    else return default;
                }

            }

            public TValue this[int key]
            {
                get
                {
                    if (key >= 0 && key < count)
                        return values[key];
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
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (keys[i].Equals(value))
                        {
                            return i;
                        }
                    }
                    return -1;
                }
            }

            public void Add(TKey key, TValue value)
            {
                if (count < capacity)
                {
                    keys[count] = key;
                    values[count] = value;
                    count++;
                }
                else
                {
                    Resize(count * 2);
                    Add(key, value);
                }
            }

            private void Resize(int newLength)
            {
                TKey[] newKeys = new TKey[newLength];
                TValue[] newValues = new TValue[newLength];

                for (int i = 0; i < count; i++)
                {
                    newKeys[i] = keys[i];
                    newValues[i] = values[i];
                }
                keys = newKeys;
                values = newValues;
                capacity = newLength;
            }

            public override string ToString()
            {
                for (int i = 0; i < count; i++)
                {
                    System.Console.WriteLine($"key: {keys[i]} = {values[i]} :value");
                }
                return "";
            }
        }
    }
}

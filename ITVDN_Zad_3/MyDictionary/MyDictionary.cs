using System.Collections;
using System.Collections.Generic;
using System;

namespace ITVDN_Zad_3
{
    partial class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IList<KeyValuePair<TKey, TValue>>, IEnumerable, IDictionary, ICollection
    {
        private const int defaultSize = 4;

        private KeyValuePair<TKey, TValue>[] items = new KeyValuePair<TKey, TValue>[defaultSize];
        private KeyColection keys = new KeyColection();
        private ValueColection values = new ValueColection();
        private IEnumerator<KeyValuePair<TKey, TValue>> enumerator = null;
        private IDictionaryEnumerator dictionaryEnumerator = null;
        private object syncRoot = new object();

        private int count = 0;



        public TValue this[TKey key] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public ICollection<TKey> Keys => keys;

        public ICollection<TValue> Values => values;

        public int Count => count;
        public int Capacity => items.Length;

        public bool IsReadOnly => false;

        ICollection IDictionary.Keys => keys;

        ICollection IDictionary.Values => values;

        public bool IsFixedSize => false;

        public object SyncRoot => syncRoot;

        public bool IsSynchronized => false;

        public KeyValuePair<TKey, TValue> this[int index]
        {
            get
            {
                CheckedIndexOutOfRange(index);
                return items[index];
            }
            set
            {
                CheckedIndexOutOfRange(index);
                items[index] = value;
            }
        }
        public object this[object key] { get => this[(int)key]; set => this[(int)key] = (KeyValuePair<TKey, TValue>)value; }

        public void Add(TKey key, TValue value)
        {
            if (Count < Capacity)
            {
                items[count] = new KeyValuePair<TKey, TValue>(key, value);
                keys.Add(key);
                values.Add(value);
                count++;
            }
            else
            {
                Array.Resize<KeyValuePair<TKey, TValue>>(ref items, items.Length * 2);
                Add(key, value);
            }

        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            if (Count <= Capacity)
            {
                items[count] = item;
                keys.Add(item.Key);
                values.Add(item.Value);
                count++;
            }
            else
            {
                Array.Resize<KeyValuePair<TKey, TValue>>(ref items, items.Length * 2);
                Add(item.Key, item.Value);
            }
        }

        public void Clear()
        {
            items = new KeyValuePair<TKey, TValue>[defaultSize];
            keys.Clear();
            values.Clear();
            count = 0;
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item))
                    return true;
            }
            return false;
        }

        public bool ContainsKey(TKey key)
        {
            if (keys.Contains(key))
                return true;
            return false;
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            Array.Copy(items, 0, array, arrayIndex, Count);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return enumerator != null ? enumerator : new DefaultEnumerator<KeyValuePair<TKey, TValue>>(this);
        }

        public bool Remove(TKey key)
        {
            int index = indexOfKey(key);
            if (index == -1) return false;
            else
            {
                keys.Remove(items[index].Key);
                values.Remove(items[index].Value);
                Array.Copy(items, index + 1, items, index, Count - index - 1);
                count--;
                return true;
            }
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            int index = indexOf(item);
            if (index == -1) return false;
            else
            {
                keys.Remove(items[index].Key);
                values.Remove(items[index].Value);
                Array.Copy(items, index + 1, items, index, Count - index - 1);
                count--;
                return true;
            }
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            int index = indexOfKey(key);
            if (index == -1)
            {
                value = default;
                return false;
            }
            else
            {
                value = values[index];
                return true;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int indexOfKey(TKey key)
        {
            return keys.IndexOf(key);
        }
        public int indexOf(KeyValuePair<TKey, TValue> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item)) return i;
            }
            return -1;
        }

        private void CheckedIndexOutOfRange(int index)
        {
            if (index > Count || index < 0)
                throw new IndexOutOfRangeException("Вы вышли за диапазон");
        }

        public bool Contains(object key)
        {
            return Contains((KeyValuePair<TKey, TValue>)key);
        }

        public void Add(object key, object value)
        {
            Add((TKey)key, (TValue)value);
        }

        IDictionaryEnumerator IDictionary.GetEnumerator()
        {
            return dictionaryEnumerator;
        }

        public void Remove(object key)
        {
            Remove((TKey)key);
        }

        public void CopyTo(Array array, int index)
        {
            CopyTo(array, index);
        }

        public void Insert(int index, KeyValuePair<TKey, TValue> item)
        {
            CheckedIndexOutOfRange(index);

            if (Count == Capacity) 
            {
                Array.Resize(ref items, Capacity*2);
            }

            Array.Copy(items, index, items, index + 1, Count - index + 1);
            items[index] = item;
            count++;
        }

        public void RemoveAt(int index)
        {
            CheckedIndexOutOfRange(index);

            Array.Copy(items, index + 1, items, index, Count - index - 1);
            count--;
        }

        public int IndexOf(KeyValuePair<TKey, TValue> item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (items[i].Equals(item)) return i;
            }
            return -1;
        }

        public sealed class KeyColection : IList<TKey>, ICollection<TKey>, IEnumerable<TKey>, IEnumerable, ICollection, IList
        {
            private const int defaultSize = 4;
            private TKey[] items = new TKey[defaultSize];
            private object syncRoot = new object();
            private IEnumerator<TKey> enumerator;

            private int count = 0;
            private TKey current = default;



            public int Count => count;
            public int Сapacity => items.Length;

            public bool IsReadOnly => false;

            public object SyncRoot => syncRoot;

            public bool IsSynchronized => false;

            public TKey Current => current;

            public IEnumerator<TKey> Enumerator { set => enumerator = value; }

            public bool IsFixedSize => throw new NotImplementedException();

            object IList.this[int index] { get => this[index]; set => this[index] = (TKey)value; }

            public TKey this[int index]
            {
                get
                {
                    CheckedIndexOutOfRange(index);
                    return items[index];
                }
                set
                {
                    CheckedIndexOutOfRange(index);
                    items[index] = value;
                }
            }

            public void Add(TKey item)
            {
                if (Count < Сapacity)
                {
                    items[Count] = item;
                    count++;
                }
                else
                {
                    Array.Resize<TKey>(ref items, items.Length * 2);
                    Add(item);
                }
            }

            public void Clear()
            {
                items = new TKey[defaultSize];
                count = 0;
            }

            public bool Contains(TKey item)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (items[i].Equals(item))
                    {
                        return true;
                    }
                }
                return false;
            }

            public void CopyTo(TKey[] array, int arrayIndex)
            {
                Array.Copy(items, 0, array, arrayIndex, Count);
            }

            public IEnumerator<TKey> GetEnumerator()
            {
                return enumerator != null ? enumerator : new DefaultEnumerator<TKey>(this);
            }

            public bool Remove(TKey item)
            {
                int index = IndexOf(item);
                if (index == -1) return false;
                RemoveAt(index);
                return true;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private void CheckedIndexOutOfRange(int index)
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException("Вы вышли за диапазон");
            }

            public void CopyTo(Array array, int index)
            {
                Array.Copy(items, 0, array, index, Count);
            }

            public int IndexOf(TKey item)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (items[i].Equals(item)) return i;
                }
                return -1;
            }

            public void Insert(int index, TKey item)
            {
                CheckedIndexOutOfRange(index);

                if (Count == Сapacity)
                {
                    Array.Resize(ref items, items.Length*2);
                }

                Array.Copy(items, index, items, index + 1, Count - index + 1);
                items[index] = item;
                count++;
            }

            public void RemoveAt(int index)
            {
                CheckedIndexOutOfRange(index);

                Array.Copy(items, index + 1, items, index, Count - index - 1);
                count--;
            }

            public int Add(object value)
            {
                Add((TKey)value);
                return -1;
            }

            public bool Contains(object value)
            {
                return Contains((TKey)value);
            }

            public int IndexOf(object value)
            {
                return IndexOf((TKey)value);
            }

            public void Insert(int index, object value)
            {
                Insert(index, (TKey)value);
            }

            public void Remove(object value)
            {
                Remove((TKey)value);
            }
        }
        public sealed class ValueColection : IList<TValue>, ICollection<TValue>, IEnumerable<TValue>, IEnumerable, ICollection, IList
        {
            private const int defaultSize = 4;
            private TValue[] items = new TValue[defaultSize];
            private object syncRoot = new object();
            private IEnumerator<TValue> enumerator;

            private int count = 0;
            private TValue current = default;



            public int Count => count;
            public int Сapacity => items.Length;

            public bool IsReadOnly => false;

            public object SyncRoot => syncRoot;

            public bool IsSynchronized => false;

            public TValue Current => current;

            public IEnumerator<TValue> Enumerator { set => enumerator = value; }

            public bool IsFixedSize => throw new NotImplementedException();

            object IList.this[int index] { get => this[index]; set => this[index] = (TValue)value; }

            public TValue this[int index]
            {
                get
                {
                    CheckedIndexOutOfRange(index);
                    return items[index];
                }
                set
                {
                    CheckedIndexOutOfRange(index);
                    items[index] = value;
                }
            }

            public void Add(TValue item)
            {
                if (Count < Сapacity)
                {
                    items[Count] = item;
                    count++;
                }
                else
                {
                    Array.Resize<TValue>(ref items, items.Length * 2);
                    Add(item);
                }
            }

            public void Clear()
            {
                items = new TValue[defaultSize];
                count = 0;
            }

            public bool Contains(TValue item)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (items[i].Equals(item))
                    {
                        return true;
                    }
                }
                return false;
            }

            public void CopyTo(TValue[] array, int arrayIndex)
            {
                Array.Copy(items, 0, array, arrayIndex, Count);
            }

            public IEnumerator<TValue> GetEnumerator()
            {
                return enumerator != null ? enumerator : new DefaultEnumerator<TValue>(this);
            }

            public bool Remove(TValue item)
            {
                int index = IndexOf(item);
                if (index == -1) return false;
                RemoveAt(index);
                return true;
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }

            private void CheckedIndexOutOfRange(int index)
            {
                if (index >= Count || index < 0)
                    throw new IndexOutOfRangeException("Вы вышли за диапазон");
            }

            public void CopyTo(Array array, int index)
            {
                Array.Copy(items, 0, array, index, Count);
            }

            public int IndexOf(TValue item)
            {
                for (int i = 0; i < Count; i++)
                {
                    if (items[i].Equals(item)) return i;
                }
                return -1;
            }

            public void Insert(int index, TValue item)
            {
                CheckedIndexOutOfRange(index);

                if (Count == Сapacity)
                {
                    Array.Resize(ref items, items.Length*2);
                }

                Array.Copy(items, index, items, index + 1, Count - index + 1);
                items[index] = item;
                count++;
            }

            public void RemoveAt(int index)
            {
                CheckedIndexOutOfRange(index);

                Array.Copy(items, index + 1, items, index, Count - index - 1);
                count--;
            }

            public int Add(object value)
            {
                Add((TValue)value);
                return -1;
            }

            public bool Contains(object value)
            {
                return Contains((TValue)value);
            }

            public int IndexOf(object value)
            {
                return IndexOf((TValue)value);
            }

            public void Insert(int index, object value)
            {
                Insert(index, (TValue)value);
            }

            public void Remove(object value)
            {
                Remove((TValue)value);
            }
        }

        class DefaultEnumerator<T> : IEnumerator<T>, IEnumerator
        {
            private IList<T> items = null;
            private int position = -1;
            T current = default;

            public DefaultEnumerator(IList<T> enumerable)
            {
                this.items = enumerable;
            }


            public T Current => current;

            object IEnumerator.Current => current;

            public void Dispose()
            {
                Reset();
            }

            public bool MoveNext()
            {
                position++;
                if (position < items.Count)
                {
                    current = items[position];
                    return true;
                }
                return false;
            }

            public void Reset()
            {
                position = -1;
            }
        }
    }
}

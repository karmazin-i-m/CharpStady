using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork_Zad_1
{
    interface IList<T>
    {
        void Add(T item); // Добавить элемент в коллекцию.
        void Clear(); // Очистить коллекцию. МАССИВ НУЖНО ПЕРЕСОЗДАТЬ
        bool Contains(T item); // Возвращает True - если элемент есть в коллекции. False - если нету.
        void Resize(int capacity); // Изменить размер коллекции на указанный параметр. Если нужно - урезайте.
        T[] ToArray(); // Вернуть элементы коллекции в виде массива.
        bool Remove(T item); // Удаляет элемент из коллекции. Если получилось удалить, то возвращает True, не получилось - False.
        bool RemoveAt(int index); // Удаляет элемент из коллекции по индексу.
        int IndexOf(T item); // Возвращает индекс элемента внутреннего массива. Если нет такого элемента, то вернуть -1.

        int Count { get; } // Возвращает количество элементов в коллекции добавленных ПОЛЬЗОВАТЕЛЕМ.
        int Capacity { get; } // Возвращает количество элементов массива. ВНУТРЕННИЙ ОБЪЕМ НАСТОЯЩИЙ.
        T this[int index] { get; set; } // Индексатор.
    }
}

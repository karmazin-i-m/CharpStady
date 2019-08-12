using System;

namespace ITVDN_Zad_1
{
    static class Extention
    {
        public static void Mix(this char[] array)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
        public static void Mix(this int[] array)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            for (int i = array.Length - 1; i >= 1; i--)
            {
                int j = random.Next(i + 1);
                var temp = array[j];
                array[j] = array[i];
                array[i] = temp;
            }
        }
    }
}

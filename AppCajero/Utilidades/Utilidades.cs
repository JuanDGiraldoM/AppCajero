using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCajero.Utilidades
{
    public static class Utilidades
    {
        public static List<T> Shuffle<T>(this List<T> original)
        {
            T[] shuffled = original.ToArray();

            for (int index = shuffled.Length - 1; index > 0; index--)
            {
                int randomIndex = new Random().Next(index);

                T temp = shuffled[index];
                shuffled[index] = shuffled[randomIndex];
                shuffled[randomIndex] = temp;
            }

            return shuffled.ToList();
        }
    }
}

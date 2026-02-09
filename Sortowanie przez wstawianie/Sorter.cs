using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortowanie_przez_wstawianie
{
    public static class Sorter
    {
        public static int[] Sort(int[] InArray)
        {
            int[] OutArray = new int[InArray.Length];

            for (int j = 0; j < InArray.Length; j++)
            {
                int smallestIndex = 0;

                for (int i = 0; i < InArray.Length; i++)
                {
                    if (InArray[i] < InArray[smallestIndex])
                    {
                        smallestIndex = i;
                    }
                }

                OutArray[j] = InArray[smallestIndex];
                InArray[smallestIndex] = int.MaxValue;
            }

            return OutArray;
        }
    }
}
































//Mango mango 67 muuusztarda, i do pieca 😋
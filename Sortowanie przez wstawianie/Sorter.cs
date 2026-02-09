using System;
using System.Collections;
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
            for (int i = 0; i < OutArray.Length; i++)
            {
                OutArray[i] = int.MaxValue;
            }

            OutArray[0] = InArray[0];
            for (int i = 1; i < InArray.Length - 1; i++)
            {
                for (int j = i; j < InArray.Length - 1; j++)
                {
                    if (InArray[i] < OutArray[j])
                    {
                        OutArray[j - 1] = InArray[i];
                    }
                }
            }

            return OutArray;
        }
    }
}
































//Mango mango 67 muuusztarda, i do pieca 😋
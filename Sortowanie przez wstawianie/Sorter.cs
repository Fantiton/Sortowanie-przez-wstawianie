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
            
            OutArray[0] = InArray[0];

            for (int i = 1; i < InArray.Length; i++)
            {
                int current = InArray[i];
                bool inserted = false;

                for (int j = 0; j < i; j++)
                {
                    if (current < OutArray[j])
                    {
                        for(int l = i - 1; l >= j; l--)
                        {
                            int temp = OutArray[l + 1];
                            OutArray[l + 1] = OutArray[l];
                            OutArray[l] = temp;
                        }
   
                        OutArray[j] = current;
                        inserted = true;
                        break;
                    }
                }

                if (!inserted) OutArray[i] = current;
            }

            return OutArray;
        }
    }
}
































//Mango mango 67 muuusztarda, i do pieca 😋
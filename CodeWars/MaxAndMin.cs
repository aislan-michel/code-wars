using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars
{
    public static class MaxAndMin
    {
        public static int FirstForm(int[] arr)
        {
            var max = arr.Max();
            var min = arr.Min();

            return max + min;
        }

        public static int SecondForm(int[] arr)
        {
            var max = -999;
            var min = 999;

            foreach (var number in arr)
            {
                if(number > max)
                {
                    max = number;
                }

                if(number < min)
                {
                    min = number;
                }
            }
            
            return max + min;
        }
    }
}

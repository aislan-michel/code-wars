using System;
using System.Linq;

namespace CodeWars
{
    public static class PersistentBugger
    {
        private static int[] ToIntArray(this string[] arr)
        {
            return arr.Select(int.Parse).ToArray();
        }
        
        public static int Persistence(long number)
        {
            /*
            var splitedNumber = number.ToString().ToList();
            //var result = 0;

            var t = splitedNumber[0];
            
            for (int i = 0; i < splitedNumber.Length; i++)
            {
                var result = splitedNumber[i] * splitedNumber[i + 1];

                Console.WriteLine(result);
            }
            */
            return 0;
        }
    }
}
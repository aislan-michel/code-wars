using System;

namespace CodeWars
{
    public class SplitStrings
    {
        public static string[] Execute(string str)
        {
            var arr = Array.Empty<string>();
            
            if (str.Length % 2 != 0)
            {
                str += "_";
            }

            for (var i = 0; i < str.Length; i += 2)
            {
                arr[i] = $"{str[i]} {str[i + 1]}";
            }
            
            return arr;
        }
    }
}
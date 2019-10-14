using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Work2.Task2
{
    public static class ExtensionsArray
    {
        public static int[] GetEvenDigits(this Array arrayDigits)
        {
            List<int> result= new List<int>();
            foreach(int item in arrayDigits)
            {
                if (item % 2 == 0) result.Add(item);
            }
            return result.ToArray();
        }
    }
}

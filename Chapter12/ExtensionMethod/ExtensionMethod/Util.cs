using System;

namespace Extensions
{
    static class Util
    {
        public static int ConvertToBase(this int i, int baseToConvertTo)
        {
            if(baseToConvertTo < 2 || baseToConvertTo > 10)
            {
                //throw new ArgumentOutOfRangeException("Base should be within rang 2-10!");
                throw new ArgumentException("Value can not be converted to base" + baseToConvertTo.ToString());                
            }

            int result = 0;
            int iteration = 0;
            do
            {
                int nextDigits = i % baseToConvertTo;
                i /= baseToConvertTo;
                result += nextDigits * (int)Math.Pow(10, iteration);
                iteration++;
            } while (i != 0);

            return result;
        }
    }
}
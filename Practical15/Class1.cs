using System;
using System.Collections.Generic;
namespace Lib_1
{
    public static class GenerationNumbers
    {
        public static void GeneratorRandomSum(int k, out string count, out int sum)
        {
            count = "";
            sum = 0;
            Random rnd = new Random();

            while (sum <= k)
            {
                int number = rnd.Next(2, 11);
                sum += number;
                count += Convert.ToString(number) + "; ";

            }
        }
    }

}
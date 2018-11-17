using System;
using System.Collections.Generic;
using System.Linq;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
           var input = new int[] { 1, 6, 1, 2, 6, 1, 6, 6 };
            var result = Challenge(input);

            


            Console.ReadLine();
        }

        public static int Challenge(int[] input)
        {
            var temp = new int[input.Length];
            
            temp.Initialize();

            foreach(var num in input)
            {
                temp[num]++;
            }

            var _m = temp.Max() - 1;

            var list = new List<int>();

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] >= _m)
                {
                    for (int j = 0; j < temp[i]; j++)
                    {
                        list.Add(i);
                    }
                }
            }

            return list.OrderByDescending(x => x).Take(2).Sum();
            
        }
    }
}

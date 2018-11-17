using System;
using System.Threading.Tasks;

namespace Question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var calc = new Calc();
            var result = calc.SomeCalculation(0L,10L,0L == 10L).Result;
        }
    }

    public class Calc
    {
        public Task<(long,int)> SomeCalculation(long param1, long param2, bool param3)
        {
            return Task.FromResult((5000L, 12));
        }
    }
}

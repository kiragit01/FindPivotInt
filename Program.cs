using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindPivotInt
{
    internal class Program
    {
        //https://leetcode.com/problems/find-the-pivot-integer/description/
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(PivotInteger(n));
            Console.ReadKey();
        }

        static int PivotInteger(int n)
        {
            int x = 1;
            while(Sum(1, x) < Sum(x, n)) x++;
            if (Sum(1, x) == Sum(x, n)) return x;
            else return -1;
        }

        static int Sum(int x, int n)
        {
            if (x >= n) return x;
            else return x + Sum(x + 1, n);
        }
    }
}

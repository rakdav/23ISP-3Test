using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    public class MyMath
    {
        public static int Sum(int a,int b)
        {
            return a + b;
        }

        public static long Fact(int n)
        {
            long f = 1;
            for (int i = 1; i <= n; i++) f *= i;
            return f;
        }
    }
}

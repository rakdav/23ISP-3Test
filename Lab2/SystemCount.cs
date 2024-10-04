using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class SystemCount
    {
        public int ToDec(int s)
        {
            string str = s.ToString();
            int len = str.Length;
            int k = 0;
            int res = 0;
            for(int i = len - 1; i >= 0; i--)
            {
                res += int.Parse(str[k++].ToString()) * (int)Math.Pow(8, i);
            }
            return res;
        }
    }
}

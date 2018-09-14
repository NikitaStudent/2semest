using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class Sum
    {
        public static double Result(MyQueue queue, MyStack stack)
        {
            double s = 1;
            double x = 0;
            int c = stack.Count;

            for (int i = 0; i < c/2; i++)
            {
                double q = queue.Pop();
                double st = stack.Pop();
                x = q*q-st*st;
                s *= x;
            }
            return s;
        }
    }
}

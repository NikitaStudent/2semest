using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class ExcerciseWithList
    {
        public static int Col(MyList list, int k)
        {
            int c = 0;
            for (int i = k+1; i < list.Count; i++)
            {
                if (list[i] < 0) c++;
            }
            return c;
        }
    }
}

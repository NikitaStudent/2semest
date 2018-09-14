using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class QueueTask
    {
        public static MyQueue DeleteLastNegElement(MyQueue queue)
        {
            double n;
            int ind = -1;
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                n = queue.Pop();
                if (n < 0)
                    ind = i;
                queue.Push(n);
            }
            for (int j = 0; j < count; j++)
            {
                n = queue.Pop();
                if (j != ind)
                    queue.Push(n);
            }
            return queue;
        }
    }
}

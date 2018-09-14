using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class MyQueue
    {
        public MyNode head { get; private set; }
        private MyNode tail;
        public int Count { get; private set; }

        public MyQueue()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        //очищение очереди
        public void Clear()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        // добавление элемента в очередь
        public void Push(double value)
        {
            MyNode node = new MyNode(value, null);
            if (head != null)
            {
                tail.Next = node;
                tail = node;

            }
            else
            {
                head = node;
                tail = node;
            }
            Count++;
        }

        // взять из очереди
        public double Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Очередь пуста");
            }
            else
            {
                double element = head.Value;
                head = head.Next;
                Count--;
                return element;
            }

        }

        public string[] Printer()
        {
            int L = 0;
            string[] st = new string[0];
            MyNode p = head;
            while (p != null)
            {
                Array.Resize<string>(ref st, ++L);
                st[L - 1] = p.Value.ToString();
                p = p.Next;
            }
            return st;
        }
    }
}

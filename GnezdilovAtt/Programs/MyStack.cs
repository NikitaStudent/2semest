using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    public class MyStack
    {
        private MyNode head;
        public int Count { get; private set; }

        public MyStack()
        {
            head = null;
            Count = 0;
        }

        //очищение стека
        public void Clear()
        {
            head = null;
            Count = 0;
        }

        // добавление элемента в стек
        public void Push(double value)
        {
            MyNode new_element = new MyNode(value, head);
            head = new_element;
            Count++;
        }

        // взять элемент из стека
        public double Pop()
        {
            if (Count == 0)
            {
                throw new Exception("Стек пуст");
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

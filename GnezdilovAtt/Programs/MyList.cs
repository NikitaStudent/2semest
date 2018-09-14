using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
        public class MyNode
        {
            public double Value { get; set; }

            public MyNode Next { get; set; }

            public MyNode(double value = 0, MyNode next = null)
            {
                Value = value;
                Next = next;
            }
        }

        public class MyList
        {
            private  MyNode head;
            public int Count { get; private set; }



            public MyList()
            {
                head = null;
                Count = 0;
            }

            //добавление элемента в начало
            public void AddFirst(int value)
            {
                MyNode node = new MyNode(value, head);
                head = node;
                Count++;
            }

            //очищение списка
            public void Clear()
            {
                head = null;
                Count = 0;
            }

            // Вывод списка
            public string[] Printer()
            {
                string[] st = new string[0];
                int L = 0;
                MyNode node = head;
                if (node != null)
                    do
                    {
                        Array.Resize<string>(ref st, ++L);
                        st[L - 1] = node.Value.ToString();
                        node = node.Next;
                    }
                    while (node != null);
                return st;
            }

            public void Calc(MyList list)
            {
                int r = ColNeg();
                for (int i = 0; i < Count; i++)
                {
                    if (list[i] < 0 && r != 0)
                        r--;
                    AddLast(r);
                }
        }
            //вставка последнего элемента
            public void AddLast(int value)
            {
                if (head != null)
                {
                    MyNode tail = new MyNode();
                    for (MyNode node = head; node != null; node = node.Next)
                    {
                        tail = node;
                    }
                    Count++;
                    tail.Next = new MyNode(value, null);
                }
                else AddFirst(value);
            }
            
            public int ColNeg()
            {
                int c = 0;
                for (MyNode node = head; node != null; node = node.Next)
                {
                    MyNode p = node;

                    if (node.Value < 0)
                        c++;
                }
                return c;
            }

            public MyList Counter() { 
                MyList ml = new MyList();
                int counter = 0;
                for (int i = 0; i < Count; i++)
                {
                    
                    ml.AddLast(GetValue(i) < 0 ? counter++ : counter);
                }

                return ml;
            }

            private double GetValue(int index)
            {
                MyNode node = head;
                for (int i = 0; i < index; i++)
                {
                    if (node.Next == null)
                        throw new Exception();
                    else
                        node = node.Next;

                }
                return node.Value;
            }

            private void SetValue(int index, double value)
            {
                MyNode node = head;
                for (int i = 0; i < index; i++)
                {
                    if (head.Next == null)
                        throw new Exception();
                    else
                        node = node.Next;

                }
                node.Value = value;
        }
        //обращение по индексу
        public double this[int index]
            {
                get => GetValue(index);
                set => SetValue(index, value);
            }

        }
    
}

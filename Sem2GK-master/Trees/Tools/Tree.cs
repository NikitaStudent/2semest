//7
//Подсчитать число узлов на k-ом уровне заданного двоичного дерева
//(корень считать узлом 1-го уровня).
//22 Подсчитать сумму элементов на k-ом уровне заданного двоичного
//дерева(корень считать узлом 1-го уровня).
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{

    public class Node
    {
        public Node Parent { get; set; }
        public double Value { get; set; }
        public List<Node> Nodes { get; set; }
        internal double GetSum(int K)
        {
            if (K == 0)
            {
                return Value;
            }
            else
            {
                double Sum = 0;
                foreach (var item in Nodes)
                {
                    Sum += item.GetSum(K - 1);
                }
                return Sum;
            }
        }
        internal int GetCount(int K)
        {
            if (K == 1)
            {
                return Nodes.Count;
            }
            else
            {
                int sum = 0;
                foreach (var item in Nodes)
                {
                    sum += item.GetCount(K - 1);
                }
                return sum;
            }
        }
        internal int GetLevelCount()
        {
            if (Nodes.Count == 0)
                return 1;
            else
            {
                int max = 0;
                for (int i = 0; i < Nodes.Count; i++)
                    max = Math.Max(max, Nodes[i].GetLevelCount());
                return max + 1;
            }
        }

        public Node(double value = 0, Node parent = null)
        {
            Value = value;
            Parent = parent;
            Nodes = new List<Node>();
        }
        public void Add(double value)
        {
            Nodes.Add(new Node(value, this));
        }
    }
    public class Tree
    {
        public Node Root { get; set; }
        public int GetCount(int K)
        {
            if (K < 0)
                throw new ArgumentException();
            if (K == 0)
                return 1;
            return Root.GetCount(K);
        }
        public double GetSum(int K) => Root.GetSum(K);

        public int GetLevelCount() => Root.GetLevelCount();

        public Tree()
        {
            Root = new Node();
        }
    }
}

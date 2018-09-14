//21 
//Написать программу, которая иллюстрирует работу метода Шелла с
//одной из формул вычисления шага сортировки:
//h[k–1] = 3h[k] + 1, h[t]=1, t = [log3n]–l;
//h[k–1] = 2h[k] + 1, h[t]=1, t = [log2n]–l;
//2k–l;
//2k +1;
//(2k–(–l)k)/3;
//(3k–l)/2;
//числа Фибоначчи.//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{

    public class State
    {
        public int[] Arr { get; set; }
        public int Index { get; set; }
        public int Increment { get; set; }

        public State(int[] arr, int index, int increment)
        {
            Arr = arr;
            Index = index;
            Increment = increment;
        }
    }
    public class SortTools
    {
        List<State> states;
        private int[] arr;
        private void SortShell(List<int> increments)
        { 
            for (int i = 0; i < increments.Count; i++)
            {
                for (int j = 0; j < increments[i]; j++)
                {
                    states.Add(new State((int[])arr.Clone(), j, increments[i]));
                    InsertSort(j, increments[i]);
                    states.Add(new State((int[])arr.Clone(), j, increments[i]));
                }
            }
        }
        private void Swap(int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        private void InsertSort(int index, int increment)
        {
            for (int i = index; i < arr.Length - increment; i += increment)
                for (int j = i + increment; j >= increment; j -= increment)
                {
                    if (arr[j - increment] > arr[j])
                        Swap(j - increment, j);
                    else
                        break;
                }
        }
        private List<int> GetIncrements(IncrementsType type)
        {
            List<int> Increments = new List<int>();
            int last = 1;
            int t = 1;
            do
            {
                Increments.Insert(0, t);
                switch (type)
                {
                    case IncrementsType._3Kplus1:
                        t = 3 * t + 1;
                        break;
                    case IncrementsType._2Kplus1:
                        t = 2 * t + 1;
                        break;
                    case IncrementsType.Fibonachi:
                        t += last;
                        last = t - last;
                        break;
                }
            } while (t<=arr.Length/2);
            return Increments;
        }
        public enum IncrementsType
        {
            _3Kplus1,
            _2Kplus1,
            Fibonachi
        }
        public void Randomize(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                Swap(rnd.Next(arr.Length), rnd.Next(arr.Length));
        }
        private void Init(int n)
        {
            arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = i + 1;
        }
        public List<State> GetSortStates(int Count, IncrementsType type)
        {
            Init(Count);
            Randomize(Count * 2);
            states = new List<State>();
            SortShell(GetIncrements(type));
            return states;
        }
    }
}

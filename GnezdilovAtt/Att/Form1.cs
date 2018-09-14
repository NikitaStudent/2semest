using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programs;
using System.IO;

namespace Att
{
    public partial class Att : Form
    {
        MyList list;
        MyQueue queue;
        MyStack stack;
        public Att()
        {
            list = new MyList();
            queue = new MyQueue();
            stack = new MyStack();
            InitializeComponent();
        }

        private void CreateList_Click(object sender, EventArgs e)
        {
            list.Clear();
            for (int i = 0; i < textBox1.Lines.Length; i++)
            {
                list.AddLast(Convert.ToInt32(textBox1.Lines[i]));
            }
            //textBox2.Lines = list.Printer();
        }

        private void ColElements_Click(object sender, EventArgs e)
        {
            MyList col = list.Counter();
            textBox2.Lines = col.Printer();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            queue.Clear();
            textBox2.Lines = queue.Printer();
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                int k = rand.Next(-100, 101);
                queue.Push(k);
                textBox2.Lines = queue.Printer();
            }
        }

        private void DeleteLastNegElement_Click(object sender, EventArgs e)
        {
            QueueTask.DeleteLastNegElement(queue);
            textBox3.Lines = queue.Printer();
        }

        private void ReadFile_Click(object sender, EventArgs e)
        {
            

            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;
            StreamReader sr = new StreamReader(openFileDialog1.FileName);

            while (!sr.EndOfStream)
            {
                int c = Convert.ToInt32(sr.ReadLine());
                queue.Push(c);
                stack.Push(c);
            }
            sr.Close();
            textBox1.Lines = queue.Printer();
            textBox2.Lines = stack.Printer();
            
            double k = Sum.Result(queue, stack);
            label1.Text = k.ToString();
        }


    }
}

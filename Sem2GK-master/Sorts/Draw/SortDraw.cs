using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tools;
using System.Drawing;
namespace Draw
{
    public class SortDraw
    {
        Bitmap bitmap;
        Graphics G;
        public Bitmap Draw(Size size, State state)
        {
            bitmap = new Bitmap(size.Width, size.Height);
            G = Graphics.FromImage(bitmap);
            int Y = size.Height/2 - 50;
            int X = (size.Width-30) / (state.Arr.Length);
            for (int i = 0; i < state.Arr.Length; i++)
            {
                if((i-state.Index)%state.Increment == 0)
                    G.DrawString(state.Arr[i].ToString(), new Font("Microsoft Sans", 15), Brushes.Red, X * i + 15, Y);
                else
                    G.DrawString(state.Arr[i].ToString(), new Font("Microsoft Sans", 15), Brushes.Black, X * i + 15, Y);
            }
            G.Dispose();
            return bitmap;
        }
    }
}

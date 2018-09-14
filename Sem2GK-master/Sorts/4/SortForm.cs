using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draw;
using Tools;
namespace Sort
{
    public partial class SortForm : Form
    {
        SortDraw sortDraw;
        int N;
        public SortForm()
        {
            InitializeComponent();
        }
        List<State> states;
        private void Form1_Load(object sender, EventArgs e)
        {
            Type.SelectedIndex = 0;
            sortDraw = new SortDraw();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            N = 0;
            SortTools sort = new SortTools();
            states = sort.GetSortStates(20, (SortTools.IncrementsType)Type.SelectedIndex);
            Refresh();
            NextBtn.Enabled = true;
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            N++;
            Refresh();
            PrevBtn.Enabled = true;
            if (N == states.Count - 1)
                NextBtn.Enabled = false;
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            N--;
            Refresh();
            NextBtn.Enabled = true;
            if (N == 0)
                PrevBtn.Enabled = false;
        }

        private void SortForm_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Bitmap bitmap = sortDraw.Draw(new Size(916, 322), states[N]);
                Graphics G = CreateGraphics();
                G.DrawImage(bitmap, 12, 53);
                G.Dispose();
            }
            catch (Exception) { }
        }
    }
}

using System.Windows.Forms;
using System.Threading;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        Thread thr;
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.Filter = "(*.txt)|*.txt";
            openFileDialog1.Title = "¬˚·Ó Ù‡ÈÎ‡";
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.FileName = "";
            timer1.Enabled = false;
            timer1.Interval = 1000;
            timer1.Tick += Paint;
            g = this.CreateGraphics();
        }

        void PaintGraph()
        {
            double a = 0.0;
            int r = 30;
            int[,] coords = new int[Data.graph.n, 2];
            int x, y;
            g.Clear(SystemColors.Control);
            Pen bluePen = new Pen(Color.LightBlue, 5);
            Font font = new Font("Arial", 16);
            for (int i = 0; i < Data.graph.n; i++)
            {
                a += 3.14 * 2 / Data.graph.n;
                x = 250 + (int)(150 * Math.Cos(a));
                y = 250 + (int)(150 * Math.Sin(a));
                g.FillEllipse(Brushes.LightBlue, x - r / 2, y - r / 2, r, r);
                coords[i, 0] = x;
                coords[i, 1] = y;
            }
            for (int i = 0; i < Data.graph.n; i++)
                for (int j = 0; j < Data.graph.n; j++)
                    if (Data.graph.Matrix[i, j] == 1)
                        g.DrawLine(bluePen, coords[i, 0], coords[i, 1], coords[j, 0], coords[j, 1]);
            for (int i = 0; i < Data.graph.n; i++)
                g.DrawString(Convert.ToString(i), font, Brushes.Black, coords[i, 0] - r / 3, coords[i, 1] - r / 3);
        }
        void Paint(object sender, EventArgs e)
        {
            double a = 0.0;
            int r = 30;
            int[,] coords = new int[Data.graph.n, 2];
            int x, y;
            g.Clear(SystemColors.Control);
            Pen bluePen = new Pen(Color.LightBlue, 5);
            Font font = new Font("Arial", 16);
            for (int i = 0; i < Data.graph.n; i++)
            {
                a += 3.14 * 2 / Data.graph.n;
                x = 250 + (int)(150 * Math.Cos(a));
                y = 250 + (int)(150 * Math.Sin(a));
                g.FillEllipse(Brushes.LightBlue, x - r / 2, y - r / 2, r, r);
                coords[i, 0] = x;
                coords[i, 1] = y;
            }
            for (int i = 0; i < Data.graph.n; i++)
                for (int j = 0; j < Data.graph.n; j++)
                    if (Data.graph.Matrix[i, j] == 1)
                        g.DrawLine(bluePen, coords[i, 0], coords[i, 1], coords[j, 0], coords[j, 1]);
            Pen redPen = new Pen(Color.LightCoral, 5);
            lock (Data.stack)
            {
                for (int i = 0; i < Data.stack.length - 1; i++)
                    g.DrawLine(redPen, coords[Data.stack.Path[i], 0], coords[Data.stack.Path[i], 1], coords[Data.stack.Path[i + 1], 0], coords[Data.stack.Path[i + 1], 1]);
            }
            for (int i = 0; i < Data.graph.n; i++)
                g.DrawString(Convert.ToString(i), font, Brushes.Black, coords[i, 0] - r / 3, coords[i, 1] - r / 3);
            if (!thr.IsAlive)
            {
                timer1.Stop();
                String str = "";
                lock (Data.stack)
                {
                    for (int i = 0; i < Data.stack.length; i++)
                        str += Convert.ToString(Data.stack.Path[i]);
                }
                textBox1.Text = str;
            }
        }

        private void ËÁ‘‡ÈÎ‡ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            StreamReader reader = new StreamReader(filename);
            int n;
            int[,] matrix;
            n = Convert.ToInt32(reader.ReadLine());
            matrix = new int[n, n];
            string[] str;
            for (int i = 0; i < n; i++)
            {
                str = reader.ReadLine().Split();
                for (int j = 0; j < n; j++)
                    matrix[i, j] = Convert.ToInt32(str[j]);
            }
            Data.v1 = Convert.ToInt32(reader.ReadLine());
            Data.v2 = Convert.ToInt32(reader.ReadLine());
            Data.a = Convert.ToInt32(reader.ReadLine());
            Data.b = Convert.ToInt32(reader.ReadLine());
            str = reader.ReadLine().Split();
            Data.edge1[0] = Convert.ToInt32(str[0]);
            Data.edge1[1] = Convert.ToInt32(str[1]);
            str = reader.ReadLine().Split();
            Data.edge2[0] = Convert.ToInt32(str[0]);
            Data.edge2[1] = Convert.ToInt32(str[1]);
            reader.Close();
            Data.graph.InputGraph(n, matrix);
            PaintGraph();
        }

        private void Ò Î‡‚Ë‡ÚÛ˚ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Form2 f = new Form2();
            f.ShowDialog();
            PaintGraph();
        }

        private void Á‡ÔÛÒÚËÚ¸¬ÚÓË˜Ì˚ÈœÓÚÓÍToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecondThread sth = new SecondThread();
            thr = new Thread(sth.FindPath);
            thr.Start();
            timer1.Start();

        }
    }
}
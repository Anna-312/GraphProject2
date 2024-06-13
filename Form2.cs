using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data.graph.n = Convert.ToInt32(textBox1.Text);
            label2.Visible = true;
            dataGridView1.Visible = true;
            dataGridView1.ColumnCount = Data.graph.n;
            dataGridView1.RowCount = Data.graph.n;
            for (int i = 0; i < Data.graph.n; i++)
            {
                dataGridView1.Columns[i].Width = dataGridView1.Width / Data.graph.n;
                dataGridView1.Rows[i].Height = dataGridView1.Height / Data.graph.n - 2;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] matrix = new int[Data.graph.n, Data.graph.n];
            for (int i = 0; i < Data.graph.n; i++)
                for (int j = 0; j < Data.graph.n; j++)
                    matrix[i, j] = Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value);
            Data.graph.InputGraph(Data.graph.n, matrix);
            Data.v1 = Convert.ToInt32(textBox2.Text);
            Data.v2 = Convert.ToInt32(textBox3.Text);
            Data.a = Convert.ToInt32(textBox4.Text);
            Data.b = Convert.ToInt32(textBox5.Text);
            Data.edge1[0] = Convert.ToInt32(textBox6.Text);
            Data.edge1[1] = Convert.ToInt32(textBox7.Text);
            Data.edge2[0] = Convert.ToInt32(textBox8.Text);
            Data.edge2[1] = Convert.ToInt32(textBox9.Text);
            this.Close();
        }
    }
}

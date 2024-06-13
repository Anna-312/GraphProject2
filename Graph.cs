using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Graph
    {
        public int[,] Matrix;
        public int n = new int();
        public Graph()
        {
            n = 0;
        }
        public void InputGraph(int n1, int[,] mat)
        {
            n = n1;
            Matrix = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    Matrix[i, j] = mat[i, j];
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class SecondThread
    {
        public bool Cond(int[] st)
        {
            bool firstV = false;
            bool secondV = false;
            bool firstEdge = false;
            bool secondEdge = false;
            for (int i = 0; i < st.Length; i++)
            {
                if (st[i] == Data.a) firstV = true;
                if (st[i] == Data.b) secondV = true;
                if ((st[i] == Data.edge1[1]) && (i >= 1) && (st[i - 1] == Data.edge1[0])) firstEdge = true;
                if ((st[i] == Data.edge2[1]) && (i >= 1) && (st[i - 1] == Data.edge2[0])) secondEdge = true;
            }
            return firstV && secondV && firstEdge && secondEdge;

        }
        public void FindPath()
        {
            int[] St = new int[Data.graph.n];
            int[] M = new int[Data.graph.n];
            int maxLen = 0;
            int[] res = new int[Data.graph.n];
            int Pr, ks, L, v, i;
            for (i = 0; i < M.Length; i++)
                M[i] = 0;
            L = 0;
            ks = 0;
            St[ks] = Data.v1;
            M[Data.v1] = 1;
            while (ks >= 0)
            {
                Pr = 0;
                v = St[ks];
                for (i = L; i < Data.graph.n; i++)
                    if (Data.graph.Matrix[v, i] == 1)
                        if (i == Data.v2)
                        {
                            ks++;
                            St[ks] = Data.v2;
                            lock (Data.stack)
                            {
                                for (int j = 0; j <= ks; j++)
                                    Data.stack.Path[j] = St[j];
                                Data.stack.length = ks + 1;
                            }
                            Thread.Sleep(1000);
                            if (Cond(St))
                                if (ks >= maxLen)
                                {
                                    for (int j = 0; j <= ks; j++)
                                        res[j] = St[j];
                                    maxLen = ks + 1;
                                }
                            ks--;
                        }
                        else
                            if (M[i] == 0)
                            {
                                Pr = 1;
                                break;
                            }
                if (Pr == 1)
                {
                    ks++;
                    St[ks] = i;
                    L = 0;
                    M[i] = 1;
                }
                else
                {
                    L = v + 1;
                    M[v] = 0;
                    ks--;
                }
            }
            lock (Data.stack)
            {
                for (int j = 0; j < maxLen; j++)
                    Data.stack.Path[j] = res[j];
                Data.stack.length = maxLen;
            }
        }
    }
}

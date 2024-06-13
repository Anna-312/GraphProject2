using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Stack
    {
        public int[] Path = new int[100];
        public int length = new int();
        public Stack()
        {
            length = 0;
            for (int i = 0; i < 100; i++)
                Path[i] = 0;
        }
    }
}

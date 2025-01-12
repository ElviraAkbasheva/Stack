using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public static class StackExtensions
    {
        public static void Merge(this Stack s1, Stack s2)
        {
            int border = s2.Size;
            for (int i = 0; i < border; i++)
            {
                s1.Add(s2.Pop());
            }
        }
    }
}
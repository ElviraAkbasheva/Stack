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
            string[] contents = new string[border];
            for (int i = 0; i < border; i++)
            {
                contents[i] = s2.Pop();
            }
            s1.Add(contents);
        }
    }
}
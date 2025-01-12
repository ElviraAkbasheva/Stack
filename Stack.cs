using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        public int Size { get; private set; }
        StackItem RefTop { get ; set; }
        public string Top => RefTop == null ? null : RefTop.ItemValue;

        public Stack(params string[] items)
        {
            Add(items);
        }
        class StackItem
        {
            public string ItemValue { get; private set; }
            public StackItem ItemPrevious { get; set; }
            public StackItem(StackItem item, string itemValue)
            {
                ItemValue = itemValue;
                ItemPrevious = item;
            }
        }
        public void PrintResult()
        {
            string topValue;
            if (Top == null)
            {
                topValue = "null";
            }
            else
            {
                topValue = Top;
            }
            Console.WriteLine($"Size = {Size}, Top = {topValue}");
        }
        public void Add(params string[] items)
        {
            foreach (string item in items)
            {
                StackItem added = new StackItem(RefTop, item);
                RefTop = added;
                Size++;
            }
        }
        public string Pop()
        {
            if (Size > 0)
            {
                string removedValue = RefTop.ItemValue;
                RefTop = RefTop.ItemPrevious;
                Size--;
                return removedValue;
            }
            else
            {
                throw new Exception();
            }
        }
        public void StackContents()
        {
            Console.WriteLine("Содержимое стека:");
            if (Size > 0)
            {
                string[] contents = new string[Size];
                StackItem temp = RefTop;
                for (int i = Size - 1; i > 0; i--)
                {
                    contents[i] = temp.ItemValue;
                    temp = temp.ItemPrevious;
                }
                contents[0] = temp.ItemValue;

                for (int i = 0; i < Size - 1; i++)
                {
                    Console.Write($"{contents[i]}, ");
                }
                Console.Write($"{contents[Size - 1]}\n");
            }
            else
            {
                Console.WriteLine("В стеке нет элементов");
            }
        }
        public static Stack Concat(params Stack[] stacks)
        {
            Stack st = new Stack();
            foreach (Stack item in stacks)
            {
                st.Merge(item);
            }
            return st;
        }
    }
}

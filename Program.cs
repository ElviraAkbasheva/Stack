using Microsoft.VisualBasic.FileIO;

namespace Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var s = new Stack("a", "b", "c");
                Console.WriteLine($"Создал стек:");
                s.PrintResult();
                s.StackContents();

                var deleted = s.Pop();
                Console.WriteLine($"\nИзвлек верхний элемент '{deleted}':");
                s.PrintResult();
                s.StackContents();

                Console.WriteLine("\nДобавил элемент:");
                s.Add("d");
                s.PrintResult();
                s.StackContents();

                Console.WriteLine("\nУдалил три элемента:");
                s.Pop();
                s.Pop();
                s.Pop();
                s.StackContents();
                s.PrintResult();

                Console.WriteLine("\nПопытка удалить элемент из пустого стека:");
                s.Pop();
            }
            catch (Exception)
            {
                Console.WriteLine("Стек пустой");
            }
            Console.WriteLine("\nИспользование метода расширения Merge, класса расширения StackExtension:");

            var sMer = new Stack("a", "b", "c");
            sMer.Merge(new Stack("1", "2", "3"));
            sMer.StackContents();

            var sCon = new Stack();
            sCon.Merge(new Stack("a", "b", "c"));
            sCon.Merge(new Stack("1", "2", "3"));
            sCon.Merge(new Stack("A", "Б", "В"));
            sCon.StackContents();
            sCon.PrintResult();

            Console.WriteLine("\nИспользование метода Concat:");

            var con = Stack.Concat(new Stack("a", "b", "c"), new Stack("1", "2", "3"), new Stack("A", "Б", "В"));
            con.StackContents();
            con.PrintResult();
        }
    }
}

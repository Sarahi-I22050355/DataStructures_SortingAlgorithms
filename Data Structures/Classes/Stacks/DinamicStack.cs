using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Data_Structures.Stacks
{
    internal class DinamicStack<T>
    {
        private List<T> Stack;
        public int Count;

        public T this[int index]
        {
            get { return Stack[index]; }
        }

        public DinamicStack()
        {
            Stack = new List<T>();
        }

        public void Push(T item)
        {
            Stack.Add(item);
            Count++;
        }

        public T Pop()
        {
            if (Stack.Count == 0)
            {
                Console.WriteLine("Void Stack");
                return default(T);
            }

            int lastIndex = Stack.Count - 1;
            T poppedItem = Stack[lastIndex];
            Stack.RemoveAt(lastIndex);

            return poppedItem;
        }

        public T Peek()
        {
            if (Stack.Count == 0)
            {
                Console.WriteLine("Void Stack");
                return default(T);
            }
            Console.WriteLine(Stack[Stack.Count - 1]);
            return Stack[Stack.Count - 1];
        }

        public void Show(DinamicStack<T> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Void Stack");
                return;
            }
            Console.WriteLine("Dinamic Stack");
            do
            {
                stack.Count--;
                Console.WriteLine(stack.Pop());
            } while (stack.Count > 0);
        }
    }
}
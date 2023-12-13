﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Data_Structures.Stacks
{
    internal class StaticStack<T>
    {
        private T[] Elements;
        public int Ability;
        private int Contain;

        public StaticStack(int ability)
        {
            this.Ability = ability;
            this.Elements = new T[ability];
            this.Contain = 0;
        }

        public void Push(T element)
        {
            if (Count < Ability)
            {
                Elements[Contain] = element;
                Contain++;
            }
            else
            {
                Console.WriteLine("Stack FULL!!!");
            }
        }

        public T Pop()
        {
            if (Contain > 0)
            {
                Contain--;
                T elemento = Elements[Contain];
                Elements[Contain] = default(T); // Restablecer el valor a su valor predeterminado
                return elemento;
            }
            else
            {
                Console.WriteLine("Void Stack");
                return default(T); // Valor predeterminado para el tipo T (por ejemplo, null para referencias)
            }
        }

        public T Peek()
        {
            if (Contain > 0)
            {
                Console.WriteLine(Elements[Contain - 1]);
                return Elements[Contain - 1];
            }
            else
            {
                Console.WriteLine("Void Stack");
                return default(T); // Valor predeterminado para el tipo T
            }
        }

        public void Show(StaticStack<T> stack)
        {
            if (stack.Count == 0)
            {
                Console.WriteLine("Void Stack");
                return;
            }
            Console.WriteLine("=== My Stack Static ===");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }

        public int Count
        {
            get { return Contain; }
        }
    }
}
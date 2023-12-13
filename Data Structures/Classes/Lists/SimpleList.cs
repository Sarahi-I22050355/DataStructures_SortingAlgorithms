using DataStructures_SortingAlgorithms.Data_Structures.Nodes;
using DataStructures_SortingAlgorithms.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Data_Structures.Lists
{
    internal class SimpleList<T>:ImethodLists<T>
    {
        private Node<T> Head { get; set; }

        public int Lenght { get; set; }

        public SimpleList()
        {
            Clear();
        }

        public void Add(T data)
        {
            Node<T> NewNode = new Node<T>(data);
            if (IsEmpty())
            {
                Head = NewNode;
                Lenght++;
                return;
            }
            if (Exist(NewNode.Data))
            {
                return;
            }
            if (NewNode.CompareTo(Head) <= 0)
            {
                NewNode.Next = Head;
                Head = NewNode;
                Lenght++;
                return;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.Next.CompareTo(NewNode) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            NewNode.Next = CurrentNode.Next;
            CurrentNode.Next = NewNode;
            Lenght++;
        }

        public void Delete(T data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (object.Equals(Head.Data, data))
            {
                Head = Head.Next;
                Console.WriteLine($"- Data [{data}] remove form List...");
                Lenght--;
                return;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && !object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode = CurrentNode.Next;
            }
            if (CurrentNode.Next != null && object.Equals(CurrentNode.Next.Data, data))
            {
                CurrentNode.Next = CurrentNode.Next.Next;
                Console.WriteLine($"- Data [{data}] remove form List...");
                Lenght--;
                return;
            }
            Console.WriteLine($"- Data [{data}] no remove form List...");
        }

        public void Search(T data)
        {
            if (IsEmpty())
            {
                return;
            }
            if (object.Equals(Head.Data, data))
            {
                Console.WriteLine($"- Data [{data}] exist form List...");
                return;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                Console.WriteLine($"- Data [{data}] exist form List...");
                return;
            }
            Console.WriteLine($"- Data [{data}] dosen't not exist form List...");
        }

        public void Show()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Void List");
                return;
            }
            int i = 0;
            Node<T> CurrentNode = Head;
            Console.WriteLine("Simple List");
            while (CurrentNode != null)
            {
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
                CurrentNode = CurrentNode.Next;
                i++;
            }
        }

        public void ShowRevers()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Void List");
                return;
            }
            Node<T> CurrentNode = Head;
            int x = 0;
            Console.WriteLine("Simple List Reverse");
            for (int i = Lenght - 1; i > -1; i--)
            {
                CurrentNode = Head;
                x = 0;
                while (CurrentNode != null && x != i)
                {
                    CurrentNode = CurrentNode.Next;
                    x++;
                }
                Console.WriteLine($"- Node [{i}] and Data: " + CurrentNode.Data);
            }
        }

        public bool Exist(T data)
        {
            if (IsEmpty())
            {
                return false;
            }
            if (object.Equals(Head.Data, data))
            {
                return true;
            }
            Node<T> CurrentNode = Head;
            while (CurrentNode.Next != null && CurrentNode.CompareTo(data) < 0)
            {
                CurrentNode = CurrentNode.Next;
            }
            if (object.Equals(CurrentNode.Data, data))
            {
                return true;
            }
            return false;
        }

        public bool IsEmpty()
        {
            return Head == null;
        }

        public void Clear()
        {
            Head = null;
        }
    }
}
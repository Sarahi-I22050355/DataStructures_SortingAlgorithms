using DataStructures_SortingAlgorithms.Data_Structures.AllMenus;
using DataStructures_SortingAlgorithms.Data_Structures.Stacks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Data_Structures
{
    internal class SubMenuDStack
    {
        public static string Name = "Dinamic Stack";

        public static Random _Random = new Random();
        public static Information _Information = new Information();
        public static MenuStructures _ShowMenuStructures = new MenuStructures();
        public static DinamicStack<int> _Items = new DinamicStack<int>();

        public static string[] _OptionList = _Information.Stack;

        public SubMenuDStack() { }

        public void MenuOption(int Operation)
        {
            do
            {
                Operation = 0;
                _ShowMenuStructures.PrintArray(_OptionList, Name);
                Console.Write("Select one option: ");
                Operation = Option(Operation);
            } while (Operation != _OptionList.Length - 1);
            return;
        }

        private int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumOperationsStack)option;
            Console.Clear();
            Methos(x);
            return option;
        }

        public void Methos(EnumOperationsStack Stack)
        {
            int Data = 0;
            switch (Stack)
            {
                case EnumOperationsStack.Generate:
                    Console.Write("Generate: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    for (int i = 0; i < Data; i++)
                    {
                        _Items.Push(_Random.Next(100000));
                    }
                    Console.WriteLine("Finish");
                    Console.ReadKey();
                    break;

                case EnumOperationsStack.Push:
                    Console.WriteLine("Insert one data: ");
                    try { Data = int.Parse(Console.ReadLine()); } catch { }
                    _Items.Push(Data);
                    break;

                case EnumOperationsStack.Pop:
                    _Items.Pop();
                    break;

                case EnumOperationsStack.Peek:
                    Console.WriteLine("Peek");
                    _Items.Peek();
                    Console.ReadKey();
                    break;

                case EnumOperationsStack.Contains:
                    Console.Write("Contains: " + _Items.Count);
                    Console.ReadKey();
                    break;

                case EnumOperationsStack.Show:
                    _Items.Show(_Items);
                    Console.ReadKey();
                    break;
            }
        }
    }
}

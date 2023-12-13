using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Data_Structures.AllMenus
{
    internal class MenuStructures
    {
        public string Name = "Menu";

        public static Information _Information = new Information();
        public static MenuStack _ShowMenuStack = new MenuStack();
        public static MenuQueue _ShowMenuQueue = new MenuQueue();
        public static MenuList _ShowMenuList = new MenuList();
        public static MenuTree _ShowMenuTree = new MenuTree();
        public static MenuGraph _ShowMenuGraph = new MenuGraph();
        public static MenuAlgorithm _ShowMenuAlgorithm = new MenuAlgorithm();

        public string[] _TypeDataStructures = _Information.TypeDataStructures;

        public MenuStructures() { }

        public void PrintArray(Array array, string Name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Data Structures: " + Name);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in array)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public int Option(int option)
        {
            try { option = int.Parse(Console.ReadLine()); } catch { }
            var x = (EnumDataStructures)option;
            Console.Clear();
            Menu(option, x);
            return option;
        }

        private void Menu(int Numer, EnumDataStructures DataType)
        {
            Console.Clear();
            switch (DataType)
            {
                case EnumDataStructures.Stack:
                    _ShowMenuStack.CycleStack(Numer);
                    Name = "Menu";
                    break;

                case EnumDataStructures.Queues:
                    _ShowMenuQueue.CycleQueue(Numer);
                    break;

                case EnumDataStructures.List:
                    _ShowMenuList.CycleList(Numer);
                    break;

                case EnumDataStructures.Tree:
                    _ShowMenuTree.CycleTree(Numer);
                    break;

                case EnumDataStructures.Graph:
                    _ShowMenuGraph.CycleGraph(Numer);
                    break;

                case EnumDataStructures.Algorithm:
                    _ShowMenuAlgorithm.CycleAlgorithm(Numer);
                    break;

                case EnumDataStructures.Exit:
                    Console.WriteLine("Goodbye");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
﻿using DataStructures_SortingAlgorithms.Data_Structures.AllMenus;

namespace DataStructures_SortingAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Option;
            MenuStructures Menu = new MenuStructures();
            do
            {
                Option = 0;
                Menu.PrintArray(Menu._TypeDataStructures, Menu.Name);
                Console.Write("Select one option: ");
                Option = Menu.Option(Option);
            } while (Option != 7);
        }
    }
}
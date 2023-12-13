using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Interfaces
{
    internal interface ImethodLists<T>
    {
        void Add(T data);
        void Delete(T data);
        void Search(T data);
        bool Exist(T data);
        void ShowRevers();
        void Show();
        bool IsEmpty();
        void Clear();
    }
}

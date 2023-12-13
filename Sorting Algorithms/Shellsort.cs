using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_SortingAlgorithms.Sorting_Algorithms
{
    internal class Shellsort
    {
        public Shellsort() { }

        public void ShellSort(int[] array)
        {
            // se obtiene la longitud del array
            int n = array.Length;
            // se obtiene el tamaño de espacio entre elementos
            int gap = n / 2;

            Console.WriteLine("\nStart of Shell Sort Algorithm:");

            // Mientras el espacio entre elementos sea mayor que 0
            while (gap > 0)
            {
                Console.WriteLine($"\nCurrent Gap: {gap}");

                // Aplicar el algoritmo de inserción para cada "subarray" con el tamaño de gap
                for (int i = gap; i < n; i++)
                {
                    // Guardar el valor actual del elemento en una variable temporal
                    int temp = array[i];
                    int j = i;

                    Console.WriteLine($"\nCompare {temp} to elements in the subarray:");

                    // Realizar la inserción
                    while (j >= gap && array[j - gap] > temp)
                    {
                        // Desplazar elementos hacia la derecha hasta encontrar la posición correcta
                        array[j] = array[j - gap];
                        j -= gap;

                        PrintArray(array);
                    }

                    // Colocar el valor temporal en la posición correcta en el subarray
                    array[j] = temp;
                    Console.WriteLine($"Insert {temp} in the subarray {j} position:");
                    PrintArray(array);
                }

                // Reducir el espacio entre elementos a la mitad en cada iteración
                gap /= 2;
            }

            Console.WriteLine("\nend of Shell Sort Algorithm:");
        }

        private void PrintArray(int[] array)
        {
            foreach (var num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SortSelect
    {
        private static void Sort(ISort sort, int[] array)
        {
            sort.Sort(array);
            Console.WriteLine("Sorted array: {0}", string.Join(", ", array));
        }
        public void Selection()
        {
            var merge = new MergeSort();
            var insertion = new InsertionSort();
            Console.WriteLine("Select sort method:");
            Console.WriteLine("1 - Merge");
            Console.WriteLine("2 - Insertion");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Merge");
                    Sort(merge, Array.ArrayFill());
                    break;
                case "2":
                    Console.WriteLine("Insertion");
                    Sort(insertion, Array.ArrayFill());
                    break;
                default:
                    Console.WriteLine("Wrong!");
                    break;

            }
        }
    }
}

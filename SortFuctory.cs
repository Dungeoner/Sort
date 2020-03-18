using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class SortFuctory
    {
        public ISort Selection()
        {
            Console.WriteLine("Select sort method:");
            Console.WriteLine("1 - Merge");
            Console.WriteLine("2 - Insertion");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Merge");
                    return new MergeSort();
                case "2":
                    Console.WriteLine("Insertion");
                    return new InsertionSort();
                default:
                    throw new Exception("Wrong number");
            }
        }
    }
}

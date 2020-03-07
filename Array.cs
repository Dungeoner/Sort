using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    static class Array
    {
        private static readonly Random Rnd = new Random();
        public static int[] ArrayFill()
        {
            Console.WriteLine("Enter array size:");
            var array = new int[(Convert.ToInt32(Console.ReadLine()))];
            for (var i = 0; i < array.Length; i++)
            {
                array[i] = Rnd.Next(1000);
            }
            Console.WriteLine("Array: {0}", string.Join(", ", array));
            return array;
        }

    }
}

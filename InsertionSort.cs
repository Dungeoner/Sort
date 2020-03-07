using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class InsertionSort : ISort
    {
        public int[] Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                for (var j = 0; j < i; j++)
                {
                    if (array[i] >= array[j]) continue;
                    var buffer = array[i];
                    for (var k = i; k > j; k--)
                    {
                        array[k] = array[k - 1];
                    }

                    array[j] = buffer;
                } 
            }
            return array;
        }
    }
}
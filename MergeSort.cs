using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class MergeSort : ISort
    {
        public int[] Sort(int[] array)
        {
            return Separate(array, 0, array.Length - 1);
        }
        private void Sort(int[] array, int minIndex, int middleIndex, int maxIndex)
        {
            var buffer = new int[maxIndex - minIndex + 1];
            var left = minIndex;
            var right = middleIndex + 1;
            var index = 0;

            while ((left <= middleIndex) && (right <= maxIndex))
            {
                if (array[left] < array[right])
                {
                    buffer[index] = array[left];
                    left++;
                }
                else
                {
                    buffer[index] = array[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= middleIndex; i++)
            {
                buffer[index] = array[i];
                index++;
                
            }

            for (var i = right; i <= maxIndex; i++)
            {
                buffer[index] = array[i];
                index++;
                
            }

            for (var i = 0; i< buffer.Length; i++)
            {
                array[minIndex + i] = buffer[i];
            }

        }

        private int[] Separate(int[] array, int minIndex, int maxIndex)
        {
            if (minIndex >= maxIndex) return array;
            var middleIndex = (maxIndex + minIndex) / 2;
            Separate(array, minIndex, middleIndex);
            Separate(array, middleIndex + 1, maxIndex);
            Sort(array, minIndex, middleIndex, maxIndex);

            return array;
        }
    }
}

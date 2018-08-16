using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class BinarySearch
    {
        public int Search(int[] arr, int key)
        {
            return SearchItem(arr, key, SearchPivot(arr));
        }

        //find pivot
        private int SearchPivot(int[] arr)
        {
            int lower = 0;
            int upper = arr.Length - 1;
            int pivot = -1;
            int mid = 0;

            if (arr.Length == 0) return -1;

            if (arr[lower] < arr[upper]) return 0;

            while (lower <= upper)
            {
                if (lower == upper)
                {
                    pivot = lower;
                    break;
                }

                mid = (lower + upper) / 2;

                if (arr[mid] < arr[upper])
                    upper = mid;
                else
                    lower = mid + 1;
            }

            return pivot;
        }

        //find item
        private int SearchItem(int[] arr, int key, int pivot)
        {
            if (pivot < 0) return pivot;

            int lower = 0;
            int upper = arr.Length - 1;
            int mid = 0;
            
            if (pivot > 0)
            {
                if (key >= arr[0])
                {
                    lower = 0;
                    upper = pivot > 0 ? pivot - 1 : 0;
                }
                else
                {
                    lower = pivot;
                    upper = arr.Length - 1;
                }
            }


            while (lower <= upper)
            {
                mid = (lower + upper) / 2;

                if (arr[mid] == key)
                    return mid;

                if (arr[mid] > key)
                    upper = mid - 1;
                else
                    lower = mid + 1;

            }

            return -1;
        }
    }
}

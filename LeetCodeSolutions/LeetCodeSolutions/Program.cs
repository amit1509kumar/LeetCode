using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    class Program
    {
        static void Main(string[] args)
        {

            var obj = new SearchTwoDMatrix();
            int[,] matrix = new int[,] { { 1, 3, 5, 7 }, 
                                        { 10, 11, 16, 20},
                                        { 23, 30, 34, 50} };

           var val = obj.SearchMatrix(matrix, 51);



        }
    }
}

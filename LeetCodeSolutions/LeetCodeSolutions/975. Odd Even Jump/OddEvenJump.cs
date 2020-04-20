using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions._975._Odd_Even_Jump
{
    public class OddEvenJump
    {

    

        public int OddEvenJumps(int[] A)
        {
            int n = A.Length;
            bool[] odd = new bool[n];
            bool[] even = new bool[n];

            var odd_jump = new Dictionary<int,int>();
             var even_jump = new Dictionary<int,int>();

            odd[n - 1] = even[n - 1] = true;

            int ans = 1;

            int[][] sorted = new int[n][];

            for (int i = 0; i < n; i++)
            {
                sorted[i] = new int[2];
                sorted[i][0] = A[i];
                sorted[i][1] = i;
            }

           sorted = sorted.OrderBy(a => a[0]).ToArray();

         

            var stk = new Stack<int>();
            for(int i = 0; i < n; i++)
            {
                while (stk.Count > 0 && stk.Peek() < sorted[i][1])
                    odd_jump.Add(stk.Pop(), sorted[i][1]);

                stk.Push(sorted[i][1]);
            }

            stk.Clear();


            sorted = sorted.OrderBy(a => a[0]).ThenByDescending(b => b[1]).ToArray();

            for (int i = n - 1; i >= 0; i--)
            {
                while (stk.Count > 0 && stk.Peek() < sorted[i][1])
                    even_jump.Add(stk.Pop(), sorted[i][1]);

                stk.Push(sorted[i][1]);
            }

            //Console.WriteLine("even");

            //foreach (var a in even_jump)
            //    Console.WriteLine(a.Key + " " + a.Value);

            //Console.WriteLine("odd");

            //foreach (var a in odd_jump)
            //    Console.WriteLine(a.Key + " " + a.Value);


            for (int i = n-2; i >= 0; i--)
            {
                if(odd_jump.ContainsKey(i))        odd[i] = even[odd_jump[i]];

               if(even_jump.ContainsKey(i))   even[i] = odd[even_jump[i]];

                if (odd[i]) ans++;
            }

            return ans;




        }
    }
}

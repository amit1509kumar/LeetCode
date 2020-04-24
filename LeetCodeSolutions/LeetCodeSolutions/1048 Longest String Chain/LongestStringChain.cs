using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions._1048_Longest_String_Chain
{
    public class LongestStringChain
    {
       
        public int LongestStrChain(string[] words)
        {
            Array.Sort(words, (a,b) => a.Length - b.Length);

            var dict = new Dictionary<string, int>();
            int ans = 1;

            for (int i = 0; i < words.Length; i++)
            {
                int count = 1;

                for (int j = 0; j < words[i].Length; j++)
                {
                    var str = words[i].Remove(j, 1);

                    if (dict.ContainsKey(str))
                        count = Math.Max(count, dict[str] + 1);
                }

                ans = Math.Max(ans, count);

                if (!dict.ContainsKey(words[i]))
                    dict.Add(words[i], count);

            }

            return ans;

        }
    }
}

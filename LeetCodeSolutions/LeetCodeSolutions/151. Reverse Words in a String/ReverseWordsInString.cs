using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions._151._Reverse_Words_in_a_String
{
    public class ReverseWordsInString
    {
        public string ReverseWords(string s)
        {
            if (string.IsNullOrWhiteSpace(s)) return string.Empty;

            string[] st = s.Trim().Split(' ').Select(a => a.Trim()).ToArray();

            var result = string.Empty;

            //reverse words in array
            for (int i = 0, j = st.Length - 1; i < j; i++, j--)
            {
                var temp = st[i];
                st[i] = st[j];
                st[j] = temp;
            }

            //format string
            for (int k = 0; k < st.Length; k++)
            {
                if (string.IsNullOrEmpty(st[k])) continue;
                if (k < st.Length - 1)
                    result += st[k] + " ";
                else
                    result += st[k];
            }


            return result;

        }
    }
}

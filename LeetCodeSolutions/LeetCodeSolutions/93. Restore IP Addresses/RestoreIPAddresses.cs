using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class RestoreIPAddresses
    {
        public IList<string> RestoreIpAddresses(string s)
        {
            List<string> result = new List<string>();
            int len = s.Length;

            //brute force generate all possible combinations 
            for (int i = 1; i <= 3; i++)
            
                for (int j = 1; j <= 3; j++)

                    for (int k = 1; k <= 3; k++)

                        for (int l = 1; l <= 3; l++)

                            if (i + j + k + l == len)
                            {
                                int part1 = Convert.ToInt32(s.Substring(0, i));

                                int part2 = Convert.ToInt32(s.Substring(i, j));

                                int part3 = Convert.ToInt32(s.Substring(i + j, k));

                                int part4 = Convert.ToInt32(s.Substring(i + j + k, l));

                                if (part1 <= 255 && part2 <= 255 && part3 <= 255 && part4 <= 255)
                                {
                                    var ipAdd = $"{part1}.{part2}.{part3}.{part4}";
                                   
                                    if (result.Contains(ipAdd) || ipAdd.Length != len + 3) continue;
                                    result.Add(ipAdd);
                                }                                    
                            }

            return result;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions
{
    public class StudentAttendanceRecordI
    {
        public bool CheckRecord(string s)
        {

            int countA = 0;
            int countL = 0;

            for (int i = 0; i < s.Length; i++)
            {
                //count absents 'A'
                if (s[i] == 'A')
                    countA++;

                //count continuous late 'L' 
                if (s[i] == 'L')
                    countL++;
                else
                    countL = 0;

                //if student late more than 2 times return false
                if (countL > 2)
                    return false;
            }

            //Last condition to check if absent count exceed more than 1. 
            return countA < 2;

        }
    }
}

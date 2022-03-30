using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EdabitChallenges
{
    public class IterateString
    {
        public int HammingDistance(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
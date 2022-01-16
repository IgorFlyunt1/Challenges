using System.Collections.Generic;

namespace EdabitChallenges
{
    class IndexAllCapital
    {
        private static int[] IndexOfAllCapitalLetters(string str)
        {
            var result = new List<int>();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    result.Add(i);
                }
            }
            return result.ToArray();
        }
    }
}
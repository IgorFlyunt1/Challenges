using System.Collections.Generic;
using System.Linq;

namespace EdabitChallenges
{
    public class IndexAllCapital
    {
        public int[] IndexOfAllCapitalLetters(string str)
        {
            // var result = new List<int>();
            // for (int i = 0; i < str.Length; i++)
            // {
            //     if (char.IsUpper(str[i]))
            //     {
            //         result.Add(i);
            //     }
            // }
            // return result.ToArray();
            
            return str.Select((x, i) => char.IsUpper(x) ? i : -1).Where(x => x != -1).ToArray();
            
            return str.Select((x, i) => i).Where(i => char.IsUpper(str[i])).ToArray();
            
        }
    }
}
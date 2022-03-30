using System;
using System.Linq;
using System.Text;

namespace EdabitChallenges
{
    public class ShuffleString
    {
        public string NameShuffle(string str)
        {
            
            // string[] splitedStr = str.Split(" ");
            // StringBuilder suffledString = new StringBuilder();
            // suffledString.Append(splitedStr[1]);
            // suffledString.Append(" ");
            // suffledString.Append(splitedStr[0]);
            //
            // return suffledString.ToString();
            
            //or
            // string[] result = str.Split(' ');
            // return result[1] + " " + result[0];
            //or
            
            if (str == null) throw new ArgumentNullException(nameof(str));
            return string.Join(" ", str.Split(' ').Reverse());
        }
    }
}
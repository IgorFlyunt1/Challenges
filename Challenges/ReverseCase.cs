using System;
using System.Linq;
using System.Text;

namespace EdabitChallenges
{
    public class ReverseCase
    {
        public string ReverseCaseToUpperOrLower(string str)
        {
            var result = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    result.Append(str[i].ToString().ToLower());
                }
                else if (char.IsLower(str[i]))
                {
                    result.Append(str[i].ToString().ToUpper());
                }
                else
                {
                    result.Append(str[i].ToString());
                }
            }

            return result.ToString();
        }

        public string ReverseCaseToUpperOrLowerTwo(string str)
        {
            return new string(str.Select(s =>
                    char.IsUpper(s) ? char.ToLower(s) :
                    char.IsLower(s) ? char.ToUpper(s) : s)
                .ToArray());
        }
    }
}
using static System.Int32;

namespace EdabitChallenges
{
    public class SmallerNumber
    {
        public string ConvertStringToNumAndFindSmallerNum(string n1, string n2)
        {
            // int num1 = Convert.ToInt32(n1);
            // int num2 = Convert.ToInt32(n2);
            // return num1 < num2 ? n1 : n2;
            
            return Parse(n1) < Parse(n2) ? n1 : n2;
        }
    }
}
namespace EdabitChallenges
{
    public class Factorial
    {
        public int ReturnFactorial(int factorial)
        {
            int result = 1;
            for (int i = 1; i <= factorial; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
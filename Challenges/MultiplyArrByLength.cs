using System.Linq;

namespace EdabitChallenges
{
    public class MultiplyArrByLength
    {
        private readonly ArrayOfMultiples _arrayOfMultiples = new ArrayOfMultiples();

        public int[] MultiplyByLength(int[] arr)
        {
            // var length = arr.Length;
            // var result = new int[length];
            //
            // for (var i = 0; i < length; i++)
            // {
            //     result[i] = arr[i] * length;
            // }

            return arr.Select(x => x * arr.Length).ToArray();
        }
    }
}
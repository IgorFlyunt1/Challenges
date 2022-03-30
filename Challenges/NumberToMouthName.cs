using System.Globalization;

namespace EdabitChallenges
{
    public class NumberToMouthName
    {
        public string ConvertNumberToMonthName(int? num)
        {
            return num switch
            {
                1 => "January",
                2 => "February",
                3 => "March",
                4 => "April",
                5 => "May",
                6 => "June",
                7 => "July",
                8 => "August",
                9 => "September",
                10 => "October",
                11 => "November",
                12 => "December",
                _ => null
            };
        }
        
        public  string? ConvertNumberToMonthNameTwo(int num) => DateTimeFormatInfo.CurrentInfo != null
            ? DateTimeFormatInfo.CurrentInfo.GetMonthName(num)
            : null;
    }
}
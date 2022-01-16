using System;

namespace EdabitChallenges
{
    class CalcAgeToDay
    {
        public static int CalcAgeToDays(int age) 
        {
            return age * (DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365);
        }
    }
}
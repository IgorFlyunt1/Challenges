using System;

namespace EdabitChallenges
{
    public class CalcAgeToDay
    {
        public int CalcAgeToDays(int age) 
        {
            return age * (DateTime.IsLeapYear(DateTime.Now.Year) ? 366 : 365);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeCalculator
{
    public class AgeCalculator
    {
        public int GetAge(DateTime birthDate, DateTime targetDate)
        {
            var age = targetDate.Year - birthDate.Year;
            if(IsTargetDateBeforeBirthday(birthDate, targetDate))
                return age - 1;

            return age;
        }

        private bool IsTargetDateBeforeBirthday(DateTime birthDate, DateTime targetDate)
        {
            return targetDate.Month < birthDate.Month
                || (targetDate.Month == birthDate.Month && targetDate.Day < birthDate.Day) ;

        }
    }
}

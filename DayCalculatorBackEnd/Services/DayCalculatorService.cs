using DayCalculatorBackEnd.Models;

namespace DayCalculatorBackEnd.Services
{
    public class DayCalculatorService : IDayCalculatorService
    {
        public DayCalculatorService() { }
        public DateDiff CalcDiffDate(DateTime startDate, DateTime endDate)
        {
            var years = endDate.Year - startDate.Year;
            var months = endDate.Month - startDate.Month;
            var days = endDate.Day - startDate.Day;

            if (days < 0)
            {
                months--;
                days += DateTime.DaysInMonth(endDate.AddMonths(-1).Year, endDate.AddMonths(-1).Month);
            }

            if (months < 0)
            {
                years--;
                months += 12;
            }

            var totalDays = (endDate - startDate).TotalDays;
            var totalHours = (endDate - startDate).TotalHours;

            return new DateDiff
            {
                Years = years,
                Months = months,
                Days = (int)totalDays,
                Hours = (int)totalHours,
            };
        }
    }
}

using DayCalculatorBackEnd.Models;

namespace DayCalculatorBackEnd.Services
{
    public interface IDayCalculatorService
    {
        DateDiff CalcDiffDate(DateTime startDate, DateTime endDate);
    }
}

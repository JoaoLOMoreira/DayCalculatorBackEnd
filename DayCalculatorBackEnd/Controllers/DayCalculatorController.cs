using DayCalculatorBackEnd.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DayCalculatorBackEnd.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DayCalculatorController : Controller
    {
        private readonly IDayCalculatorService _dayCalculatorService;
        public DayCalculatorController(IDayCalculatorService dayCalculatorService)
        {
            _dayCalculatorService = dayCalculatorService;
        }

        [HttpGet]
        public IActionResult GetDiffDay(DateTime? startDate, DateTime? endDate)
        {
            if (!startDate.HasValue || !endDate.HasValue)
            {
                return BadRequest("As datas de início e fim devem ser fornecidas.");
            }

            if (startDate.Value > endDate.Value)
            {
                return BadRequest("A data de início deve ser anterior à data final.");
            }
            var difference = _dayCalculatorService.CalcDiffDate(startDate.Value, endDate.Value);
            return Ok(difference);


        }
    }

}

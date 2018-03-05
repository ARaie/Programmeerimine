using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Produces("application/json")]
    [Route("api/")]
    public class WeekController : Controller
    {
        // GET: api/Test
        [HttpGet("week")]
        public IActionResult Week()
        {
            PeriodAmount first = new PeriodAmount();
            first.Period = "01.01.2018-14.01.2018";
            first.Amount = "17";
            PeriodAmount second = new PeriodAmount();
            second.Period = "01.01.2016-14.01.2016";
            second.Amount = "28";

            List<PeriodAmount> data = new List<PeriodAmount>();
            data.Add(first);
            data.Add(second);

            return Json(data);
        }

    }
}

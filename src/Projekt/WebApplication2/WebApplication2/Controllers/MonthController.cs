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
    public class MonthController : Controller
    {
        // GET: api/Test
        [HttpGet("month")]
        public IActionResult Month()
        {
            PeriodAmount first = new PeriodAmount();
            first.Period = "jaanuar 2018";
            first.Amount = "7";
            PeriodAmount second = new PeriodAmount();
            second.Period = "veebruar 2018";
            second.Amount = "16";

            List<PeriodAmount> data = new List<PeriodAmount>();
            data.Add(first);
            data.Add(second);

            return Json(data);
        }

    }
}

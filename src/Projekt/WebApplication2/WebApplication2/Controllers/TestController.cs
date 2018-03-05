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
    public class TestController : Controller
    {
        // GET: api/Test
        [HttpGet("test")]
        public IActionResult Test(string grouping)
        {
            if (grouping == "day")
            {
                PeriodAmount first = new PeriodAmount();
                first.Period = "01.01.2018";
                first.Amount = "7";
                PeriodAmount second = new PeriodAmount();
                second.Period = "01.01.2016";
                second.Amount = "16";

                List<PeriodAmount> data = new List<PeriodAmount>();
                data.Add(first);
                data.Add(second);

                return Json(data);
            }
            else if (grouping == "week")
            {
                PeriodAmount first = new PeriodAmount();
                first.Period = "01.01.2018- 14.01.2018";
                first.Amount = "27";
                PeriodAmount second = new PeriodAmount();
                second.Period = "01.01.2016-14.01.2016";
                second.Amount = "36";

                List<PeriodAmount> data = new List<PeriodAmount>();
                data.Add(first);
                data.Add(second);

                return Json(data);
            }
            else{
                PeriodAmount first = new PeriodAmount();
                first.Period = "jaanuar 2018";
                first.Amount = "57";
                PeriodAmount second = new PeriodAmount();
                second.Period = "veebruar 2018";
                second.Amount = "66";

                List<PeriodAmount> data = new List<PeriodAmount>();
                data.Add(first);
                data.Add(second);

                return Json(data);
            } 

        }
        
    }
}

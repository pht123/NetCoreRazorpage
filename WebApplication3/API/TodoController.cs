using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.ViewModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication3.API
{
    [Produces("application/json")]
    [Route("api/Todo")]
    public class TodoController : Controller
    {
        [HttpPost]
        public IActionResult Get(string t1, string t2)
        {
            var s = ViewComponent("PriorityList", new { maxPriority = t1, isDone = t2 });
            return s;
        }
    }
}

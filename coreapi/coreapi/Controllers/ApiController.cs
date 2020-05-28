using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreapi.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class ApiController: Controller
    {
        [HttpGet]
        [Route("external")]
        [Authorize]
        public IActionResult Private()
        {
            return Json(new
            {
                msg = "Hello from a private endpoint! You need to be authenticated to see this."
            });
        }
    }
}

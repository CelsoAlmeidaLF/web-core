using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class HomeController : Controller
    {

        // IHttpActionResult

        /// <summary>
        /// Pagina inicial
        /// </summary>
        /// <returns></returns>
        [HttpGet("api")]
        public IActionResult Get ()
        {
            return Ok("Hello");
        }
    }
}
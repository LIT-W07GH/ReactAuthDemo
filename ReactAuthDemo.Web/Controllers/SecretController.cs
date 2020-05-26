using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ReactAuthDemo.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SecretController : ControllerBase
    {
        [HttpGet]
        [Route("random")]
        public object GetRandom()
        {
            var rnd = new Random();
            return new { number = rnd.Next(1, 100000) };
        }
    }
}
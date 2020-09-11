using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SOFOInvitation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MSOutlookGraphAuthController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(string validationToken) 
        {
            if (validationToken != null)
            {
                return Ok(validationToken);
            }

            return BadRequest();
        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult Post([FromBody] dynamic notification) 
        {
            return Ok();
        }
    }
}
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
    public class MailboxController : ControllerBase
    {
        // POST: api/Mailbox
        [HttpPost]
        public IActionResult Post(string validationtoken)
        {
            if (validationtoken != null)
            {
                return Ok(validationtoken);
            }

            return BadRequest();
        }

        [HttpPost]
        [Consumes("application/json")]
        public IActionResult Post([FromBody] Object request)
        {
            return Ok();
        }
    }
}
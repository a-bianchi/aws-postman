using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using aws_postman.Entities;
using SesMethods;

namespace aws_postman.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class SesController : ControllerBase
  {
    private readonly ILogger<SesController> _logger;

    public SesController(ILogger<SesController> logger)
    {
      _logger = logger;
    }

    // GET api/v1/ses/health-check
    [HttpGet]
    [Route("api/v1/[controller]/health-check")]
    public String Get()
    {
      return "Service Up!";
    }

    // POST api/v1/ses
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] Usermessage message)
    {
      MySesMethods ses = new MySesMethods();
      try
      {
        foreach (var dest in message.destination)
        {
          await ses.Postman(message.source, dest.email, ses.CastList(message.ccdestination), ses.CastList(message.bccdestination), message.subject, message.body);
        }
        return Ok(new { status = "Ok" });
      }
      catch (Exception ex)
      {
        return BadRequest(new
        {
          error = ex.Message
        });
      }
    }
  }
}
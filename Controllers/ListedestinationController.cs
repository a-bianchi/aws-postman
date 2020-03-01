using Microsoft.AspNetCore.Mvc;
using aws_postman.Contexts;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using aws_postman.Entities;

namespace aws_postman.Controllers
{
  [ApiController]
  [Route("api/v1/[controller]")]
  public class ListdestinationController : ControllerBase
  {
    private readonly ApplicationDbContext context;
    private readonly ILogger<ListdestinationController> _logger;
    public ListdestinationController(ApplicationDbContext context, ILogger<ListdestinationController> logger)
    {
      this.context = context;
      _logger = logger;
    }

    // GET api/v1/listdestination
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Listdestination>>> Get(int page = 1, int records = 10000)
    {
      var query = context.Listdestination.Include(x => x.destination).AsQueryable();

      var numberOfRecords = query.Count();

      var destinations = await query
          .Skip(records * (page - 1))
          .Take(records)
          .ToListAsync();

      Response.Headers["X-Total-Registros"] = numberOfRecords.ToString();
      Response.Headers["X-Cantidad-Paginas"] =
          ((int)Math.Ceiling((double)numberOfRecords / records)).ToString();

      return destinations;
    }

    // GET api/listdestination/5 
    [HttpGet("{id}")]
    public async Task<ActionResult<Listdestination>> Get(int id)
    {
      var autor = await context.Listdestination.FirstOrDefaultAsync(x => x.Id == id);

      if (autor == null)
      {
        return NotFound();
      }

      return autor;
    }

    // Post api/listdestination
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] Listdestination destinations)
    {
      context.Add(destinations);
      await context.SaveChangesAsync();
      return Ok(destinations);
    }

    // Put api/listdestination/5 
    [HttpPut("{id}")]
    public async Task<ActionResult> Put(int id, [FromBody] Listdestination destinations)
    {
      destinations.Id = id;
      context.Entry(destinations).State = EntityState.Modified;

      foreach (var dest in destinations.destination)
      {
        context.Entry(dest).State = EntityState.Modified;
      }

      await context.SaveChangesAsync();
      return NoContent();
    }

    // Delete api/listdestination/5 
    [HttpDelete("{id}")]
    public async Task<ActionResult<Listdestination>> Delete(int id)
    {
      var destinationId = await context.Listdestination.Select(x => x.Id).FirstOrDefaultAsync(x => x == id);

      if (destinationId == default(int))
      {
        return NotFound();
      }

      context.Remove(new Listdestination { Id = destinationId });
      await context.SaveChangesAsync();
      return NoContent();
    }

  }
}
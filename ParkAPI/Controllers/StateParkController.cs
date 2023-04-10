using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class StateParkController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public StateParkController(ParkApiContext db)
    {
      _db = db;
    }

    // GET api/StatePark
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StatePark>>> Get(string StateParkName)
    {
      List<StatePark> stateParks = _db.StatePark
        .Where(entry => entry.StateParkName == StateParkName)
        .ToList();
        return stateParks; 
    }

    // GET: api/StatePark/5
    [HttpGet("{id}")]
    public async Task<ActionResult<StatePark>> GetStatePark(int id)
    {
      StatePark statepark = await _db.StatePark.FindAsync(id);

      if (statepark == null)
      {
        return NotFound();
      }

      return statepark;
    }

     // POST api/StatePark
    [HttpPost]
    public async Task<ActionResult<StatePark>> Post(StatePark statepark)
    {
      _db.StatePark.Add(statepark);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetStatePark), new { id = statepark.StateParkId }, statepark);
    }

     // PUT: api/StatePark/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, StatePark statepark)
    {
      if (id != statepark.StateParkId)
      {
        return BadRequest();
      }

      _db.StatePark.Update(statepark);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StateParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    private bool StateParkExists(int id)
    {
      return _db.StatePark.Any(e => e.StateParkId == id);
    }

     // DELETE: api/StatePark/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStatePark(int id)
    {
      StatePark statepark = await _db.StatePark.FindAsync(id);
      if (statepark == null)
      {
        return NotFound();
      }

      _db.StatePark.Remove(statepark);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
  
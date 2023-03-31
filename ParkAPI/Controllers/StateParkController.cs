using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class StateParkController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public StateParkController(ParkApiContext db)
    {
      _db = db;
    }

    // GET api/StatePark
    [HttpGet]
    public async Task<ActionResult<IEnumerable<StatePark>>> Get()
    {
      return await _db.StatePark.ToListAsync();
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
  }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class NationalParkController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public NationalParkController(ParkApiContext db)
    {
      _db = db;
    }

    // GET api/NationalPark
    [HttpGet]
    public async Task<ActionResult<IEnumerable<NationalPark>>> Get()
    {
      return await _db.NationalPark.ToListAsync();
    }

    // GET: api/NationalPark/5
    [HttpGet("{id}")]
    public async Task<ActionResult<NationalPark>> GetNationalPark(int id)
    {
      NationalPark nationalpark = await _db.NationalPark.FindAsync(id);

      if (nationalpark == null)
      {
        return NotFound();
      }

      return nationalpark;
    }

     // POST api/NationalPark
    [HttpPost]
    public async Task<ActionResult<NationalPark>> Post(NationalPark nationalpark)
    {
      _db.NationalPark.Add(nationalpark);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetNationalPark), new { id = nationalpark.NationalParkId }, nationalpark);
    }
    
  }
}

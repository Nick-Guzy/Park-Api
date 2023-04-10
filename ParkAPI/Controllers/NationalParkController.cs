using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParkApi.Models;
using Microsoft.AspNetCore.Authorization;

namespace ParkApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  [Authorize]
  public class NationalParkController : ControllerBase
  {
    private readonly ParkApiContext _db;

    public NationalParkController(ParkApiContext db)
    {
      _db = db;
    }


    // GET api/NationalPark
    [HttpGet]
    public async Task<ActionResult<IEnumerable<NationalPark>>> Get(string NationalParkName)
    {
        List<NationalPark> nationalParks = _db.NationalPark
        .Where(entry => entry.NationalParkName == NationalParkName)
        .ToList();
        return nationalParks;           
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

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, NationalPark nationalPark)
        {
            if (id != nationalPark.NationalParkId)
            {
                return BadRequest();
            }

            _db.NationalPark.Update(nationalPark);

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NationalParkExists(id))
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

        private bool NationalParkExists(int id)
        {
            return _db.NationalPark.Any(e => e.NationalParkId == id);
        }

        // DELETE: api/NationalPark/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNationalPark(int id)
        {
            NationalPark nationalPark = await _db.NationalPark.FindAsync(id);
            if (nationalPark == null)
            {
                return NotFound();
            }

            _db.NationalPark.Remove(nationalPark);
            await _db.SaveChangesAsync();

            return NoContent();
        }
    
  }
}

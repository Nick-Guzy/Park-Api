using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkApi;

public class NationalPark
{
    public int NationalParkId { get; set; }
    [ForeignKey("StatePark")]
    public string NationalParkName { get; set; }
    public string NationalParkLocation { get; set; }
}

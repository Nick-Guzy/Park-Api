using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace ParkApi.Models
{
  public class StatePark
  {
    public int StateParkId { get; set; }
    public string StateParkName { get; set; }
    public string StateParkLocation { get; set; }
  }
}
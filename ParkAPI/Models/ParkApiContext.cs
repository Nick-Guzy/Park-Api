using Microsoft.EntityFrameworkCore;

namespace ParkApi.Models
{
  public class ParkApiContext : DbContext
  {
    public DbSet<StatePark> StateParks { get; set; }
    public DbSet<NationalPark> NationalParks { get; set; }

    public ParkApiContext(DbContextOptions<ParkApiContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<StatePark>()
        .HasData(
          new StatePark { StateParkId = 1,  StateParkLocation = "State1", StateParkName = "State Name1" },
          new StatePark { StateParkId = 2,  StateParkLocation = "State2", StateParkName = "State Name2" },
          new StatePark { StateParkId = 3,  StateParkLocation = "State3", StateParkName = "State Name3" },
          new StatePark { StateParkId = 4,  StateParkLocation = "State4", StateParkName = "State Name4" },
          new StatePark { StateParkId = 5,  StateParkLocation = "State5", StateParkName = "State Name5" }
        );
    }
     protected override void OnModelCreating(ModelBuilder builder)
     {
      builder.Entity<NationalPark>()
        .HasData(
          new NationalPark { NationalParkId = 1, NationalParkLocation = "National1", NationalParkName = "National Name1"},
          new NationalPark { NationalParkId = 2, NationalParkLocation = "National2", NationalParkName = "National Name2"},
          new NationalPark { NationalParkId = 3, NationalParkLocation = "National3", NationalParkName = "National Name3"},
          new NationalPark { NationalParkId = 4, NationalParkLocation = "National4", NationalParkName = "National Name4"},
          new NationalPark { NationalParkId = 5, NationalParkLocation = "National5", NationalParkName = "National Name5"}
        );
     }
  }
}
using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class HairSalonContext : DbContext // inherits/extends from Entity's DbContext for built in functionality
  {
    public virtual DbSet<Stylist> Stylists { get; set; }
    public virtual DbSet<Review> Reviews { get; set; }
    public DbSet<Client> Clients { get; set; } // needs to know which C# object it's going to represent

    public HairSalonContext(DbContextOptions options) : base(options) { } // using Startup.cs options via "dependency injection"
  }
}
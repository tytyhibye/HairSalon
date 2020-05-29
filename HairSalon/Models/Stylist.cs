using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>(); // Hashset is an unordered collection of unique elements (more performant than a List but doesnt allow duplicates)
      this.Reviews = new HashSet<Review>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<Client> Clients { get; set; } // generic interface - collection of method signatures bundled together.
                                                                     // ICollection required by Entity to outline methods for querying and changing data.
  }
  public enum StylistName
  {
    Claire,
    Moriah,
    Juanito,
    Karen,
    DreadlockDolores
  }
}
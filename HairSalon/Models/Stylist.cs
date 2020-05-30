using System.Collections.Generic;


namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
      this.Reviews = new HashSet<Review>();
    }

    public int StylistId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public virtual ICollection<Review> Reviews { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
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
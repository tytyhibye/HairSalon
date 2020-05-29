using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Client
  {
    public Client()
    {
      this.Reviews = new HashSet<Review>();
    }
    public int ClientId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
    public virtual ICollection<Review> Reviews {get;set;}
  }

}
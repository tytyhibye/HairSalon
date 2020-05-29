using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace HairSalon.Models
{
  public class Review
  {
    public int ReviewId { get; set; }
    public string Description { get; set; }
    public int Rating { get; set; }
    public int StylistId { get; set; }
   
   public virtual Stylist Stylist {get;set;}
  }
}
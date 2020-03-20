using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
    {
        public Category()
        {
            this.Clients = new HashSet<Client>();
        }

        public int StylistId { get; set; }
        public string StylistName { get; set; }
        public string StylistSpecialty { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}
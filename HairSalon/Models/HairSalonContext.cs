using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Stylists> Stylists { get; set; }
    public DbSet<Clients> Clients { get; set; }
    
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
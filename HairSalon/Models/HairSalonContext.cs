using Microsoft.EntityFrameworkCore;

namespace HairSalon.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Category> Stylist { get; set; }
    public DbSet<Item> Client { get; set; }
    
    public ToDoListContext(DbContextOptions options) : base(options) { }
  }
}
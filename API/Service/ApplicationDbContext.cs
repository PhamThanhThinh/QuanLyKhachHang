using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Service
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
  }
}

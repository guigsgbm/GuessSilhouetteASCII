using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;

public class GsaDbContext : DbContext
{
    public GsaDbContext(DbContextOptions<GsaDbContext> options) : base(options)
    {
    }

    public DbSet<Character> Characters { get; set; }
}

using Microsoft.EntityFrameworkCore;
using too.Core.Domain;



namespace too.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        public DbSet<Kunstiteosed> Kunstiteosed { get; set; }
        public DbSet<Kunstityyp> Kunstityyp { get; set; }
        public DbSet<Kunstnik> Kunstnik { get; set; }
        public DbSet<KunstiOmanik> KunstiOmanik { get; set; }
    }
}

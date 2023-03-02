using Microsoft.EntityFrameworkCore;

namespace MoneyLender
{
    public class GuyContext : DbContext
    {
        public DbSet<Guy> Guys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=TROYPC;Database=MoneyLender;Integrated Security=SSPI;TrustServerCertificate=True;");
        }
    }
}

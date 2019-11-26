using Microsoft.EntityFrameworkCore;

namespace RCJaxWeb.Models
{
    public class RcJaxWebContext : DbContext
    {
        public RcJaxWebContext(DbContextOptions<RcJaxWebContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresss { get; set; }
        public DbSet<Afire> Afire { get; set; }
        public DbSet<AfireType> AfireType { get; set; }
        public DbSet<Content> Content { get; set; }
        public DbSet<ContentType> ContentType { get; set; }
        public DbSet<EncounterMaterial> EncounterMaterial { get; set; }
        public DbSet<Phone> Phone { get; set; }
        public DbSet<User> User { get; set; }
    }
}
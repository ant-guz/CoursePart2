using Microsoft.EntityFrameworkCore;
namespace HW.Additional.Model

{
    public class MyAppContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //  base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=TestDB;Trusted_Connection=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //    modelBuilder.Entity<Car>(et =>
            //    { 
            //        et.Property(e => e.Name).HasMaxLength(50);
            //    });

            //    modelBuilder.Entity<Owner>(et => 
            //    {

            //    });
            //    modelBuilder.Entity<Seller>(et => { });
        }
    }
}

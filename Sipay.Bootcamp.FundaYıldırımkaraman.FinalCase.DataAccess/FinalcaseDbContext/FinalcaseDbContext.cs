using Microsoft.EntityFrameworkCore;
using Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.Entity;

namespace Sipay.Bootcamp.FundaYıldırımkaraman.FinalCase.DataAccess.FinalcaseDbContext
{
    public class FinalcaseDbContext:DbContext
    {
        public FinalcaseDbContext(DbContextOptions<FinalcaseDbContext> options) : base(options)
        {
        }

        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Apartment>()
                .HasMany(a => a.Bills) 
                .WithOne(b => b.Apartment) 
                .HasForeignKey(b => b.ApartmentId); 

            modelBuilder.Entity<User>()
                .HasMany(u => u.Bills) 
                .WithOne(b => b.User) 
                .HasForeignKey(b => b.UserId); 

            modelBuilder.Entity<User>()
                .HasMany(u => u.Messages) 
                .WithOne(m => m.User) 
                .HasForeignKey(m => m.UserId);

            base.OnModelCreating(modelBuilder);
        }
    }
}

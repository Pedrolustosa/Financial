using Entities.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Infrastructure.Configuration
{
    public class ContextBase : IdentityDbContext<ApplicationUser>
    {
        public ContextBase(DbContextOptions options) : base(options){ }

        public DbSet<FinancialSystem> FinancialSystem { get; set; }
        public DbSet<UserFinancialSystem> UserFinancialSystem { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Dispense> Dispense { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
                base.OnConfiguring(optionsBuilder);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>().ToTable("AspNetUsers").HasKey(c => c.Id);

            base.OnModelCreating(builder);
        }

        public static string GetConnectionString()
        {
            return "Data Source=LAPTOP-3D5G6G45;Initial Catalog=FinancialDB;Integrated Security=true;";
        }
    }
}
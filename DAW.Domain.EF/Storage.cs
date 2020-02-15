using DAW.Domain.EF.ModelConfigurations;
using DAW.Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DAW.Domain.EF
{
    public class Storage : IdentityDbContext<IdentityUser>
    {
        public Storage(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerEntityConfiguration());
            modelBuilder.ApplyConfiguration(new ItemEntityConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Item> Items { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Depozit> Depozite { get; set; }
        public DbSet<Comanda> Comenzi { get; set; }
    }
}
using Microsoft.EntityFrameworkCore;
using AutocountCRM_ProjectOne.Models;

namespace AutocountCRM_ProjectOne.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<QT> QT { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Debtor> Debtor { get; set; }
        public DbSet<UsersLogin> UsersLogin { get; set; }
        public DbSet<leads_list> leads_list { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Map Inventory class to the SQL table "Item"
            modelBuilder.Entity<Inventory>().ToTable("Item");
        }
    }
}

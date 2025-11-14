using Microsoft.EntityFrameworkCore;
using AutocountCRM_ProjectOne.Models;

namespace AutocountCRM_ProjectOne.Data
{
    public class CRMContext : DbContext
    {
        public CRMContext(DbContextOptions<CRMContext> options) : base(options) { }

        public DbSet<Users> Users { get; set; }
        public DbSet<quotation_list> quotation_list { get; set; }
        public DbSet<quotation_items> quotation_items { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<UsersLogin> UsersLogin { get; set; }
        public DbSet<leads_list> leads_list { get; set; }
        
    }
}

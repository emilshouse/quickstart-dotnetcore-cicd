using System.Reflection;
using Earnventory.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Earnventory.Domain.Context
{

    public class ApplicationDbContext : DbContext
    {
        /*public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<ForgotPassword> ForgotPasswords { get; set; }
        public DbSet<LoginLog> LoginLogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Make> Makes { get; set; }
        public DbSet<Smelter> Smelters { get; set; }
        public DbSet<Tier> Tiers { get; set; }
        public DbSet<Metal> Metals { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        
        public DbSet<UserSupplier> UserSuppliers { get; set; }
        public DbSet<CatalyticConverter> CatalyticConverters { get; set; }

        public DbSet<BuySheetItem> BuySheetItems { get; set; }
        public DbSet<BuySheet> BuySheets { get; set; }*/
        public DbSet<User> Users { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }

 }

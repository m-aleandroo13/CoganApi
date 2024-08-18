using CoganApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CoganApi.DBSettings
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Items> Items { get; set; }
        public DbSet<UserManagement> UserManagement { get; set; }
        public DbSet<UserAudit> UserAudit { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Mapping entities to their respective tables
            modelBuilder.Entity<UserManagement>().ToTable("users");
            modelBuilder.Entity<UserAudit>().ToTable("useraudit");

            // Defining the foreign key relationship
            modelBuilder.Entity<UserAudit>()
                .HasOne<UserManagement>(ua => ua.UserManagement)
                .WithMany(um => um.UserAudits)
                .HasForeignKey(ua => ua.Id_User)
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}

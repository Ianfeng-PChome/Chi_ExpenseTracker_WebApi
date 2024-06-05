using Chi_ExpenseTracker_Repesitory.Configuration;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.EntityFrameworkCore;

namespace Chi_ExpenseTracker_Repesitory.Models
{
    public partial class _ExpenseDbContext : DbContext
    {
        public _ExpenseDbContext() 
        {
        }
        
        public _ExpenseDbContext(DbContextOptions<_ExpenseDbContext> options)
    : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(AppSettings.Connectionstrings?.Company);
                optionsBuilder.UseSqlServer("Server=pchome24887\\SQLEXPRESS;Database=Chi.Expense;Trusted_Connection=True;TrustServerCertificate=true;");
            }
        }

        public virtual DbSet<UserEntity> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.CreateDate).HasColumnType("datetime").HasDefaultValueSql(" GETDATE()");
                entity.Property(e => e.Password)
                    .HasMaxLength(48)
                    .IsUnicode(false);
                entity.Property(e => e.RefreshToken).HasMaxLength(1024);
                entity.Property(e => e.Role)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.UserName).HasMaxLength(88);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

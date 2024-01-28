using AccessManagement.API.User.Infrustructure.Entites;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet برای جدول User
    public DbSet<UserEntity> Users { get; set; }

    // DbSet برای جدول Address
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<PermissionEntity> Permissions { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // تعریف روابط بین جداول اگر لازم باشد
        // modelBuilder.Entity<UserEntity>()
        //     .HasOne(a => a.Addresses)
        //     .WithMany(u => u)
        //     .HasForeignKey(a => a.UserId)
        //     .OnDelete(DeleteBehavior.Cascade);

        // می‌توانید سایر تنظیمات مورد نیاز را نیز اضافه کنید
    }
}
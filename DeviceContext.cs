using ArktiPhonesDatabaseUploader.Models;
using Microsoft.EntityFrameworkCore;

public class DeviceContext : DbContext {
    // public DeviceContext (DbContextOptions<DeviceContext> options) : base (options) { }

    public DbSet<DeviceDetail> DeviceDetails { get; set; }

    public DbSet<Basic> Basics { get; set; }
    public DbSet<Status> Status { get; set; }
    public DbSet<Battery> Batteries { get; set; }
    public DbSet<Display> Displays { get; set; }
    public DbSet<Communication> Communications { get; set; }
    public DbSet<Build> Builds { get; set; }
    public DbSet<CameraInfo> CameraInfos { get; set; }
    public DbSet<Memory> Memories { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<OperatingSystem> OperatingSystems { get; set; }
    public DbSet<Cpu> Cpus { get; set; }
    public DbSet<Gpu> Gpus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        optionsBuilder.UseSqlServer(
            @"server=localhost;database=TESTING;User ID=sa;password=Qwertyui0;");
    }
    // protected override void OnModelCreating(ModelBuilder modelBuilder) {
        // modelBuilder.Entity<Status>()
        //     .HasOne(x => x.AnnouncedDate)
        //     .WithOne(x => x.AnnouncedStatus);
        // modelBuilder.Entity<Status>()
        //     .HasOne(x => x.ReleasedDate)
        //     .WithOne(x => x.ReleasedStatus);
            // modelBuilder.Entity<Date>().
        // modelBuilder.Entity<CameraInfo> ()
        //     .HasMany (x => x.RearCameraFeatures)
        //     .WithOne (x => x.CameraInfo)
        //     .HasForeignKey (x => x.CameraInfoID);
        // base.OnModelCreating (modelBuilder);
        // modelBuilder.Entity<CameraInfo> ()
        //     .HasMany (x => x.FrontCameraFeatures)
        //     .WithOne (x => x.CameraInfo)
        //     .HasForeignKey (x => x.CameraInfoID);
        // base.OnModelCreating (modelBuilder);
    // }
}

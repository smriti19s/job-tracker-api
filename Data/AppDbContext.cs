using JOB_Tracker.API.Models;
using Microsoft.EntityFrameworkCore;

namespace JOB_Tracker.API.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Note> Notes { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Default schema
            modelBuilder.HasDefaultSchema("jobtracker");

            // Relationships

            modelBuilder.Entity<Job>()
                .HasOne(j => j.User)
                .WithMany(u => u.Jobs)
                .HasForeignKey(j => j.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Note>()
                .HasOne(n => n.Job)
                .WithMany(j => j.Notes)
                .HasForeignKey(n => n.JobId)
                .OnDelete(DeleteBehavior.Cascade);

            // Unique Email
            modelBuilder.Entity<User>()
                .HasIndex(u => u.Email)
                .IsUnique();

        }
    }
}

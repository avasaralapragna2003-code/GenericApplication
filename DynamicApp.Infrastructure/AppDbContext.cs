using DynamicApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace DynamicApp.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Application> Applications { get; set; }
        public DbSet<Flow> Flows { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<EnumValue> EnumValues { get; set; }
        public DbSet<UserSubmission> UserSubmissions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships if needed, although EF conventions usually handle them
            modelBuilder.Entity<Application>().HasKey(a => a.ApplicationId);
            modelBuilder.Entity<Flow>().HasKey(f => f.FlowId);
            modelBuilder.Entity<Page>().HasKey(p => p.PageId);
            modelBuilder.Entity<Section>().HasKey(s => s.SectionId);
            modelBuilder.Entity<Field>().HasKey(f => f.FieldId);
            modelBuilder.Entity<EnumValue>().HasKey(e => e.EnumValueId);
            modelBuilder.Entity<UserSubmission>().HasKey(u => u.SubmissionId);
            modelBuilder.Entity<User>().HasKey(u => u.UserId);
        }
    }
}

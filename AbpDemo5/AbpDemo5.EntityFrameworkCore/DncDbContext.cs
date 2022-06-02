using Microsoft.EntityFrameworkCore;
using AbpDemo5.Domain.File;
using Volo.Abp.EntityFrameworkCore;
using AbpDemo5.Domain;

namespace AbpDemo5.EntityFrameworkCore
{
    [ConnectionString]
    public class AbpDemoDbContext : AbpDbContext<AbpDemoDbContext>
    {
        public AbpDemoDbContext(DbContextOptions<AbpDemoDbContext> options) : base(options)
        {
        }

        #region DbSet


        public DbSet<Category> Categories { get; set; }

        #endregion DbSet

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configure();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.EnableSensitiveDataLogging();
        }
    }
}
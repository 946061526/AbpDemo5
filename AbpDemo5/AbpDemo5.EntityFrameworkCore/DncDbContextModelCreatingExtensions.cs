using Microsoft.EntityFrameworkCore;
using AbpDemo5.Domain.File;
using AbpDemo5.Domain.Shared;
using Volo.Abp;
using static AbpDemo5.Domain.Shared.AbpDemoDbConsts;
using AbpDemo5.Domain;

namespace AbpDemo5.EntityFrameworkCore
{
    public static class AbpDemoDbContextModelCreatingExtensions
    {
        public static void Configure(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Category>(b =>
            {
                b.ToTable(AbpDemoConsts.DbTablePrefix + DbTableName.Categories);
                b.HasKey(x => x.Id);
                b.Property(x => x.CategoryName).HasMaxLength(50).IsRequired();
                b.Property(x => x.DisplayName).HasMaxLength(50).IsRequired();
            });
        }
    }
}
using AbpDemo5.Domain;
using AbpDemo5.Domain.File;
using AbpDemo5.Domain.File.Repositories;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemo5.EntityFrameworkCore.Repositories.File
{
    /// <summary>
    /// CategoryRepository
    /// </summary>
    public class CategoryRepository : EfCoreRepository<AbpDemoDbContext, Category, int>, ICategoryRepository
    {
        public CategoryRepository(IDbContextProvider<AbpDemoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}
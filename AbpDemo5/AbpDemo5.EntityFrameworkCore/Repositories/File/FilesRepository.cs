using AbpDemo5.Domain;
using AbpDemo5.Domain.File;
using AbpDemo5.Domain.File.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace AbpDemo5.EntityFrameworkCore.Repositories.File
{
    public class FilesRepository : EfCoreRepository<AbpDemoDbContext, FilesInfo, string>, IFilesRepository
    {
        public FilesRepository(IDbContextProvider<AbpDemoDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}

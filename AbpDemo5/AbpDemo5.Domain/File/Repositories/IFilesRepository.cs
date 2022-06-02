using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace AbpDemo5.Domain.File.Repositories
{
    public interface IFilesRepository : IRepository<FilesInfo, string>
    {

    }
}

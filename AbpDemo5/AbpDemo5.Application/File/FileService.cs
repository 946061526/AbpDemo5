using AbpDemo5.Application.Contracts.File;
using AbpDemo5.Application.Contracts.File.InputParams;
using AbpDemo5.Tools.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemo5.Application.File
{
    public class FileService : ServiceBase, IFileService
    {
        public async Task<ApiResult> AddSync(AddFileInput input)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult> DeleteSync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult> EditSync(EditFileInput input)
        {
            throw new NotImplementedException();
        }

        public async Task<ApiResult<PagedList<FilesDto>>> QuerySync(QueryFileInput input)
        {
            throw new NotImplementedException();
        }
    }
}

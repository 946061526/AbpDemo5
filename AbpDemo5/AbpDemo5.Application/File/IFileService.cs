using AbpDemo5.Application.Contracts.File.InputParams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbpDemo5.Tools.Base;
using AbpDemo5.Application.Contracts.File;

namespace AbpDemo5.Application.File
{
    public interface IFileService
    {
        Task<ApiResult> AddSync(AddFileInput input);

        Task<ApiResult> DeleteSync(string id);

        Task<ApiResult> EditSync(EditFileInput input);

        Task<ApiResult<PagedList<FilesDto>>> QuerySync(QueryFileInput input);
    }
}

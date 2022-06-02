using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbpDemo5.Application.Contracts.File
{
    /// <summary>
    /// 文件信息
    /// </summary>
    public class FilesDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public string Md5 { get; set; }
        public int Status = 0;
        public int CategoryId { get; set; }
        public string Description { get; set; }
    }

    /// <summary>
    /// 文件详情
    /// </summary>
    public class FilesDetailsDto : FilesDto
    {
        public string CategoryName { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string TenantId { get; set; }
        public string OrgId { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}

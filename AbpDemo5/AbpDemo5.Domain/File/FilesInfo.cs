using AbpDemo5.Domain.Shared;
using System;
using Volo.Abp.Domain.Entities;

namespace AbpDemo5.Domain
{
    public class FilesInfo : Entity<string>, IBaseEntity
    {
        public string Name { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public string Md5 { get; set; }
        public int Status = 0;
        public int CategoryId { get; set; }
        public string Description { get; set; }
        public string CreatorId { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string TenantId { get; set; }
        public string OrgId { get; set; }
        public DateTime? LastModifiedTime { get; set; }
    }
}

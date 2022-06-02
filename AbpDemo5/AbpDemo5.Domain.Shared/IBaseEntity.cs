using System;

namespace AbpDemo5.Domain.Shared
{
    public interface IBaseEntity
    {
        /// <summary>
        /// 租户ID
        /// </summary>
        string TenantId { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        string OrgId { get; set; }

        /// <summary>
        /// 创建人ID
        /// </summary>
        string CreatorId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        DateTime CreationTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        DateTime? LastModifiedTime { get; set; }
    }
}

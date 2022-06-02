namespace AbpDemo5.Application.Contracts
{
    /// <summary>
    /// 入参基类
    /// </summary>
    public class IBaseInput
    {
        /// <summary>
        /// 租户ID
        /// </summary>
        public string TenantId { get; set; }

        /// <summary>
        /// 组织ID
        /// </summary>
        public string OrgId { get; set; }
    }
}

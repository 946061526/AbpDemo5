using AbpDemo5.Domain.Configurations;
using Volo.Abp.Data;

namespace AbpDemo5.EntityFrameworkCore
{
    public class ConnectionStringAttribute : ConnectionStringNameAttribute
    {
        private static readonly string db = AppSettings.EnableDb;

        public ConnectionStringAttribute(string name = "") : base(db)
        {
            Name = string.IsNullOrEmpty(name) ? db : name;
        }

        public new string Name { get; }
    }
}
using IdentityService.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Configurations
{
    public class AppRoleConfiguration:BaseConfiguration<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {
            base.Configure(builder);
            builder.Ignore(x=>x.ID);
            builder.HasMany(x=>x.UserRoles).WithOne(x=>x.AppRole).HasForeignKey(x=>x.RoleId).IsRequired();
            
        }
    }
}

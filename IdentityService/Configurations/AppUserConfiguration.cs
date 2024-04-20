using IdentityService.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityService.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasMany(x => x.UserRoles).WithOne(x => x.AppUser).HasForeignKey(x => x.UserId).IsRequired();
        }
    }
}

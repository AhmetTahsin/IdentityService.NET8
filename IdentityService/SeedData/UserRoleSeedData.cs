using IdentityService.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace IdentityService.SeedData
{
    public static class UserRoleSeedData
    {
        public static void SeedUserAdmin(ModelBuilder model)
        {
            AppRole appRole = new()
            {
                Id = 1,
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            model.Entity<AppRole>().HasData(appRole);

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            AppUser user = new()
            {
                Id = 1,
                UserName = "admin",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                NormalizedUserName = "ADMIN",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "Admin123.")
            };
            model.Entity<AppUser>().HasData(user);

            model.Entity<AppUserRole>().HasData(new AppUserRole
            {
                RoleId = appRole.Id,
                UserId = user.Id
            });

        }

        public static void SeedUserMember(ModelBuilder model)
        {
            AppRole appRole = new()
            {
                Id = 2,
                Name = "Member",
                NormalizedName = "MEMBER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };

            model.Entity<AppRole>().HasData(appRole);

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            AppUser user = new()
            {
                Id = 2,
                UserName = "member",
                Email = "member@gmail.com",
                NormalizedEmail = "MEMBER@GMAIL.COM",
                NormalizedUserName = "MEMBER",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = passwordHasher.HashPassword(null, "Member123.")
            };
            model.Entity<AppUser>().HasData(user);

            model.Entity<AppUserRole>().HasData(new AppUserRole
            {
                RoleId = appRole.Id,
                UserId = user.Id
            });

        }
    }
}

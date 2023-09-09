using Common.Constants;
using Common.Enums;
using Infrastructure.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Seeder
{
    public static class Seeder
    {
        public static ModelBuilder SeedDatabase(this ModelBuilder modelBuilder)
        {
            modelBuilder
                .SeedApplicationUserStatus()
                .SeedApplicationRole()
                .SeedApplicationUser()
                .SeedUserRoles();
            return modelBuilder;
        }
        private static ModelBuilder SeedApplicationRole(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationRole>().HasData(
            new ApplicationRole
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Id = "2c3f95f4-eae4-41a5-a664-9a530220a242",
                Name = UserRoles.Admin,
                NormalizedName = UserRoles.Admin.ToUpper()
            },
            new ApplicationRole
            {
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                Id = "2b6e4939-5179-4032-a74c-196861caa4e3",
                Name = UserRoles.Customer,
                NormalizedName = UserRoles.Customer.ToUpper()
            }
            );
            return modelBuilder;
        }
        private static ModelBuilder SeedApplicationUser(this ModelBuilder modelBuilder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            var admin = new ApplicationUser
            {
                Id = "c15c9f32-2b04-4af7-990b-e68e6c088dca",
                Email = "Admin@Adtechsolutions.com",
                NormalizedEmail = "ADMIN@ADTECHSOLUTIONS.COM",
                UserName = "Admin@Adtech-solutions",
                NormalizedUserName = "ADMIN@ADTECHSOLUTIONS",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                PhoneNumber = "+923302476840",
                PhoneNumberConfirmed = true,
            };
            admin.PasswordHash = hasher.HashPassword(admin, "Admin@112233");
            modelBuilder.Entity<ApplicationUser>().HasData(admin);

            var secondaryAdmin = new ApplicationUser
            {
                Id = "e4bb8436-1808-4567-82ee-d690fff6739f",
                Email = "fahad5805@gmail.com",
                NormalizedEmail = "FAHAD5805@GMAIL.COM",
                UserName = "fahad5805@gmail",
                NormalizedUserName = "FAHAD5805@GMAIL",
                ConcurrencyStamp = Guid.NewGuid().ToString(),
                EmailConfirmed = true,
                PhoneNumber = "+923052351635",
                PhoneNumberConfirmed = true,
            };
            admin.PasswordHash = hasher.HashPassword(secondaryAdmin, "Admin@112233");
            modelBuilder.Entity<ApplicationUser>().HasData(secondaryAdmin);
            return modelBuilder;
        }
        private static ModelBuilder SeedUserRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUserRoles>().HasData(new ApplicationUserRoles
            {
                RoleId = "2c3f95f4-eae4-41a5-a664-9a530220a242",
                UserId = "c15c9f32-2b04-4af7-990b-e68e6c088dca"
            });
            modelBuilder.Entity<ApplicationUserRoles>().HasData(new ApplicationUserRoles
            {
                RoleId = "2c3f95f4-eae4-41a5-a664-9a530220a242",
                UserId = "e4bb8436-1808-4567-82ee-d690fff6739f"
            });
            return modelBuilder;
        }

        private static ModelBuilder SeedApplicationUserStatus(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUserStatus>().HasData(new ApplicationUserStatus
            {
                Id = (int)UserStatus.Pending,
                Status = "Pending",
            },
            new ApplicationUserStatus
            {
                Id = (int)UserStatus.Approved,
                Status = "Approved",
            },
            new ApplicationUserStatus
            {
                Id = (int)UserStatus.Rejected,
                Status = "Rejected",
            });

            return modelBuilder;
        }
    }
}

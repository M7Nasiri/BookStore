using BookStoreShop.Models.Domain.Entities.UserAgg;
using BookStoreShop.Models.Domain.Entities.UserAgg.Enums;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookStoreShop.Models.Infrastructure.Configurations
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(new User
            {
                Id =1,
                FullName = "admin",
                Password="123",
                Role=Roles.Admin,
                UserName = "admin"
            });
        }
    }
}

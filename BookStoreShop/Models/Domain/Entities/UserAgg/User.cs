using BookStoreShop.Models.Domain.Entities.UserAgg.Enums;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;

namespace BookStoreShop.Models.Domain.Entities.UserAgg
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? UserImagePath { get; set; }
        public Roles Role { get; set; }
    }
}

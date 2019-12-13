using Microsoft.EntityFrameworkCore;
using UnheardApi.Models;

namespace UnheardApi.Data
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {
        }

        public DbSet<User> UserInfo { get; set; }
    }
}
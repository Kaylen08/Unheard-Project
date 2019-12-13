using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UnheardApi.Models
{
    public class UnheardApiContext : DbContext
    {
        public UnheardApiContext (DbContextOptions<UnheardApiContext> options)
            : base(options)
        {
        }

        public DbSet<UnheardApi.Models.User> User { get; set; }
    }
}

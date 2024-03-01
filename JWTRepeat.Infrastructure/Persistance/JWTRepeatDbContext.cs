using JWTRepeat.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTRepeat.Infrastructure.Persistance
{
    public class JWTRepeatDbContext : DbContext
    {
        public JWTRepeatDbContext(DbContextOptions<JWTRepeatDbContext> ops)
            : base(ops)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}

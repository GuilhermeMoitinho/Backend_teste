using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using houseasy_API.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace houseasy_API.Infrastructure.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op) { }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}
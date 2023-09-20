using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using houseasy_API.Models;
using Microsoft.EntityFrameworkCore;

namespace houseasy_API.DataContext
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> op) : base(op){}

        public DbSet<Usuario> Usuarios {get; set;}
    }
}
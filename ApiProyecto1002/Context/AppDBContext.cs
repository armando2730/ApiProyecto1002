using ApiProyecto1002.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiProyecto1002.Context
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }
        public DbSet<usuarios> usuarios { get; set; }
    }
}

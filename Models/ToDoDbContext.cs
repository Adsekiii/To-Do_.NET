using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ToDoElement> Elements { get; set; }

        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
            
        }
    }
}

namespace DAL;
using Microsoft.EntityFrameworkCore;
using Model;

public class AppDbContext : DbContext 
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    DbSet<TodoItem> TodoItems { get; set; }
}
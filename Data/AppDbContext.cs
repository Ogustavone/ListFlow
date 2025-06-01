using Microsoft.EntityFrameworkCore;
using ListFlow.Models;

namespace ListFlow.Data;

public class AppDbContext : DbContext
{
    public DbSet<TaskModel> Tasks { get; set; }
    public DbSet<UserModel> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = (
            Environment.GetEnvironmentVariable("LISTFLOW_DBCONNECTION_STRING") ??
            "Host=localhost;Port=5432;Database=listflow;Username=postgres;Password=postgres"
        );
        optionsBuilder.UseNpgsql(connectionString);
        base.OnConfiguring(optionsBuilder);
    }
}

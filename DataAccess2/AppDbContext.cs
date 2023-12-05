using DataAccess2.Entities2;
using Microsoft.EntityFrameworkCore;

namespace DataAccess2;

public class AppDbContext : DbContext
{
    public DbSet<BlogEntity> Blogs { get; set; } = null!;


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=DESKTOP-0M7APTU;Initial Catalog=BlogOvningarFemDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
    }
}
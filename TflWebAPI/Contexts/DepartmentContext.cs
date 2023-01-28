
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics.Internal;
using TflWebAPI.Model;

namespace TflWebAPI.Contexts;
public class DepartmentContext : DbContext
{
    
    public DbSet<Department> Departments { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string conString = "server=localhost;port=3306;user=root;password=password;database=transflower";
        optionsBuilder.UseMySQL(conString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Location).IsRequired();
           
        });
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchDemo.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchDemo.Infrastructure.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Product> Products => Set<Product>();

    public DbSet<User> Users => Set<User>();

    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>()
            .HasOne(s => s.Course)
            .WithMany(c => c.Students)
            .HasForeignKey(s => s.CourseId);
    }
}
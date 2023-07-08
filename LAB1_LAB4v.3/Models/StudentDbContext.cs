using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LAB1_LAB4v._3.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }
    
}

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace LAB1_LAB4v._3.Models
{
    public class StudentDbContext : IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Student { get; set; } = null!;
    }
    
}

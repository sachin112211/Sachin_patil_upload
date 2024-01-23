using Microsoft.EntityFrameworkCore;

namespace Sachin_patil_upload.Models
{
    public class StudentDBContext : DbContext
    {

        public StudentDBContext() { }


        public StudentDBContext(DbContextOptions<StudentDBContext> options) : base(options)
        {

        }

        public virtual DbSet<Student> Students { get; set; }


    }
}

using Microsoft.EntityFrameworkCore;
namespace WebApplication3.Models
{
    public class PatientDbContext : DbContext
    {
        public PatientDbContext()
        {
        }

        public PatientDbContext(DbContextOptions<PatientDbContext> options)
               : base(options)
        {
        }
        public DbSet<Doctors> doctors { get; set; }
        public DbSet<Nurses> nurses { get; set; }
        public DbSet<Patients> patients { get; set; }
        public DbSet<Admins> Admin { get; set; }
    }
}
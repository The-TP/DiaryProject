
using DataAccess.Models.DanhMuc;
using Microsoft.EntityFrameworkCore;
namespace DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<chi_nhanh> chi_nhanhs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //write sql command into output debug window
            //optionsBuilder.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
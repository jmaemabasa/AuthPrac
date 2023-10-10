using AuthPrac.Shared.Models.User;
using Microsoft.EntityFrameworkCore;

namespace AuthPrac.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }



        public DbSet<UserMasterT> UserMasterT { get; set; }
    }
}

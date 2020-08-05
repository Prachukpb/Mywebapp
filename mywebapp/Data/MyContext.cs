using Microsoft.EntityFrameworkCore;
using mywebapp.Model;

namespace mywebapp.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }
        public DbSet<Emails> MywebMessage { get; set; }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Data;

namespace Repository
{
    class ApplicationDbContext : IdentityDbContext
    {
        protected ApplicationDbContext()
        {
        }
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Local_Movie> Local_Movie { get; set; }
        public DbSet<Buys_Ticket> Buys_Ticket { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Manager> Manager { get; set; }
        public DbSet<Ticket_Agent> Ticket_Agent { get; set; }
        public DbSet<Movie_Member> Movie_Member { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Retired> Retired { get; set; }
        public DbSet<Child> Child { get; set; }


    }
}

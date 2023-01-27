using Microsoft.EntityFrameworkCore;
using Dws.Note_One.Api.Domain.Models;
namespace Dws.Note_One.Api.Persistence.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<User>().ToTable("Users");
            builder.Entity<User>().HasKey(u => u.Id);
            builder.Entity<User>().Property(u => u.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<User>().Property(u => u.Name).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(u => u.Email).IsRequired().HasMaxLength(50);
            builder.Entity<User>().Property(u => u.Password).IsRequired().HasMaxLength(30);
            builder.Entity<User>().HasData
            (
            new User
            {
                Id = 1,
                Name = "Francisco Das Chagas",
                Email = "francisco@email.com",
                Password = "123456"
            },
            new User
            {
                Id = 2,
                Name = "Joao a",
                Email = "Joao@email.com",
                Password = "123456"

            }


            );



        }
    }
}
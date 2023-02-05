using LawBuddy.Domain.Users;
using Microsoft.EntityFrameworkCore;

namespace LawBuddy.Infrastructure.Db;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<User> Users => Set<User>();

    public DbSet<Contract> Contracts => Set<Contract>();

    public DbSet<Address> Addresses => Set<Address>();
}

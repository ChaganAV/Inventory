using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;

namespace Inventory.Data;

public class IntentoryDbContext : DbContext
{
    public IntentoryDbContext(DbContextOptions<IntentoryDbContext> options) : base(options) {}
    public DbSet<Inventory.Models.Product> Products {get; set;}
}
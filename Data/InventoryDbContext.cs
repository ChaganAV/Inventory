using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Inventory.Models;

    public class InventoryDbContext : DbContext
    {
        public InventoryDbContext (DbContextOptions<InventoryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Inventory.Models.Product> Product { get; set; } = default!;
    }

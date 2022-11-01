using System.Collections.Generic;
using System.Linq;
namespace Inventory.Models
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product> {
                new Product{Name = "ПЭВМ Aquarius Pro P30 K40 R43", Serial = "2220516011401-0061"},
                new Product{Name = "ПЭВМ Aquarius Pro P30 K40 R43", Serial = "2220516011401-0005"}
        }.AsQueryable<Product>();
    }
}
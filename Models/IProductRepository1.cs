using System.Linq;
namespace Inventory.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products {get;}
    }
}
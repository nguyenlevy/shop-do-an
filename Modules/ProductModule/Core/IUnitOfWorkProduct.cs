using Common.Models.Categories;
using Common.Models.Products;
using System.Threading.Tasks;

namespace ProductModule.Core
{
    public interface IUnitOfWorkProduct
    {
        Task Commit();

        GenericRepository<Product> ProductRepository { get; }
        GenericRepository<ProductCategory> ProductCategoryRepository { get; }
        GenericRepository<ProductManufacturer> ProductManufacturerRepository { get; }
        GenericRepository<Category> CategoryRepository { get; }
    }
}

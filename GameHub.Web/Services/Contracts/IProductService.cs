using GameHub.Web.Models;

namespace GameHub.Web.Services.Contracts
{
    public interface IProductService
    {
        Task<IEnumerable<ProductViewModel>> GetAllProducts();
        Task<IEnumerable<ProductViewModel>> FindProductById(int id);
        Task<IEnumerable<ProductViewModel>> CreateProduct(ProductViewModel productVM);
        Task<IEnumerable<ProductViewModel>> UpdateProduct(ProductViewModel productVM);
        Task<bool> DeleteById(int id);

    }
}

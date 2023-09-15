using GameHub.Web.Models;
using GameHub.Web.Services.Contracts;

namespace GameHub.Web.Services;

public class ProductService : IProductService
{
    private readonly IHttpClientFactory _clientFactory;
    private const string apiEndpoint = "api/products";

    public ProductService(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
    }

    public Task<IEnumerable<ProductViewModel>> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductViewModel>> FindProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ProductViewModel>> CreateProduct(ProductViewModel productVM)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteById(int id)
    {
        throw new NotImplementedException();
    }

    

    

    public Task<IEnumerable<ProductViewModel>> UpdateProduct(ProductViewModel productVM)
    {
        throw new NotImplementedException();
    }
}

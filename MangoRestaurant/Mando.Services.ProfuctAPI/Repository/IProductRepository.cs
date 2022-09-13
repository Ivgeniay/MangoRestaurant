using Mando.Services.ProductAPI.Models.Dto;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace Mando.Services.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct (ProductDto productDto);
        Task<bool> DeleteProduct(int productId);

    }
}

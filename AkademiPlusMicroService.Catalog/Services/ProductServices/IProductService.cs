using AkademiPlusMicroService.Catalog.Dtos.CategoryDtos;
using AkademiPlusMicroService.Catalog.Dtos.ProductDtos;
using AkademiPlusMicroService.Shared.Dtos;

namespace AkademiPlusMicroService.Catalog.Services.ProductServices
{
    public interface IProductService
    {
        Task<Response<List<ResultProductDto>>> GetAllProducts();
        Task<Response<ResultProductDto>> GetByIdProduct(string id);
        Task<Response<NoContent>> CreateProduct(CreateProductDto createProductDto);
        Task<Response<NoContent>> UpdateProduct(UpdateProductDto updateProductDto);
        Task<Response<NoContent>> DeleteProduct(string id);
    }
}

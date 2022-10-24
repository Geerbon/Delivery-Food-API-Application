using DelFood.Web.ProductAPI.Models;

namespace DelFood.Web.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();

        //Получение ссылки на товар по его идентификатору
        Task<ProductDto> GetProductById(int productId);

        //Работа с новым товаром
        Task<ProductDto> CreateUpdateProduct(ProductDto productDto);

        Task<bool> DeleteProduct(int productId);


    }
}

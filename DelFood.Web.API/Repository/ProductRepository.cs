using AutoMapper;
using DelFood.Web.ProductAPI.DbContexts;
using DelFood.Web.ProductAPI.Models;
using DelFood.Web.ProductAPI.Models.Dto;
using Microsoft.EntityFrameworkCore;

namespace DelFood.Web.ProductAPI.Repository
{

    public class ProductRepository : IProductRepository
    {
        //Доступ в БД

        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
         
        public ProductRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<ProductDto> CreateUpdateProduct(ProductDto productDto)
        {
            //Тк на входе модель ProductDto маппип его до Product, но в конце не забыть вернуть его
            Product product = _mapper.Map<ProductDto, Product>(productDto);
            if (product.ProductId > 0)
            {
                _db.Products.Update(product);
            }
            else
            {
                _db.Products.Add(product);
            }
            await _db.SaveChangesAsync();
            return _mapper.Map<Product,ProductDto>(product);
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            try
            {
                //Ссылка на товар
                Product product = await _db.Products.FirstOrDefaultAsync(x => x.ProductId == productId);
               if (product == null)
                {
                    return false;

                }
                _db.Products.Remove(product);
                await _db.SaveChangesAsync();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        public async Task<ProductDto> GetProductById(int productId)
        {
            Product product = await _db.Products.Where(x => x.ProductId == productId)
                                                .FirstOrDefaultAsync();
            return _mapper.Map<ProductDto>(product);
        }

        public async Task<IEnumerable<ProductDto>> GetProducts()
        {
            List<Product> productList = await _db.Products.ToListAsync();
            return _mapper.Map<List<ProductDto>>(productList);
        }
    }
}

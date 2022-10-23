using AutoMapper;
using DelFood.Web.ProductAPI.Models;
using DelFood.Web.ProductAPI.Models.Dto;

namespace DelFood.Web.ProductAPI
{
    public class MappingConfig
    {

        //Для конвертации из ProductDto в Product и наоборот
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
                        {
                            config.CreateMap<ProductDto, Product>();
                            config.CreateMap<Product, ProductDto>();
                        });
            return mappingConfig;
        }
    }
}

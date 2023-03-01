using AutoMapper;
using VinWin.Sevices.ProductAPI.Models;
using VinWin.Sevices.ProductAPI.Models.Dto;

namespace VinWin.Sevices.ProductAPI
{
    public class MappingConfig
    {
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

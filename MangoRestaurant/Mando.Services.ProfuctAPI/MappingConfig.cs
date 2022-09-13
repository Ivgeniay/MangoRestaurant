using AutoMapper;
using Mando.Services.ProductAPI.Models;
using Mando.Services.ProductAPI.Models.Dto;

namespace Mando.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });

            return mappingConfig;
        }

    }
}

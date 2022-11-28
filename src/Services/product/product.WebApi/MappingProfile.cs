using AutoMapper;
using product.Domain.Models;
using product.Shared.DataTransferObjects;

namespace product.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryDto>();
            CreateMap<ProductCategoryForCreationDto, ProductCategory>();
            CreateMap<Product, ProductDto>();
        }
    }
}

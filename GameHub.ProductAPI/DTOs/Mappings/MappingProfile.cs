using AutoMapper;
using GameHub.ProductAPI.Models;

namespace GameHub.ProductAPI.DTOs.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();

        }
    }
}

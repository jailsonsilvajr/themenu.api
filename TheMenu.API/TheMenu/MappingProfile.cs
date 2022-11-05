using AutoMapper;
using TheMenu.Domain.DTOs;
using TheMenu.Domain.Entities;

namespace TheMenu
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>();

            CreateMap<Category, CategoryDTO>();
        }
    }
}

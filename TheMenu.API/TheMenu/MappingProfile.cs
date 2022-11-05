using AutoMapper;
using TheMenu.Domain.DTOs;
using TheMenu.Domain.Entities;

namespace TheMenu
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>()
                .ForMember(c => c.CategoryName, opt => opt.MapFrom(x => x.Category != null ? x.Category.Name : "Uncategorized yet"));
        }
    }
}

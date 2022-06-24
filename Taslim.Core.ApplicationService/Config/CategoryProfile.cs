using AutoMapper;
using Taslim.Core.Domain.DTOs;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.ApplicationService.Config
{
    public class CategoryProfile : Profile
    {

        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>();
        }
    }
}

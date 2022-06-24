using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Taslim.Core.Domain.DTOs;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.ApplicationService.Config
{
    public class NewsProfile:Profile
    {

        public NewsProfile()
        {
            CreateMap<News, NewsDTO>()
           .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Title));
            CreateMap<Category, CategoryDTO>();
        }
    }
}

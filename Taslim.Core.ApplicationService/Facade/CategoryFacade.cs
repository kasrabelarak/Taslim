using AutoMapper;
using System.Collections.Generic;
using Taslim.Core.Contracts.Facade;
using Taslim.Core.Contracts.Repository;
using Taslim.Core.Domain.DTOs;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.ApplicationService.Facade
{
    public class CategoryFacade : ICategoryFacade
    {
        ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryFacade(ICategoryRepository categoryRepository,IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public IEnumerable<CategoryDTO> GetAll()
        {
            List<Category> categories = categoryRepository.GetAll();
            List<CategoryDTO> categoryDTOs = 
                mapper.Map<List<Category>,List< CategoryDTO >> (categories);
           
            return categoryDTOs;
        }
    }
}

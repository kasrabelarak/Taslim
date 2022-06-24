using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Taslim.Core.Contracts.Repository;
using Taslim.Core.Domain.Entites;
using Taslim.Infrastructure.EF;

namespace Taslim.Infrastructure.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DemoContext context;
        public CategoryRepository(DemoContext context)
        {
            this.context = context;
        }

        public List<Category> GetAll()
        {
            return context.Categories.Include(a => a.News).ToList();
        }

        public Category Get(int id)
        {
            return context.Categories.Include(a => a.News).First(a => a.CategoryId == id);
        }


    }
}

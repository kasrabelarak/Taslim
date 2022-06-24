using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Taslim.Core.Contracts.Repository;
using Taslim.Core.Domain.Entites;
using Taslim.Infrastructure.EF;

namespace Taslim.Infrastructure.Data
{
    public class NewsReposiotry : INewsRepository
    {
        private readonly DemoContext context;
        public NewsReposiotry(DemoContext context)
        {
            this.context = context;

        }
        public List<News> GetHotestNews(int count)
        {
            return context.News.OrderByDescending(a => a.PubDate).Take(count).ToList();
        }

        public List<News> HomeSearch(string search)
        {
            return context.News.Where
                (a => a.Title.Contains(search) || a.Summery.Contains(search)).ToList();
        }

        public News Get(int id)
        {
            return context.News.Find(id);
        }

        public List<News> FindByCategory(int categoryId)
        {
            return context.News.Include(a => a.Category)
                .Where(a => a.CategoryId == categoryId).ToList();
        }
    }
}

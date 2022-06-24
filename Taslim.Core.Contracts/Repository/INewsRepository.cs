using System.Collections.Generic;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.Contracts.Repository
{
    public interface INewsRepository
    {
        List<News> GetHotestNews(int count);
        List<News> HomeSearch(string search);
        News Get(int id);

        List<News> FindByCategory(int categoryId);
    }
}

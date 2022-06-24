using System.Collections.Generic;
using Taslim.Core.Domain.DTOs;

namespace Taslim.Core.Contracts.Facade
{
    public interface INewsFacade
    {
        IEnumerable<NewsDTO> GetHotteseNews(int count);
        IEnumerable<NewsDTO> FindByCategory(int categoryId);
        IEnumerable<NewsDTO> Search(string text);
    }


}

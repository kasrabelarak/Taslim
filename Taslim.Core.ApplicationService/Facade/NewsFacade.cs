using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Taslim.Core.Contracts.Facade;
using Taslim.Core.Contracts.Repository;
using Taslim.Core.Domain.DTOs;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.ApplicationService.Facade
{
    public class NewsFacade : INewsFacade
    {
        INewsRepository newsReposiotry;
        private readonly IMapper mapper;

        public NewsFacade(INewsRepository newsReposiotry,IMapper mapper)
        {
            this.newsReposiotry = newsReposiotry;
            this.mapper = mapper;
        }

        public IEnumerable<NewsDTO> GetHotteseNews(int count)
        {
            List<News> news = newsReposiotry.GetHotestNews(count);
            List<NewsDTO> newsDTOs =
                mapper.Map<List<News>, List<NewsDTO>>(news);
            return newsDTOs;
        }


        public IEnumerable<NewsDTO> FindByCategory(int categoryId)
        {

            var news = newsReposiotry.FindByCategory(categoryId);
            List<NewsDTO> newsDTOs =
                 mapper.Map<List<News>, List<NewsDTO>>(news);
            return newsDTOs;
        }

        public IEnumerable<NewsDTO> Search(string text)
        {
            List<News> news = newsReposiotry.HomeSearch(text);
            List<NewsDTO> newsDTOs =
                 mapper.Map<List<News>, List<NewsDTO>>(news);
            return newsDTOs;
        }


    }
}

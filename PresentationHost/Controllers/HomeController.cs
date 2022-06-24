using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PresentationHost.Models;
using PresentationHost.Service;
using Taslim.Core.Contracts.Facade;
using Taslim.Core.Domain.DTOs;

namespace PresentationHost.Controllers
{
    public class HomeController : Controller
    {
        INewsFacade newsFacade;
        ICategoryFacade categoryFacade;
        private readonly IViewerCountService viewerCountService;

        public HomeController(INewsFacade newsFacade, ICategoryFacade categoryFacade,IViewerCountService viewerCountService)
        {
            this.newsFacade = newsFacade;
            this.categoryFacade = categoryFacade;
            this.viewerCountService = viewerCountService;
        }
        public IActionResult Index(int categoryId, string search)
        {
            IEnumerable<NewsDTO> news = new List<NewsDTO>();

            if (!string.IsNullOrEmpty(search))
            {
                news = newsFacade.Search(search);
            }
            else if (categoryId != 0)
            {
                news = newsFacade.FindByCategory(categoryId);
            }
            else
            {
                news = newsFacade.GetHotteseNews(5);
            }


            IEnumerable<CategoryDTO> categories = categoryFacade.GetAll();

            NewsViewModel model = new NewsViewModel()
            {
                News = news,
                Categories = categories

            };
            ViewBag.viewerCount = viewerCountService.IncrementViewer();
            return View(model);
        }
    }
}

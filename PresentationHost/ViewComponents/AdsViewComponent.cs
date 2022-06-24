
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Taslim.Core.Contracts.Repository;
using Taslim.Core.Domain.Entites;

namespace Taslim.ViewComponents
{
    public class AdsViewComponent: ViewComponent
    {
        IAdsRepository adsRepository;
        public AdsViewComponent(IAdsRepository adsRepository)
        {
            this.adsRepository = adsRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Ads> model = adsRepository.GetAds();
            return View(model);
        }
    }
}

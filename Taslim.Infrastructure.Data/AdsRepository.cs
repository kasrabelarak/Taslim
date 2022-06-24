using System;
using System.Collections.Generic;
using System.Linq;
using Taslim.Core.Contracts.Repository;
using Taslim.Core.Domain.Entites;
using Taslim.Infrastructure.EF;

namespace Taslim.Infrastructure.Data
{
    public class AdsRepository : IAdsRepository
    {
        private readonly DemoContext context;
        public AdsRepository(DemoContext context)
        {
            this.context = context;

        }

        public List<Ads> GetAds()
        {
            return context.Ads.ToList();
        }


    }
}

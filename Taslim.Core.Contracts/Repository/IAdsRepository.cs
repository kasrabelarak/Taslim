using System.Collections.Generic;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.Contracts.Repository
{
    public interface IAdsRepository
    {
        List<Ads> GetAds();
    }
}

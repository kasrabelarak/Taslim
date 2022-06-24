using System.Collections.Generic;
using Taslim.Core.Domain.DTOs;
using Taslim.Core.Domain.Entites;

namespace PresentationHost.Models
{
    public class NewsViewModel
    {
        public IEnumerable<NewsDTO> News { get; set; }
        public IEnumerable<CategoryDTO> Categories { get; set; }
        public List<Ads> Ads { get; set; }
    }
}

using System.Collections.Generic;

namespace Taslim.Core.Domain.Entites
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public List<News> News { get; set; }
    }
}

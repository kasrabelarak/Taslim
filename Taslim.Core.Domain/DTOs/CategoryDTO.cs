using System;
using System.Collections.Generic;
using System.Text;

namespace Taslim.Core.Domain.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }

        public int NewsCount { get; set; }
    }
}

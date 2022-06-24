namespace Taslim.Core.Domain.DTOs
{
    public class NewsDTO
    {
        public int NewsId { get; set; }
        public string Title { get; set; }
        public string Summery { get; set; }
        public string Text { get; set; }
        public string ImagePath { get; set; }

        public string CategoryName { get; set; }

        public int CategoryId { get; set; }

    }
}

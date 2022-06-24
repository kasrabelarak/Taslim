using Microsoft.EntityFrameworkCore;
using System;
using Taslim.Core.Domain.Entites;

namespace Taslim.Infrastructure.EF
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        public DbSet<News> News { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ads> Ads { get; set; }
    }
}

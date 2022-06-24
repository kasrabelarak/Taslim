using System;
using System.Collections.Generic;
using System.Text;
using Taslim.Core.Domain.Entites;

namespace Taslim.Core.Contracts.Repository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        Category Get(int id);
    }
}

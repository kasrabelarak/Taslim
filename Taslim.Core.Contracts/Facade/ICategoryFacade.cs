using System;
using System.Collections.Generic;
using System.Text;
using Taslim.Core.Domain.DTOs;

namespace Taslim.Core.Contracts.Facade
{
    public interface ICategoryFacade
    {
        IEnumerable<CategoryDTO> GetAll();
    }


}

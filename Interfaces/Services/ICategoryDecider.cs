using System.Collections;
using System.Collections.Generic;
using Interfaces.Entities;

namespace Interfaces.Services
{
    public interface ICategoryDecider
    {
        ICategory DecideCategory(IList<ICategory> possibleCategories);
    }
}
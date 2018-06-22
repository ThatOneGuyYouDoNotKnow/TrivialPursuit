using System.Collections.Generic;
using Interfaces.Entities;
using JetBrains.Annotations;

namespace Interfaces.Services
{
    public interface ICategoryDecider
    {
        [NotNull]
        ICategory DecideCategory([NotNull] [ItemNotNull] IList<ICategory> possibleCategories);
    }
}

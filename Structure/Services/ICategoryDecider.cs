using System.Collections.Generic;
using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface ICategoryDecider
    {
        [NotNull]
        ICategory DecideCategory([NotNull] [ItemNotNull] IList<ICategory> possibleCategories);
    }
}

using System.Collections.Generic;
using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface ICategoryDeciderFactory
    {
        [NotNull]
        ICategoryDecider GetCategoryDecider(
            [NotNull] IField field,
            [NotNull] IPlayer currentPlayer,
            [NotNull] [ItemNotNull] IDictionary<IPlayer, IScore> scores);
    }
}

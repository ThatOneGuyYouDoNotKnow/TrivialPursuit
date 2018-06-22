using System.Collections.Generic;
using Interfaces.Entities;
using JetBrains.Annotations;

namespace Interfaces.Services
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

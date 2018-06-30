using System.Collections.Generic;
using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface IDestinationDecider
    {
        [NotNull]
        IField DecideWhereToGo(
            [NotNull] [ItemNotNull] IList<IField> possibleFields,
            [NotNull] IPlayer player,
            [NotNull] IScore score);
    }
}

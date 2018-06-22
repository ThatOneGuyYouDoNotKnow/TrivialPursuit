using System.Collections.Generic;
using Interfaces.Entities;
using JetBrains.Annotations;

namespace Interfaces.Services
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

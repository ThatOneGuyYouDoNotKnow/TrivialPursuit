using System.Collections.Generic;
using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface IDestinationFinder
    {
        [NotNull]
        [ItemNotNull]
        IList<IField> GetPossibleDestinations([NotNull] IBoard board, [NotNull] IField currentField, int distance);
    }
}

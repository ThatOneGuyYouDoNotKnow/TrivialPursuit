using System.Collections.Generic;
using Interfaces.Entities;
using JetBrains.Annotations;

namespace Interfaces.Services
{
    public interface IDestinationFinder
    {
        [NotNull]
        [ItemNotNull]
        IList<IField> GetPossibleDestinations([NotNull] IBoard board, [NotNull] IField currentField, int distance);
    }
}

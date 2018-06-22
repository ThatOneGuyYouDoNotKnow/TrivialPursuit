using System.Collections.Generic;
using Interfaces.Entities;

namespace Interfaces.Services
{
    public interface IDestinationFinder
    {
        IList<IField> GetPossibleDestinations(IBoard board, IField currentField, int distance);
    }
}
using System.Collections.Generic;
using Interfaces.Entities;

namespace Interfaces.Services
{
    public interface IDestinationDecider
    {
        IField DecideWhereToGo(IList<IField> possibleFields, IPlayer player);
    }
}

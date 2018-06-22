using System.Collections.Generic;
using Interfaces.Entities;

namespace Interfaces.Services
{
    public interface ICategoryDeciderFactory
    {
        ICategoryDecider GetHowToDecideOnACategory(IField field, IPlayer currentPlayer,
            IDictionary<IPlayer, IScore> scores);
    }
}
using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface IDiceRollingService
    {
        int RollTheDice([NotNull] IDice dice);
    }
}

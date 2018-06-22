using JetBrains.Annotations;

namespace Interfaces.Services
{
    public interface IDiceRollingService
    {
        int RollTheDice([NotNull] IDice dice);
    }
}

using Interfaces.Entities;
using JetBrains.Annotations;

namespace Interfaces.Services
{
    public interface IQuestionFinder
    {
        [NotNull]
        IQuestion GetQuestion([NotNull] ICard card, [NotNull] ICategory category);
    }
}

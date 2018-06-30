using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface IQuestionFinder
    {
        [NotNull]
        IQuestion GetQuestion([NotNull] ICard card, [NotNull] ICategory category);
    }
}

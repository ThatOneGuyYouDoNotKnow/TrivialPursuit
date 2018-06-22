using Interfaces.Entities;
using JetBrains.Annotations;

namespace Interfaces.Services
{
    public interface IQuestionAnswerService
    {
        bool AnswerQuestion([NotNull] IQuestion question, [NotNull] IPlayer player);
    }
}

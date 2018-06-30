using JetBrains.Annotations;
using Structure.Entities;

namespace Structure.Services
{
    public interface IQuestionAnswerService
    {
        bool AnswerQuestion([NotNull] IQuestion question, [NotNull] IPlayer player);
    }
}

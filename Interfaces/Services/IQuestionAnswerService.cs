using Interfaces.Entities;

namespace Interfaces.Services
{
    public interface IQuestionAnswerService
    {
        bool AnswerQuestion(IQuestion question, IPlayer player);
    }
}